﻿Imports MatchInfo

Public Class frmGoals
  Private _match As Match
  Public Property Match As Match
    Get
      Return _match
    End Get
    Set(value As Match)
      _match = value
      ShowGoals()
    End Set
  End Property

#Region "Functions"

  Private _initializing As Boolean = False

  Private Sub ShowGoals(Optional selected As MatchGoal = Nothing)
    Try
      _initializing = True
      With Me.MetroGridGoals
        .Rows.Clear()
        Dim goals As MatchGoals = _match.MatchGoals
        goals.Sort()
        For Each goal As MatchGoal In goals
          Dim item As Integer = .Rows.Add(CStr(goal.GoalID))
          Dim team As Team = IIf(_match.HomeTeam.ID = goal.TeamGoalID, _match.HomeTeam, _match.AwayTeam)

          .Rows(item).Cells(ColumnTime.Index).Value = FormatRunningTime(goal.TimeSecond)
          If _match.HomeTeam.ID = goal.TeamGoalID Then
            If goal.GoalType = MatchGoal.eGoalType.Own Then
              team = _match.AwayTeam
            Else
              team = _match.HomeTeam
            End If
            Dim player As Player = IIf(goal.PlayerID <> 0, team.GetPlayerById(goal.PlayerID), Nothing)
            .Rows(item).Cells(ColumnHomeGoal.Index).Value = "goal"
            .Rows(item).Cells(ColumnHomeType.Index).Value = goal.GoalType.ToString
            If Not player Is Nothing Then
              .Rows(item).Cells(ColumnHomePlayer.Index).Value = player.ToString
            Else
              .Rows(item).Cells(ColumnHomePlayer.Index).Value = ""
            End If
            .Rows(item).Cells(ColumnAwayGoal.Index).Value = ""
            .Rows(item).Cells(ColumnAwayPlayer.Index).Value = ""
            .Rows(item).Cells(ColumnAwayType.Index).Value = ""
          Else
            If goal.GoalType = MatchGoal.eGoalType.Own Then
              team = _match.HomeTeam
            Else
              team = _match.AwayTeam
            End If
            Dim player As Player = IIf(goal.PlayerID <> 0, team.GetPlayerById(goal.PlayerID), Nothing)
            .Rows(item).Cells(ColumnAwayGoal.Index).Value = "goal"
            .Rows(item).Cells(ColumnAwayType.Index).Value = goal.GoalType.ToString
            If Not player Is Nothing Then
              .Rows(item).Cells(ColumnAwayPlayer.Index).Value = player.ToString
            Else
              .Rows(item).Cells(ColumnAwayPlayer.Index).Value = ""
            End If
            .Rows(item).Cells(ColumnHomeGoal.Index).Value = ""
            .Rows(item).Cells(ColumnHomePlayer.Index).Value = ""
            .Rows(item).Cells(ColumnHomeType.Index).Value = ""
          End If
          '.Rows(item).Cells(ColumnOutPlayer.Index).Value = subst.PlayerOut.ToString
          '.Rows(item).Cells(ColumnTeam.Index).Value = subst.Team.ToString
          '.Rows(item).Cells(ColumnTime.Index).Value = subst.part & "p " & subst.timeInSeconds & "s"
          '.Rows(item).Cells(ColumnPlayerInID.Index).Value = subst.PlayerIn.PlayerID
          '.Rows(item).Cells(ColumnPlayerOutID.Index).Value = subst.PlayerOut.PlayerID
          'If Not _substitution Is Nothing Then
          '  .Rows(item).Selected = (subst.ToString = _substitution.ToString)
          'Else
          '  .Rows(item).Selected = False
          'End If
        Next
      End With
      'ShowSelecteSubstitiution()
    Catch ex As Exception

    End Try
    _initializing = False
  End Sub

  Private Sub MetroGridGoals_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGridGoals.CellDoubleClick
    Try
      Dim goal As MatchGoal
      goal = Me.Match.MatchGoals.GetGoal(CInt(MetroGridGoals.Rows(e.RowIndex).Cells(ColumnID.Index).Value))
      If Not goal Is Nothing Then
        Dim frm As New frmGoal(Me.Match, goal)
        If frm.ShowDialog(Me) = DialogResult.OK Then
          'do something
          Me.ShowGoals()
          _match.SaveMatchGoalsToDB(True)
        End If
      End If
    Catch ex As Exception

    End Try
  End Sub

#End Region

#Region "Remove goal"
  Private Sub MetroButtonRemoveGoal_Click(sender As Object, e As EventArgs) Handles MetroButtonRemoveGoal.Click
    Try
      Dim goal As MatchGoal
      If MetroGridGoals.SelectedRows.Count = 0 Then Exit Sub

      goal = Me.Match.MatchGoals.GetGoal(CInt(MetroGridGoals.Rows(MetroGridGoals.SelectedRows(0).Index).Cells(ColumnID.Index).Value))
      If Not goal Is Nothing Then
        If frmWaitForInput.ShowWaitDialog(Me, "Delete selected goal?", "Goals", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
          Me.Match.RemoveGoal(goal)
          Me.ShowGoals()
        End If
      End If
    Catch ex As Exception

    End Try
  End Sub

  Private Sub MetroGridGoals_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGridGoals.CellContentClick

  End Sub

  Private Sub MetroButtonAddAwayTeamSubstitition_Click(sender As Object, e As EventArgs) Handles MetroButtonAddAwayTeamSubstitition.Click
    Try
      If _match Is Nothing Then Exit Sub
      Dim team As Team = _match.HomeTeam

      If frmWaitForInput.ShowWaitDialog(Me, "Do you want to set a goal to " & team.TeamAELCaption1Name & "?", _match.ToString, MessageBoxButtons.OKCancel) = DialogResult.OK Then
        Dim gsList As New GraphicSteps

        Dim gg As New ControlScoreSingleGoal(_match, _match.LastGoal)

        gg.IsLocalTeam = True
        gg.Goal = _match.AddGoal(True, Nothing, False, False)

        Dim _dlgChoosWithPreview As FormChoose = New FormChoose(Nothing, Nothing, gg)
        _dlgChoosWithPreview.ShowPreview = False
        If _dlgChoosWithPreview.ShowDialog(Me) = DialogResult.Cancel Then
          _match.RemoveLastGoal()
        End If
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub MetroButtonAddHomeTeamSubstitition_Click(sender As Object, e As EventArgs) Handles MetroButtonAddHomeTeamSubstitition.Click
    Try
      If _match Is Nothing Then Exit Sub
      Dim team As Team = _match.AwayTeam

      If frmWaitForInput.ShowWaitDialog(Me, "Do you want to set a goal to " & team.TeamAELCaption1Name & "?", _match.ToString, MessageBoxButtons.OKCancel) = DialogResult.OK Then
        Dim gsList As New GraphicSteps


        Dim gg As New ControlScoreSingleGoal(_match, _match.LastGoal)
        gg.IsLocalTeam = False
        gg.Goal = _match.AddGoal(False, Nothing, False, False)

        Dim _dlgChoosWithPreview As FormChoose = New FormChoose(Nothing, Nothing, gg)
        _dlgChoosWithPreview.ShowPreview = False
        If _dlgChoosWithPreview.ShowDialog(Me) = DialogResult.Cancel Then
          _match.RemoveLastGoal()
        End If
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub MetroGridGoals_SelectionChanged(sender As Object, e As EventArgs) Handles MetroGridGoals.SelectionChanged

  End Sub

  Private Sub MetroButtonShowSelectedGoal_Click(sender As Object, e As EventArgs) Handles MetroButtonShowSelectedGoal.Click

  End Sub


#End Region
End Class
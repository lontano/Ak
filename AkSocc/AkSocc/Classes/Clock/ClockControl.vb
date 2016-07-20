﻿Imports VizCommands
Imports MatchInfo

Public NotInheritable Class ClockControl
#Region "Singleton"
  Private Shared ReadOnly _instance As New Lazy(Of ClockControl)(Function() New ClockControl(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

  Private Sub New()
    Me.InitScene()
  End Sub

  Public Shared ReadOnly Property Instance() As ClockControl
    Get
      Return _instance.Value
    End Get
  End Property
#End Region

#Region "Properties"
  Private WithEvents _vizControl As VizControl
  Public Property VizControl As VizControl
    Get
      Return _vizControl
    End Get
    Set(value As VizControl)
      _vizControl = value
    End Set
  End Property

  Private WithEvents _match As Match
  Public Property Match As Match
    Get
      Return _match
    End Get
    Set(value As Match)
      _match = value
      _matchPeriod = _match.MatchPeriods.ActivePeriod
      _homeTeam = _match.HomeTeam
      _awayTeam = _match.AwayTeam
      Me.InitScene()
    End Set
  End Property

  Private WithEvents _matchPeriod As Period

  Public Property ResultatEquipLocal As Decimal = -1D
  Public Property ResultatEquipVisitant As Decimal = -1D
  Public Property Part As String
  Public Property IDPart As Integer
  Public Property Temps As Long
  Public Property PartAfegit As String
  Public Property TempsAfegit As Long = -1
  Public Property TempsTotal As Long
  Public Property Scene As New Scene
  Public Property Visible As Boolean = False
  Public Property RequestVisible As Boolean = False
  Public Property Active As Boolean = False
  Public Property AddedTimeVisible As Boolean = False
  Public Property AddedTimeVisibleAuto As Boolean = True
  Public Property AddedTimeTotalVisible As Boolean = False
  Public Property nPuOffsetTime As Long

  Private _showRedCards As Boolean
  Public Property ShowRedCards As Boolean
    Get
      Return _ShowRedCards
    End Get
    Set(value As Boolean)
      _ShowRedCards = value
    End Set
  End Property

  Private WithEvents _homeTeam As Team
  Private WithEvents _awayTeam As Team
  Private HomeRedCards As Integer = 0
  Private AwayRedCards As Integer = 0

#End Region

  Public Event Updated()


#Region "Initialization"

  Public Shared Function GetClockBaseScene() As Scene
    Dim scene As New Scene
    With scene
      .SceneName = "gfx_Clock"
      .SceneDirector = "DIR_MAIN"
      .VizLayer = SceneLayer.Back
    End With
    Return scene
  End Function

  Private Sub InitScene()
    UpdateAndSendScene(True)
    Me.Scene.RewindSceneDirectors(_vizControl, Scene.TypeOfDirectors.InDirectors)
    ClockVisible = False
    _request = False
    _clockOnAir = False

    _addedTimeTimer.Interval = 200
    _addedTimeTimer.Enabled = True

    RaiseEvent Updated()
  End Sub
#End Region

#Region "Period Functions"
  Public Function StartPeriod(part As Integer, Optional startTime As Integer = 0) As Period
    Dim res As Period = Nothing
    Try
      _match.MatchPeriods.StartPeriod(part, startTime)

    Catch ex As Exception

    End Try
    Return _match.MatchPeriods.ActivePeriod
  End Function

  Public Function EndPeriod(part As Integer) As Period
    Try
      _match.MatchPeriods.EndPeriod(part)
    Catch ex As Exception

    End Try
    Return _match.MatchPeriods.ActivePeriod
  End Function

  Private Sub _matchPeriod_ActiveStateChanged(sender As Period) Handles _matchPeriod.ActiveStateChanged

  End Sub
#End Region

#Region "Visibility control"

  Private _request As Boolean = False
  Private _clockVisible As Boolean = False
  Private _clockOnAir As Boolean = False
  Private _overtimeClockOnAir As Boolean = False

  Private WithEvents _addedTimeTimer As New Timer

  Public Property ClockVisible As Boolean
    Get
      Return _clockVisible
    End Get
    Set(value As Boolean)
      If value Then
        _showRedCards = (MsgBox("Show red cards?", Buttons:=MsgBoxStyle.YesNo) = MsgBoxResult.Yes)
      End If
      _clockVisible = value
      UpdateClockVisibility()
    End Set
  End Property

  Private _overtimeClockVisible As Boolean = False
  Private Property OverTimeClockVisible As Boolean
    Get
      Return _overtimeClockVisible
    End Get
    Set(value As Boolean)
      _overtimeClockVisible = value
      UpdateOvertimeClockVisibility()
    End Set
  End Property

  Public Property ClockOnAir As Boolean
    Get
      Return _clockOnAir
    End Get
    Set(value As Boolean)
      _clockOnAir = value
    End Set
  End Property


  Private _updating As Boolean = False

  Public Sub UpdateClockVisibility()
    If _updating Then Exit Sub
    _updating = True
    Try
      If _match Is Nothing Then
        _clockOnAir = False
        Me.ClockVisible = False
        _updating = False
        Exit Sub
      End If

      If _match.MatchPeriods.ActivePeriod Is Nothing Then
        _request = False
      ElseIf _match.MatchPeriods.ActivePeriod.Activa Then
        _request = True
      Else
        _request = False
      End If


      If _clockVisible <> _clockOnAir Or _request <> _clockOnAir Then
        'we must do something
        If _clockOnAir = True And (_clockVisible = False Or _request = False) Then
          'we must hide it
          Me.HideIdentClock()
        ElseIf _clockOnAir = False And _request = True And _clockVisible = True Then
          'we must show it
          Me.ShowIdentClock()
        End If
      End If

    Catch ex As Exception

    End Try
    _updating = False
  End Sub

  Public Sub UpdateOvertimeClockVisibility()
    If _updating Then Exit Sub
    _updating = True
    Try
      If _match Is Nothing Then
        _updating = False
        Exit Sub
      End If

      If _match.MatchPeriods.ActivePeriod Is Nothing Then
        _request = False
      ElseIf _match.MatchPeriods.ActivePeriod.Activa Then
        _request = _match.MatchPeriods.ActivePeriod.IsPeriodDone
      Else
        _request = False
      End If

      If _overtimeClockVisible <> _overtimeClockOnAir Or _request <> _overtimeClockOnAir Then
        'we must do something
        If _overtimeClockOnAir = True And (_overtimeClockVisible = False Or _request = False) Then
          'we must hide it
          Me.HideovertimeClock()
        ElseIf _overtimeclockOnAir = False And _request = True And _overtimeclockVisible = True Then
          'we must show it
          Me.ShowovertimeClock()
        End If
      End If

    Catch ex As Exception

    End Try
    _updating = False
  End Sub

#End Region

#Region "Scene functions"
  Public Sub ShowIdentClock()
    Try
      _clockOnAir = True
      UpdateAndSendScene(True)
      '_vizControl.DirectorStart("DIR_MAIN", Me.Scene.VizLayer)
      Me.Scene.StartSceneDirectors(_vizControl, Scene.TypeOfDirectors.InDirectors)
      RaiseEvent Updated()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Public Sub HideIdentClock()
    Try
      _clockOnAir = False
      '_vizControl.DirectorContinue("DIR_MAIN", Me.Scene.VizLayer)  
      Me.Scene.StartSceneDirectors(_vizControl, Scene.TypeOfDirectors.OutDirectors)
      RaiseEvent Updated()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Public Sub ShowOvertimeClock()
    Try
      If _clockOnAir = False Then Exit Sub
      _overtimeClockOnAir = True
      UpdateAndSendScene(False)
      '_vizControl.DirectorStart("DIR_MAIN", Me.Scene.VizLayer)
      Me.Scene.StartSceneDirectors(_vizControl, Scene.TypeOfDirectors.ChangeInDirectors)
      RaiseEvent Updated()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Public Sub HideOvertimeClock()
    Try
      If _clockOnAir = False Then Exit Sub
      _overtimeClockOnAir = False
      '_vizControl.DirectorContinue("DIR_MAIN", Me.Scene.VizLayer)  
      Me.Scene.StartSceneDirectors(_vizControl, Scene.TypeOfDirectors.ChangeOutDirectors)
      RaiseEvent Updated()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private _clockIsRunning() As Boolean = {False, False, False, False, False, False, False}

  Private Sub UpdateRunningClock(forceSend As Boolean)
    Try
      If _match Is Nothing Then Exit Sub
      If _match.MatchPeriods.ActivePeriod Is Nothing Then Exit Sub

      Dim clockIndex As Integer = 0
      Dim overtimeClockIndex As Integer = 1

      If _match.MatchPeriods.ActivePeriod.Activa And Not _match.MatchPeriods.ActivePeriod.IsPeriodDone Then
        If _clockIsRunning(clockIndex) = False Or forceSend Then
          _vizControl.ClockSet(clockIndex, _match.MatchPeriods.ActivePeriod.PlayingTime + _match.MatchPeriods.ActivePeriod.StartOffset)
          _vizControl.ClockStart(clockIndex)
        End If
      Else
        _vizControl.ClockStop(clockIndex)
      End If

      _vizControl.ClockSet(overtimeClockIndex, _match.MatchPeriods.ActivePeriod.PlayingTime - _match.MatchPeriods.ActivePeriod.TotalTime)
      If _match.MatchPeriods.ActivePeriod.IsPeriodDone Then
        _vizControl.ClockSet(clockIndex, _match.MatchPeriods.ActivePeriod.TotalTime + _match.MatchPeriods.ActivePeriod.StartOffset)
        _vizControl.ClockStop(clockIndex)
        _vizControl.ClockStart(overtimeClockIndex)
        If _clockIsRunning(overtimeClockIndex) = False Or forceSend Then
          _vizControl.ClockStart(overtimeClockIndex)
        End If
      Else
        _vizControl.ClockStop(overtimeClockIndex)
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub UpdateScene(forceSend As Boolean)
    Try
      Dim myScene As Scene = GetClockBaseScene()

      With myScene
        'Directors
        .SceneDirectorsIn.Add("DIR_MAIN", 0, DirectorAction.Start)

        .SceneDirectorsIn.Add("Added_Time_Text", 0, DirectorAction.Rewind)
        .SceneDirectorsIn.Add("Added_Time_Clock", 0, DirectorAction.Rewind)

        .SceneDirectorsIn.Add("Added_time", 0, DirectorAction.Rewind)
        .SceneDirectorsIn.Add("Clock_Added_Time", 0, DirectorAction.Rewind)

        '.SceneDirectorsIn.Add("Team_Left_Cards", 0, DirectorAction.Rewind)
        '.SceneDirectorsIn.Add("Team_Right_Cards", 0, DirectorAction.Rewind)

        .SceneDirectorsIn.Add("sponsor_in_out", 0, DirectorAction.Rewind)

        .SceneDirectorsIn.Add("anim_Clock_Substitute", 0, DirectorAction.Rewind)
        .SceneDirectorsIn.Add("anim_Clock_Player_Card", 0, DirectorAction.Rewind)
        .SceneDirectorsIn.Add("anim_Clock_Match_Statistics", 0, DirectorAction.Rewind)
        .SceneDirectorsIn.Add("anim_Clock_Generic_Straps", 0, DirectorAction.Rewind)
        .SceneDirectorsIn.Add("anim_Clock_Straps_with_Icon", 0, DirectorAction.Rewind)
        .SceneDirectorsIn.Add("anim_Clock_Penalties", 0, DirectorAction.Rewind)
        .SceneDirectorsIn.Add("anim_OtherScores", 0, DirectorAction.Rewind)

        .SceneDirectorsChangeIn.Add("Added_Time_Text", 0, DirectorAction.Start)
        .SceneDirectorsChangeIn.Add("Added_Time_Clock", 0, DirectorAction.Start)
        .SceneDirectorsChangeIn.Add("Added_time", 0, DirectorAction.Start)
        .SceneDirectorsChangeIn.Add("Clock_Added_Time", 0, DirectorAction.Start)

        .SceneDirectorsChangeOut.Add("Added_Time_Text", 0, DirectorAction.ContinueReverse)
        .SceneDirectorsChangeOut.Add("Added_Time_Clock", 0, DirectorAction.ContinueReverse)
        .SceneDirectorsChangeOut.Add("Added_time", 0, DirectorAction.ContinueReverse)
        .SceneDirectorsChangeOut.Add("Clock_Added_Time", 0, DirectorAction.ContinueReverse)


        .SceneDirectorsOut.Add("DIR_MAIN", 0, DirectorAction.ContinueNormal)

        'Control objects
        If Not _match Is Nothing Then
          .SceneParameters.Add("Clock_Home_Team_Name", _match.HomeTeam.Name)
          .SceneParameters.Add("Clock_Away_Team_Name", _match.AwayTeam.Name)

          .SceneParameters.Add("Clock_Home_Team_Score", _match.home_goals)
          .SceneParameters.Add("Clock_Away_Team_Score", _match.away_goals)

          .SceneParameters.Add("Clock_Home_Team_TShirt_Logo", GraphicVersions.Instance.SelectedGraphicVersion.PathTShirts & _match.HomeTeam.BadgeName, paramType.Image)
          .SceneParameters.Add("Clock_Away_Team_TShirt_Logo", GraphicVersions.Instance.SelectedGraphicVersion.PathTShirts & _match.AwayTeam.BadgeName, paramType.Image)

          .SceneParameters.Add("Clock_Home_Team_Logo", GraphicVersions.Instance.SelectedGraphicVersion.PathColors & _match.HomeTeam.BadgeName, paramType.Image)
          .SceneParameters.Add("Clock_Away_Team_Logo", GraphicVersions.Instance.SelectedGraphicVersion.PathColors & _match.AwayTeam.BadgeName, paramType.Image)

          Dim sTime As String = ""
          If _match.MatchPeriods.ActivePeriod Is Nothing Then
            sTime = ""
            .SceneParameters.Add("Clock_Clock_Added_Time_Text", "")
            .SceneParameters.Add("Clock_Added_Time_Text", "")
          Else
            sTime = EnglishToArabicTranslator.Instance.ToArabic(_match.MatchPeriods.ActivePeriod.Nom)
            If _match.MatchPeriods.ActivePeriod.ExtraTime = 0 Then
              .SceneParameters.Add("Clock_Clock_Added_Time_Text", "")
              .SceneParameters.Add("Clock_Added_Time_Text", "")
            Else
              ' .SceneParameters.Add("Clock_Clock_Added_Time_Text", "+" & _match.MatchPeriods.ActivePeriod.ExtraTime)
              .SceneParameters.Add("Clock_Added_Time_Text", "+" & _match.MatchPeriods.ActivePeriod.ExtraTime)
            End If
          End If

          .SceneParameters.Add("Clock_Half_Indicator_Text", sTime)

          'clock control
          UpdateRunningClock(forceSend)
          'red cards
          UpdateRedCards()
        End If

      End With
      Me.Scene = myScene
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Public Sub UpdateClock()

  End Sub

  Private Sub UpdateAndSendScene(forceSend As Boolean)
    UpdateScene(forceSend)
    Me.Scene.SendSceneToEngine(_vizControl)
  End Sub

  Private Sub _match_ScoreChanged() Handles _match.ScoreChanged
    UpdateAndSendScene(False)
  End Sub

  Private Sub _match_ActivePeriodStateChanged() Handles _match.ActivePeriodStateChanged
    Try
      If _match.MatchPeriods.ActivePeriod.Activa Then
        Me.ClockVisible = True
        UpdateAndSendScene(True)
      End If
      Me.UpdateClockVisibility()

    Catch ex As Exception

    End Try
  End Sub

#Region "red cards"
  Private _shownHomeRedCards As Integer = 0
  Private _shownAwayRedCards As Integer = 0



  Public Sub UpdateRedCards()
    Try
      If _showRedCards Then

        Dim RedTime As Double = 1.5
        If _match.HomeTeam.MatchStats.RedCards.Value = 0 Then
          RedTime = 0.0
        ElseIf _match.HomeTeam.MatchStats.RedCards.Value = 1 Then
          RedTime = 0.5
        ElseIf _match.HomeTeam.MatchStats.RedCards.Value = 2 Then
          RedTime = 1.0
        Else
          RedTime = 1.5
        End If

        _vizControl.DirectorGoTo("Team_Right_Cards", 40 * RedTime, eRendererLayers.FrontLayer)


        If _match.AwayTeam.MatchStats.RedCards.Value = 0 Then
          RedTime = 0.0
        ElseIf _match.AwayTeam.MatchStats.RedCards.Value = 1 Then
          RedTime = 0.5
        ElseIf _match.AwayTeam.MatchStats.RedCards.Value = 2 Then
          RedTime = 1.0
        Else
          RedTime = 1.5
        End If
        _vizControl.DirectorGoTo("Team_Left_Cards", 40 * RedTime, eRendererLayers.FrontLayer)

      Else
        _vizControl.DirectorGoTo("Team_Right_Cards", 0, eRendererLayers.FrontLayer)
        _vizControl.DirectorGoTo("Team_Left_Cards", 0, eRendererLayers.FrontLayer)

      End If


    Catch ex As Exception

    End Try
  End Sub
#End Region

  Private Sub _addedTimeTimer_Tick(sender As Object, e As EventArgs) Handles _addedTimeTimer.Tick
    Try
      If _match Is Nothing Then Exit Sub
      If _match.MatchPeriods.ActivePeriod Is Nothing Then Exit Sub
      If _match.MatchPeriods.ActivePeriod.IsPeriodDone <> Me.OverTimeClockVisible Then
        Me.OverTimeClockVisible = _match.MatchPeriods.ActivePeriod.IsPeriodDone
        If _match.MatchPeriods.ActivePeriod.Activa Then
          UpdateAndSendScene(False)
        End If
      End If
    Catch ex As Exception

    End Try
  End Sub

  Private Sub Team_StatValueChanged(sender As StatSubject, stat As Stat) Handles _homeTeam.StatValueChanged, _awayTeam.StatValueChanged
    UpdateRedCards()
  End Sub

#End Region
End Class

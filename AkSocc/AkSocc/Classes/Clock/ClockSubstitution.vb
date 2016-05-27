﻿Imports MatchInfo
Imports VizCommands

Public Class ClockSubstitution
  Private WithEvents _clockControl As ClockControl = ClockControl.Instance

  Public Substitution As Substitution

  Public Scene As Scene

  Public SceneAnimation As String = "anim_Clock_Substitute"


  Public Sub ShowSubstitution(Substitution As Substitution)
    Try
      Me.Scene = New Scene
      With Me.Scene
        .SceneName = _clockControl.Scene.SceneName
        .VizLayer = _clockControl.Scene.VizLayer

        .SceneParameters.Add("Clock_Substitute_Subject_01_Logo", Substitution.Team.BadgeName)
        .SceneParameters.Add("Clock_Substitute_Subject_01_Name", Substitution.PlayerOut.PlayerName)
        .SceneParameters.Add("Clock_Substitute_Subject_01_Number", Substitution.PlayerOut.SquadNo)
        .SceneParameters.Add("Clock_Substitute_Subject_02_Name", Substitution.PlayerIn.PlayerName)
        .SceneParameters.Add("Clock_Substitute_Subject_02_Number", Substitution.PlayerIn.SquadNo)
      End With

      Me.Scene.SendSceneToEngine(_clockControl.VizControl)
      _clockControl.VizControl.DirectorStart("anim_Clock_Substitute", Me.Scene.VizLayer)

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Public Sub HideSubstitution()
    _clockControl.VizControl.DirectorContinue("anim_Clock_Substitute", Me.Scene.VizLayer)
  End Sub
End Class
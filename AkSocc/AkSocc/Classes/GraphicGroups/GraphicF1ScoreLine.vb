﻿Imports AkSocc
Imports VizCommands

Public Class GraphicGroupF1ScoreLine
  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match)
    MyBase.New(_match)

    MyBase.Name = "GraphicF1ScoreLine"
    MyBase.ID = 1
  End Sub

  Class Step0
    Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly FirstHalf As Step0 = New Step0("First half")
    Public Shared ReadOnly HalfTime As Step0 = New Step0("Half time")
    Public Shared ReadOnly SecondHalf As Step0 = New Step0("Second half")
    Public Shared ReadOnly FullTime As Step0 = New Step0("Full time")

    Public Shared ReadOnly ETFirstHalf As Step0 = New Step0("First half (extra time)")
    Public Shared ReadOnly ETHalfTime As Step0 = New Step0("Half time (extra time)")
    Public Shared ReadOnly ETSecondHalf As Step0 = New Step0("Second half (extra time)")
    Public Shared ReadOnly ETFullTime As Step0 = New Step0("Full time (extra time)")


    Public Shared ReadOnly WithLastScorer As Step0 = New Step0("With last scorer")
    Public Shared ReadOnly WithIDentDescription As Step0 = New Step0("With ident description")
    Public Shared ReadOnly WithhAllScorers As Step0 = New Step0("With all scorers")

    Public Sub New(key As String)
      MyBase.Key = key
    End Sub
  End Class

  Class StepMatch
    Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly SponsorLogo As GraphicStep.GraphicStepDefinition = New GraphicStep.GraphicStepDefinition("YES - Sponsor logo")
    Public Shared ReadOnly NoLogo As GraphicStep.GraphicStepDefinition = New GraphicStep.GraphicStepDefinition("NO - No logo")

  End Class


  Public Overrides Function PrepareNextGraphicStep(Optional graphicStep As GraphicStep = Nothing) As GraphicStep
    Dim gsList As New GraphicSteps
    Dim gs As New GraphicStep(graphicStep, Me.Name)
    If Not graphicStep Is Nothing Then
      gs = graphicStep
    End If


    Try
      gs.GraphicSteps.Clear()

      If graphicStep Is Nothing Then
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.FirstHalf))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.HalfTime))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.SecondHalf))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.FullTime))
        gs.GraphicSteps.Add(New GraphicStep(gs, "Extra time", False, False, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.ETFirstHalf))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.ETHalfTime))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.ETSecondHalf))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.ETFullTime))
        gs.GraphicSteps.Add(New GraphicStep(gs, "Oher stats", False, False, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.WithLastScorer))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.WithIDentDescription))
        gs.GraphicSteps.Add(New GraphicStep(gs, Step0.WithhAllScorers))
      Else
        Select Case graphicStep.Depth
          Case 0
            gs.GraphicSteps.Add(New GraphicStep(gs, StepMatch.SponsorLogo, True, True))
            gs.GraphicSteps.Add(New GraphicStep(gs, StepMatch.NoLogo, True, True))
          Case 1
            'graphic is ready

        End Select
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return gs
  End Function

  Public Overrides Function PrepareScene(graphicStep As GraphicStep) As Scene
    Me.Scene = New Scene
    Dim gs As GraphicStep = graphicStep.RootGraphicStep
    Try
      Scene.VizLayer = SceneLayer.Middle
      Scene.SceneName = "gfx_Scoreline"
      Scene.SceneDirector = "DIR_MAIN"
      Select Case gs.ChildGraphicStep.Name
        Case Step0.FirstHalf
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "First half", gs.ChildGraphicStep.ChildGraphicStep.Name = StepMatch.SponsorLogo)
        Case Step0.SecondHalf
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "Second half", gs.ChildGraphicStep.ChildGraphicStep.Name = StepMatch.SponsorLogo)
        Case Step0.HalfTime
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "Half time", gs.ChildGraphicStep.ChildGraphicStep.Name = StepMatch.SponsorLogo)
        Case Step0.FullTime
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "Full time", gs.ChildGraphicStep.ChildGraphicStep.Name = StepMatch.SponsorLogo)
        Case Step0.ETFirstHalf
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "First half (extra time)", gs.ChildGraphicStep.ChildGraphicStep.Name = StepMatch.SponsorLogo)
        Case Step0.ETSecondHalf
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "Second half (extra time)", gs.ChildGraphicStep.ChildGraphicStep.Name = StepMatch.SponsorLogo)
        Case Step0.ETHalfTime
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "Half time (extra time)", gs.ChildGraphicStep.ChildGraphicStep.Name = StepMatch.SponsorLogo)
        Case Step0.ETFullTime
          PrepareResultScene(Scene, Match.home_goals, Match.away_goals, "Full time (extra time)", gs.ChildGraphicStep.ChildGraphicStep.Name = StepMatch.SponsorLogo)
      End Select
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Me.Scene
  End Function

  Private Sub PrepareResultScene(ByRef scene As Scene, home_Result As String, away_Result As String, period_Name As String, show_Logo As Boolean)
    Try
      scene.SceneDirectors.Add("DIR_MAIN", 0, DirectorAction.Start)
      scene.SceneDirectors.Add("sponsor_in_out", 0, DirectorAction.Rewind)

      scene.SceneParameters.Add(New SceneParameter("Scoreline_Home_Team_Name", Match.HomeTeam.ArabicCaption1Name))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Away_Team_Name", Match.AwayTeam.ArabicCaption1Name))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Home_Team_Logo", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & Match.HomeTeam.BadgeName, paramType.Image))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Away_Team_Logo", GraphicVersions.Instance.SelectedGraphicVersion.Path2DLogos & Match.AwayTeam.BadgeName, paramType.Image))

      scene.SceneParameters.Add(New SceneParameter("Scoreline_Home_Team_Score", home_Result))
      scene.SceneParameters.Add(New SceneParameter("Scoreline_Away_Team_Score", away_Result))

      scene.SceneParameters.Add(New SceneParameter("Scoreline_period_Name", period_Name))

      scene.SceneParameters.Add(New SceneParameter("Scoreline_Select_Type", "1"))

      If show_Logo Then
        scene.SceneParameters.Add(New SceneParameter("Scoreline_show_Logo", "1"))
        scene.SceneDirectors.Add("sponsor_in_out", 100, DirectorAction.Start)
      Else
        scene.SceneParameters.Add(New SceneParameter("Scoreline_show_Logo", "0"))
      End If

    Catch ex As Exception

    End Try
  End Sub
End Class
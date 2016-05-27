﻿Imports System.Data.OleDb

Public Class Periods
  Inherits CollectionBase

  Public Sub New()
    Me.List.Add(New Period(0, 1, False) With {.TotalTime = 45 * 60, .Nom = "1st half", .StartOffset = 0})
    Me.List.Add(New Period(0, 2, False) With {.TotalTime = 45 * 60, .Nom = "2nd half", .StartOffset = 45 * 60})
    Me.List.Add(New Period(0, 3, False) With {.TotalTime = 20 * 60, .Nom = "1st overtime", .StartOffset = 90 * 60})
    Me.List.Add(New Period(0, 4, False) With {.TotalTime = 20 * 60, .Nom = "2nd overtime", .StartOffset = 110 * 60})
  End Sub

  Public Function Add(period As Period) As Integer
    Try
      If Not period Is Nothing Then
        Dim found As Boolean
        For index As Integer = 0 To Me.List.Count - 1
          If Me.List(index).PeriodID = period.periodID Then
            Me.List(index) = period
            found = True
            Exit For
          End If
        Next
        If Not found Then
          Me.List.Add(period)
        End If
      End If
    Catch ex As Exception
    End Try
    Return Me.List.Count
  End Function

  Private _activePeriod As New Period
  Public Property ActivePeriod As Period
    Get
      Return _activePeriod
    End Get
    Set(value As Period)
      _activePeriod = value
      For Each p As Period In Me.InnerList

      Next

    End Set
  End Property

#Region "Period properties"
  Public Property Part As Integer
    Get
      Return ActivePeriod.Part
    End Get
    Set(value As Integer)
      ActivePeriod.Part = value
    End Set
  End Property

  Public Property Active As Boolean
    Get
      Return ActivePeriod.Activa
    End Get
    Set(value As Boolean)
      ActivePeriod.Activa = value
    End Set
  End Property

  Public Property Afegit As Integer
    Get
      Return ActivePeriod.Afegit
    End Get
    Set(value As Integer)
      ActivePeriod.Afegit = value
    End Set
  End Property

  Public Property HoraInici As Date
    Get
      Return ActivePeriod.HoraInici
    End Get
    Set(value As Date)
      ActivePeriod.HoraInici = value
    End Set
  End Property

  Public Property IsProrroga As Boolean
    Get
      Return ActivePeriod.IsProrroga
    End Get
    Set(value As Boolean)
      ActivePeriod.Part = value
    End Set
  End Property

  Public Property Nom As String
    Get
      Return ActivePeriod.Nom
    End Get
    Set(value As String)
      ActivePeriod.Nom = value
    End Set
  End Property

  Public Property NomCurt As String
    Get
      Return ActivePeriod.NomCurt
    End Get
    Set(value As String)
      ActivePeriod.NomCurt = value
    End Set
  End Property

  Public Property Offset As Integer
    Get
      Return ActivePeriod.ManualOffset
    End Get
    Set(value As Integer)
      ActivePeriod.ManualOffset = value
    End Set
  End Property

  Public Property TempsTotal As Integer
    Get
      Return ActivePeriod.TotalTime
    End Get
    Set(value As Integer)
      ActivePeriod.TotalTime = value
    End Set
  End Property

  Public ReadOnly Property TempsJoc As Integer
    Get
      If Me.ActivePeriod Is Nothing Then
        Return Nothing
      Else
        ActivePeriod.UpdateTempsJoc(eTipusUpdatePeriodes.Clock)

        Return ActivePeriod.PlayingTime
      End If
    End Get
  End Property

  Public ReadOnly Property TempsJocString As String
    Get
      Dim time As Integer = Me.TempsJoc
      Dim sec As String = "00" & Me.TempsJoc Mod 60
      Dim min As String = Me.TempsJoc \ 60
      Return min & ":" & Right(sec, 2)
    End Get
  End Property

  Public ReadOnly Property TempsJocWithOffset As Integer
    Get
      If Me.ActivePeriod Is Nothing Then
        Return Nothing
      Else
        ActivePeriod.UpdateTempsJoc(eTipusUpdatePeriodes.Clock)

        Return ActivePeriod.PlayingTime + ActivePeriod.StartOffset
      End If
    End Get
  End Property

  Public ReadOnly Property TempsJocWithOffsetString As String
    Get
      Dim time As Integer = Me.TempsJocWithOffset
      Dim sec As String = "00" & time Mod 60
      Dim min As String = time \ 60
      Return min & ":" & Right(sec, 2)
    End Get
  End Property
#End Region

#Region "Period functions"
  Public Function StartPeriod(part As Integer, Optional startTime As Integer = 0) As Period
    Dim res As Period = Nothing
    Try
      res = Me.GetPeriodByPart(part)
      If Not res Is Nothing Then
        res.HoraInici = Now
        res.ManualOffset = startTime
        res.Activa = True
      End If
      Me.ActivePeriod = res
    Catch ex As Exception
    End Try
    Return Me.ActivePeriod
  End Function

  Public Function StartPeriod(period As Period, Optional startTime As Integer = 0) As Period
    Dim res As Period = period
    Try
      If Not Me.ActivePeriod Is Nothing Then
        Me.ActivePeriod.Activa = False
        Me.ActivePeriod.IsSelected = False
      End If
      If Not res Is Nothing Then
        res.HoraInici = Now
        res.ManualOffset = startTime
        res.Activa = True
        res.IsSelected = True
      End If
      Me.ActivePeriod = res
    Catch ex As Exception
    End Try
    Return Me.ActivePeriod
  End Function

  Public Function EndPeriod(part As Integer, Optional startTime As Integer = 0) As Period
    Dim res As Period = Nothing
    Try
      If Not Me.ActivePeriod Is Nothing Then
        Me.ActivePeriod.Activa = False
        Me.ActivePeriod.IsSelected = False
      End If
      res = Me.GetPeriodByPart(part)
      If Not res Is Nothing Then
        res.Activa = False
        res.IsSelected = True
      End If
      Me.ActivePeriod = res
    Catch ex As Exception
    End Try
    Return Me.ActivePeriod
  End Function

  Public Function EndPeriod(period As Period, Optional startTime As Integer = 0) As Period
    Dim res As Period = period
    Try
      If Not Me.ActivePeriod Is Nothing Then
        Me.ActivePeriod.Activa = False
        Me.ActivePeriod.IsSelected = False
      End If
      If Not res Is Nothing Then
        res.UpdateTempsJocManual(period.TotalTime)
        res.Activa = False
        res.IsSelected = False
      End If
      Me.ActivePeriod = res
      res.IsSelected = True
    Catch ex As Exception
    End Try
    Return Me.ActivePeriod
  End Function
#End Region



  Default Public Property Item(Index As Integer) As Period
    Get
      Return DirectCast(List(Index), Period)
    End Get
    Set
      List(Index) = Value
    End Set
  End Property

  Public Function GetPeriod(ID As Integer) As Period
    Dim output As Period = Nothing
    Try
      For Each SearchPeriod As Period In List
        If SearchPeriod.periodID = ID Then
          output = SearchPeriod
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function GetPeriodByTime(time As Integer) As Period
    Dim output As Period = Nothing
    Try
      For Each SearchPeriod As Period In List
        If SearchPeriod.StartOffset <= time And SearchPeriod.StartOffset + SearchPeriod.TotalTime >= time Then
          output = SearchPeriod
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function GetPeriodByPart(part As Integer) As Period
    Dim output As Period = Nothing
    Try
      For Each SearchPeriod As Period In List
        If SearchPeriod.Part = part Then
          output = SearchPeriod
          Exit For
        End If
      Next
      If output Is Nothing Then
        output = Me.List(part)
      End If
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function Contains(ID As Integer) As Boolean
    Dim output As Boolean = False
    Try
      For Each SearchPeriod As Period In List
        If SearchPeriod.periodID = ID Then
          output = True
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function SetPlayingTime(newTime As Integer) As Period
    Dim newPeriod As Period = Nothing
    Try
      newPeriod = Me.GetPeriodByTime(newTime)
      If Not newPeriod Is Nothing Then
        If Not ActivePeriod Is Nothing Then
          ActivePeriod.Activa = False
          ActivePeriod.IsSelected = False
        End If
        ActivePeriod = newPeriod
        ActivePeriod.ManualOffset = newTime - ActivePeriod.StartOffset
        ActivePeriod.Activa = True
        ActivePeriod.IsSelected = True
      End If
    Catch ex As Exception
      Throw ex
    End Try
    Return ActivePeriod
  End Function
End Class
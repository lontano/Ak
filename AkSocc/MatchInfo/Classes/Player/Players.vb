﻿

Imports System.Data.OleDb

<Serializable()> Public Class Players
  Inherits CollectionBase

  Public Sub New()
  End Sub

  Public Function Add(player As Player) As Integer
    Try
      If Not player Is Nothing Then
        Dim found As Boolean
        For index As Integer = 0 To Me.List.Count - 1
          If Me.List(index).PlayerID = player.PlayerID Then
            Me.List(index) = player
            found = True
            Exit For
          End If
        Next
        If Not found Then
          Me.List.Add(player)
        End If
      End If
    Catch ex As Exception
    End Try
    Return Me.List.Count
  End Function

  Default Public Property Item(Index As Integer) As Player
    Get
      Return DirectCast(List(Index), Player)
    End Get
    Set
      List(Index) = Value
    End Set
  End Property

  Public Function GetPlayer(ID As Integer) As Player
    Dim output As Player = Nothing
    Try
      For Each SearchPlayer As Player In List
        If SearchPlayer.PlayerID = ID Then
          output = SearchPlayer
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function GetPlayerByDorsal(ID As Integer) As Player
    Dim output As Player = Nothing
    Try
      For Each SearchPlayer As Player In List
        If SearchPlayer.SquadNo = ID Then
          output = SearchPlayer
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function GetPlayerByPosition(position As Integer) As Player
    Dim output As Player = Nothing
    Try
      For Each SearchPlayer As Player In List
        If SearchPlayer.Formation_Pos = position Then
          output = SearchPlayer
          Exit For
        End If
      Next
      If output Is Nothing Then
        output = Me.List(position)
      End If
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function Contains(ID As Integer) As Boolean
    Dim output As Boolean = False
    Try
      For Each SearchPlayer As Player In List
        If SearchPlayer.PlayerID = ID Then
          output = True
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function
End Class

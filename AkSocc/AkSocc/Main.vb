﻿Imports System.IO

Module Main
  Public _errorHandler As ErrorHandling

  Private _frmMain As frmMain

  Public Property ConfigNum As Integer = 0

  Public ReadOnly Property LocalConnectionString As String
    Get
      Dim path As String = System.IO.Path.Combine("C:\BeInReal\Alamiya\AEL Saudi Football.mdb")
      Return "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & path
    End Get
  End Property

  Public ReadOnly Property OptaConnectionString As String
    Get
      Dim path As String = System.IO.Path.Combine("C:\BeInReal\Alamiya\AEL Saudi Football.mdb")
      Return "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & path
    End Get
  End Property

  Public Sub Main()
    'Habilitem els estils visuals d'XP
    Try
      Application.EnableVisualStyles()
      ReadCommandLine()

    Catch ex As Exception
      MsgBox(ex.ToString)
      WriteToErrorLog(ex)
    End Try

    'ShowOptions(Nothing)
    _frmMain = New frmMain

    Application.Run(_frmMain)
  End Sub


  Private Sub ReadCommandLine()
    Dim sParam As String
    ConfigNum = 0
    For Each sParam In My.Application.CommandLineArgs
      If sParam.ToLower.StartsWith("/config=") Then
        ConfigNum = CInt(sParam.Remove(0, "/config=".Length))
      ElseIf sParam.ToLower.StartsWith("-config=") Then
        ConfigNum = CInt(sParam.Remove(0, "-config=".Length))
      End If
    Next sParam
  End Sub

#Region "Error logging"
  Public Sub WriteToErrorLog(logEx As Exception)
    Try
      WriteToErrorLog(logEx.ToString, "", My.Application.Info.AssemblyName & " " & My.Application.Info.Version.ToString)
    Catch ex As Exception

    End Try
  End Sub
  Public Sub WriteToErrorLog(ByVal msg As String,
       ByVal stkTrace As String, ByVal title As String)

    Try
      Dim path As String = "C:\"
      'check and make the directory if necessary; this is set to look in 
      'the Application folder, you may wish to place the error log in 
      'another location depending upon the user's role and write access to 
      'different areas of the file system
      If Not System.IO.Directory.Exists(path &
    "\Errors\") Then
        System.IO.Directory.CreateDirectory(path &
        "\Errors\")
      End If

      'check the file
      Dim fs As FileStream = New FileStream(path &
    "\Errors\errlog.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
      Dim s As StreamWriter = New StreamWriter(fs)
      s.Close()
      fs.Close()

      'log it
      Dim fs1 As FileStream = New FileStream(path &
    "\Errors\errlog.txt", FileMode.Append, FileAccess.Write)
      Dim s1 As StreamWriter = New StreamWriter(fs1)
      s1.Write("Title: " & title & vbCrLf)
      s1.Write("Message: " & msg & vbCrLf)
      s1.Write("StackTrace: " & stkTrace & vbCrLf)
      s1.Write("Date/Time: " & DateTime.Now.ToString() & vbCrLf)
      s1.Write("================================================" & vbCrLf)
      s1.Close()
      fs1.Close()

    Catch ex As Exception
      MsgBox("Error: could not log error!" & vbCrLf & ex.ToString)
    End Try

  End Sub

#End Region


  Public Sub ShowOptions(frm As Form)
    Try
      Dim dlg As New DialogOptions()
      If dlg.ShowDialog(frm) = DialogResult.OK Then

      End If
      MatchInfo.Config.Instance.LocalConnectionString = LocalConnectionString
      MatchInfo.Config.Instance.OptaConnectionString = OptaConnectionString
    Catch ex As Exception

    End Try
  End Sub
End Module

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerViewer
  Inherits System.Windows.Forms.UserControl

  'UserControl overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.TableLayoutPanelPlayer = New System.Windows.Forms.TableLayoutPanel()
    Me.LabelCards = New MetroFramework.Controls.MetroLabel()
    Me.LabelName = New MetroFramework.Controls.MetroLabel()
    Me.LabelDorsal = New MetroFramework.Controls.MetroLabel()
    Me.PictureBoxInfo = New System.Windows.Forms.PictureBox()
    Me.TableLayoutPanelPlayer.SuspendLayout()
    CType(Me.PictureBoxInfo, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'TableLayoutPanelPlayer
    '
    Me.TableLayoutPanelPlayer.ColumnCount = 5
    Me.TableLayoutPanelPlayer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanelPlayer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelPlayer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanelPlayer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanelPlayer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanelPlayer.Controls.Add(Me.LabelCards, 2, 0)
    Me.TableLayoutPanelPlayer.Controls.Add(Me.LabelName, 1, 0)
    Me.TableLayoutPanelPlayer.Controls.Add(Me.LabelDorsal, 0, 0)
    Me.TableLayoutPanelPlayer.Controls.Add(Me.PictureBoxInfo, 3, 0)
    Me.TableLayoutPanelPlayer.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelPlayer.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelPlayer.Name = "TableLayoutPanelPlayer"
    Me.TableLayoutPanelPlayer.RowCount = 1
    Me.TableLayoutPanelPlayer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelPlayer.Size = New System.Drawing.Size(762, 32)
    Me.TableLayoutPanelPlayer.TabIndex = 0
    '
    'LabelCards
    '
    Me.LabelCards.BackColor = System.Drawing.Color.White
    Me.LabelCards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.LabelCards.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelCards.Location = New System.Drawing.Point(705, 3)
    Me.LabelCards.Margin = New System.Windows.Forms.Padding(3)
    Me.LabelCards.Name = "LabelCards"
    Me.LabelCards.Size = New System.Drawing.Size(14, 26)
    Me.LabelCards.TabIndex = 2
    Me.LabelCards.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'LabelName
    '
    Me.LabelName.BackColor = System.Drawing.Color.White
    Me.LabelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.LabelName.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelName.Location = New System.Drawing.Point(43, 3)
    Me.LabelName.Margin = New System.Windows.Forms.Padding(3)
    Me.LabelName.Name = "LabelName"
    Me.LabelName.Size = New System.Drawing.Size(656, 26)
    Me.LabelName.TabIndex = 1
    Me.LabelName.Text = "PLAYER NAME"
    Me.LabelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'LabelDorsal
    '
    Me.LabelDorsal.BackColor = System.Drawing.Color.White
    Me.LabelDorsal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.LabelDorsal.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelDorsal.Location = New System.Drawing.Point(3, 3)
    Me.LabelDorsal.Margin = New System.Windows.Forms.Padding(3)
    Me.LabelDorsal.Name = "LabelDorsal"
    Me.LabelDorsal.Size = New System.Drawing.Size(34, 26)
    Me.LabelDorsal.TabIndex = 0
    Me.LabelDorsal.Text = "00"
    Me.LabelDorsal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'PictureBoxInfo
    '
    Me.PictureBoxInfo.BackColor = System.Drawing.Color.Maroon
    Me.PictureBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.PictureBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBoxInfo.Location = New System.Drawing.Point(725, 3)
    Me.PictureBoxInfo.Name = "PictureBoxInfo"
    Me.PictureBoxInfo.Size = New System.Drawing.Size(14, 26)
    Me.PictureBoxInfo.TabIndex = 3
    Me.PictureBoxInfo.TabStop = False
    Me.PictureBoxInfo.Visible = False
    '
    'PlayerViewer
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TableLayoutPanelPlayer)
    Me.Name = "PlayerViewer"
    Me.Size = New System.Drawing.Size(762, 32)
    Me.TableLayoutPanelPlayer.ResumeLayout(False)
    CType(Me.PictureBoxInfo, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanelPlayer As TableLayoutPanel
  Friend WithEvents LabelName As MetroFramework.Controls.MetroLabel
  Friend WithEvents LabelCards As MetroFramework.Controls.MetroLabel
  Friend WithEvents LabelDorsal As MetroFramework.Controls.MetroLabel
  Friend WithEvents PictureBoxInfo As PictureBox
End Class
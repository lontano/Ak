﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGoals
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
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
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroTileGraphics = New MetroFramework.Controls.MetroTile()
    Me.TableLayoutPanelData = New System.Windows.Forms.TableLayoutPanel()
    Me.MetroButtonAddAwayTeamSubstitition = New System.Windows.Forms.Button()
    Me.MetroButtonRemoveGoal = New System.Windows.Forms.Button()
    Me.MetroGridGoals = New MetroFramework.Controls.MetroGrid()
    Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnHomeType = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnHomePlayer = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnHomeGoal = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnAwayGoal = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnAwayPlayer = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ColumnAwayType = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.MetroButtonAddHomeTeamSubstitition = New System.Windows.Forms.Button()
    Me.MetroButtonShowSelectedGoal = New System.Windows.Forms.Button()
    Me.MetroTileData = New MetroFramework.Controls.MetroTile()
    Me.TableLayoutPanel2.SuspendLayout()
    Me.TableLayoutPanelData.SuspendLayout()
    CType(Me.MetroGridGoals, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.ColumnCount = 1
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.Controls.Add(Me.MetroTileGraphics, 0, 2)
    Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanelData, 0, 1)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroButtonShowSelectedGoal, 0, 3)
    Me.TableLayoutPanel2.Controls.Add(Me.MetroTileData, 0, 0)
    Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 4
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(844, 459)
    Me.TableLayoutPanel2.TabIndex = 3
    '
    'MetroTileGraphics
    '
    Me.MetroTileGraphics.ActiveControl = Nothing
    Me.MetroTileGraphics.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTileGraphics.Location = New System.Drawing.Point(3, 397)
    Me.MetroTileGraphics.Name = "MetroTileGraphics"
    Me.MetroTileGraphics.Size = New System.Drawing.Size(838, 24)
    Me.MetroTileGraphics.TabIndex = 0
    Me.MetroTileGraphics.Text = "Graphics"
    Me.MetroTileGraphics.UseSelectable = True
    Me.MetroTileGraphics.Visible = False
    '
    'TableLayoutPanelData
    '
    Me.TableLayoutPanelData.ColumnCount = 3
    Me.TableLayoutPanelData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanelData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanelData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanelData.Controls.Add(Me.MetroButtonAddAwayTeamSubstitition, 0, 0)
    Me.TableLayoutPanelData.Controls.Add(Me.MetroButtonRemoveGoal, 1, 0)
    Me.TableLayoutPanelData.Controls.Add(Me.MetroGridGoals, 0, 1)
    Me.TableLayoutPanelData.Controls.Add(Me.MetroButtonAddHomeTeamSubstitition, 2, 0)
    Me.TableLayoutPanelData.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelData.Location = New System.Drawing.Point(3, 33)
    Me.TableLayoutPanelData.Name = "TableLayoutPanelData"
    Me.TableLayoutPanelData.RowCount = 2
    Me.TableLayoutPanelData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanelData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelData.Size = New System.Drawing.Size(838, 358)
    Me.TableLayoutPanelData.TabIndex = 1
    '
    'MetroButtonAddAwayTeamSubstitition
    '
    Me.MetroButtonAddAwayTeamSubstitition.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonAddAwayTeamSubstitition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.MetroButtonAddAwayTeamSubstitition.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.MetroButtonAddAwayTeamSubstitition.Location = New System.Drawing.Point(3, 3)
    Me.MetroButtonAddAwayTeamSubstitition.Name = "MetroButtonAddAwayTeamSubstitition"
    Me.MetroButtonAddAwayTeamSubstitition.Size = New System.Drawing.Size(273, 34)
    Me.MetroButtonAddAwayTeamSubstitition.TabIndex = 3
    Me.MetroButtonAddAwayTeamSubstitition.Text = "Add home team GOAL"
    '
    'MetroButtonRemoveGoal
    '
    Me.MetroButtonRemoveGoal.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonRemoveGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.MetroButtonRemoveGoal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.MetroButtonRemoveGoal.Location = New System.Drawing.Point(282, 3)
    Me.MetroButtonRemoveGoal.Name = "MetroButtonRemoveGoal"
    Me.MetroButtonRemoveGoal.Size = New System.Drawing.Size(273, 34)
    Me.MetroButtonRemoveGoal.TabIndex = 2
    Me.MetroButtonRemoveGoal.Text = "Remove goal"
    '
    'MetroGridGoals
    '
    Me.MetroGridGoals.AllowUserToAddRows = False
    Me.MetroGridGoals.AllowUserToDeleteRows = False
    Me.MetroGridGoals.AllowUserToResizeColumns = False
    Me.MetroGridGoals.AllowUserToResizeRows = False
    Me.MetroGridGoals.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridGoals.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.MetroGridGoals.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    Me.MetroGridGoals.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridGoals.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.MetroGridGoals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.MetroGridGoals.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnID, Me.ColumnHomeType, Me.ColumnHomePlayer, Me.ColumnHomeGoal, Me.ColumnTime, Me.ColumnAwayGoal, Me.ColumnAwayPlayer, Me.ColumnAwayType})
    Me.TableLayoutPanelData.SetColumnSpan(Me.MetroGridGoals, 3)
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.MetroGridGoals.DefaultCellStyle = DataGridViewCellStyle3
    Me.MetroGridGoals.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroGridGoals.EnableHeadersVisualStyles = False
    Me.MetroGridGoals.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.MetroGridGoals.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.MetroGridGoals.Location = New System.Drawing.Point(3, 43)
    Me.MetroGridGoals.Name = "MetroGridGoals"
    Me.MetroGridGoals.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
    DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.MetroGridGoals.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
    Me.MetroGridGoals.RowHeadersVisible = False
    Me.MetroGridGoals.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.MetroGridGoals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.MetroGridGoals.Size = New System.Drawing.Size(832, 312)
    Me.MetroGridGoals.Style = MetroFramework.MetroColorStyle.Orange
    Me.MetroGridGoals.TabIndex = 0
    '
    'ColumnID
    '
    Me.ColumnID.HeaderText = "ColumnID"
    Me.ColumnID.Name = "ColumnID"
    Me.ColumnID.ReadOnly = True
    '
    'ColumnHomeType
    '
    Me.ColumnHomeType.HeaderText = "Type"
    Me.ColumnHomeType.Name = "ColumnHomeType"
    '
    'ColumnHomePlayer
    '
    Me.ColumnHomePlayer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnHomePlayer.HeaderText = "Player"
    Me.ColumnHomePlayer.Name = "ColumnHomePlayer"
    Me.ColumnHomePlayer.ReadOnly = True
    '
    'ColumnHomeGoal
    '
    Me.ColumnHomeGoal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ColumnHomeGoal.HeaderText = "Goal"
    Me.ColumnHomeGoal.Name = "ColumnHomeGoal"
    Me.ColumnHomeGoal.ReadOnly = True
    '
    'ColumnTime
    '
    Me.ColumnTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.ColumnTime.DefaultCellStyle = DataGridViewCellStyle2
    Me.ColumnTime.HeaderText = "Time"
    Me.ColumnTime.Name = "ColumnTime"
    Me.ColumnTime.ReadOnly = True
    '
    'ColumnAwayGoal
    '
    Me.ColumnAwayGoal.HeaderText = "Goal"
    Me.ColumnAwayGoal.Name = "ColumnAwayGoal"
    '
    'ColumnAwayPlayer
    '
    Me.ColumnAwayPlayer.HeaderText = "Player"
    Me.ColumnAwayPlayer.Name = "ColumnAwayPlayer"
    '
    'ColumnAwayType
    '
    Me.ColumnAwayType.HeaderText = "Type"
    Me.ColumnAwayType.Name = "ColumnAwayType"
    '
    'MetroButtonAddHomeTeamSubstitition
    '
    Me.MetroButtonAddHomeTeamSubstitition.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonAddHomeTeamSubstitition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.MetroButtonAddHomeTeamSubstitition.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.MetroButtonAddHomeTeamSubstitition.Location = New System.Drawing.Point(561, 3)
    Me.MetroButtonAddHomeTeamSubstitition.Name = "MetroButtonAddHomeTeamSubstitition"
    Me.MetroButtonAddHomeTeamSubstitition.Size = New System.Drawing.Size(274, 34)
    Me.MetroButtonAddHomeTeamSubstitition.TabIndex = 1
    Me.MetroButtonAddHomeTeamSubstitition.Text = "Add away team GOAL"
    '
    'MetroButtonShowSelectedGoal
    '
    Me.MetroButtonShowSelectedGoal.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroButtonShowSelectedGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.MetroButtonShowSelectedGoal.Location = New System.Drawing.Point(3, 427)
    Me.MetroButtonShowSelectedGoal.Name = "MetroButtonShowSelectedGoal"
    Me.MetroButtonShowSelectedGoal.Size = New System.Drawing.Size(838, 29)
    Me.MetroButtonShowSelectedGoal.TabIndex = 1
    Me.MetroButtonShowSelectedGoal.Text = "Selected goal..."
    Me.MetroButtonShowSelectedGoal.Visible = False
    '
    'MetroTileData
    '
    Me.MetroTileData.ActiveControl = Nothing
    Me.MetroTileData.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MetroTileData.Location = New System.Drawing.Point(3, 3)
    Me.MetroTileData.Name = "MetroTileData"
    Me.MetroTileData.Size = New System.Drawing.Size(838, 24)
    Me.MetroTileData.Style = MetroFramework.MetroColorStyle.Orange
    Me.MetroTileData.TabIndex = 2
    Me.MetroTileData.Text = "Data"
    Me.MetroTileData.UseSelectable = True
    '
    'frmGoals
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.ClientSize = New System.Drawing.Size(844, 459)
    Me.Controls.Add(Me.TableLayoutPanel2)
    Me.Name = "frmGoals"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Match goals"
    Me.TableLayoutPanel2.ResumeLayout(False)
    Me.TableLayoutPanelData.ResumeLayout(False)
    CType(Me.MetroGridGoals, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
  Friend WithEvents MetroTileGraphics As MetroFramework.Controls.MetroTile
  Friend WithEvents TableLayoutPanelData As TableLayoutPanel
  Friend WithEvents MetroButtonAddAwayTeamSubstitition As Button
  Friend WithEvents MetroButtonRemoveGoal As Button
  Friend WithEvents MetroGridGoals As MetroFramework.Controls.MetroGrid
  Friend WithEvents MetroButtonAddHomeTeamSubstitition As Button
  Friend WithEvents MetroButtonShowSelectedGoal As Button
  Friend WithEvents MetroTileData As MetroFramework.Controls.MetroTile
  Friend WithEvents ColumnID As DataGridViewTextBoxColumn
  Friend WithEvents ColumnHomeType As DataGridViewTextBoxColumn
  Friend WithEvents ColumnHomePlayer As DataGridViewTextBoxColumn
  Friend WithEvents ColumnHomeGoal As DataGridViewTextBoxColumn
  Friend WithEvents ColumnTime As DataGridViewTextBoxColumn
  Friend WithEvents ColumnAwayGoal As DataGridViewTextBoxColumn
  Friend WithEvents ColumnAwayPlayer As DataGridViewTextBoxColumn
  Friend WithEvents ColumnAwayType As DataGridViewTextBoxColumn
End Class

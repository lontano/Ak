﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutBoxAk
  Inherits MetroFramework.Forms.MetroForm

  'Form overrides dispose to clean up the component list.
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

  Friend WithEvents TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
  Friend WithEvents LabelProductName As MetroFramework.Controls.MetroLabel
  Friend WithEvents LabelVersion As MetroFramework.Controls.MetroLabel
  Friend WithEvents LabelCompanyName As MetroFramework.Controls.MetroLabel
  Friend WithEvents TextBoxDescription As MetroFramework.Controls.MetroTextBox
  Friend WithEvents OKButton As MetroFramework.Controls.MetroButton
  Friend WithEvents LabelCopyright As MetroFramework.Controls.MetroLabel

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutBoxAk))
    Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
    Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
    Me.LabelProductName = New MetroFramework.Controls.MetroLabel()
    Me.LabelVersion = New MetroFramework.Controls.MetroLabel()
    Me.LabelCopyright = New MetroFramework.Controls.MetroLabel()
    Me.LabelCompanyName = New MetroFramework.Controls.MetroLabel()
    Me.TextBoxDescription = New MetroFramework.Controls.MetroTextBox()
    Me.OKButton = New MetroFramework.Controls.MetroButton()
    Me.TableLayoutPanel.SuspendLayout()
    CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'TableLayoutPanel
    '
    Me.TableLayoutPanel.ColumnCount = 2
    Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
    Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.0!))
    Me.TableLayoutPanel.Controls.Add(Me.LogoPictureBox, 0, 0)
    Me.TableLayoutPanel.Controls.Add(Me.LabelProductName, 1, 0)
    Me.TableLayoutPanel.Controls.Add(Me.LabelVersion, 1, 1)
    Me.TableLayoutPanel.Controls.Add(Me.LabelCopyright, 1, 2)
    Me.TableLayoutPanel.Controls.Add(Me.LabelCompanyName, 1, 3)
    Me.TableLayoutPanel.Controls.Add(Me.TextBoxDescription, 1, 4)
    Me.TableLayoutPanel.Controls.Add(Me.OKButton, 1, 5)
    Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel.Location = New System.Drawing.Point(9, 60)
    Me.TableLayoutPanel.Name = "TableLayoutPanel"
    Me.TableLayoutPanel.RowCount = 6
    Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
    Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
    Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
    Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
    Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
    Me.TableLayoutPanel.Size = New System.Drawing.Size(396, 207)
    Me.TableLayoutPanel.TabIndex = 0
    '
    'LogoPictureBox
    '
    Me.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
    Me.LogoPictureBox.Location = New System.Drawing.Point(3, 3)
    Me.LogoPictureBox.Name = "LogoPictureBox"
    Me.TableLayoutPanel.SetRowSpan(Me.LogoPictureBox, 6)
    Me.LogoPictureBox.Size = New System.Drawing.Size(124, 201)
    Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.LogoPictureBox.TabIndex = 0
    Me.LogoPictureBox.TabStop = False
    '
    'LabelProductName
    '
    Me.LabelProductName.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelProductName.Location = New System.Drawing.Point(136, 0)
    Me.LabelProductName.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
    Me.LabelProductName.MaximumSize = New System.Drawing.Size(0, 17)
    Me.LabelProductName.Name = "LabelProductName"
    Me.LabelProductName.Size = New System.Drawing.Size(257, 17)
    Me.LabelProductName.TabIndex = 0
    Me.LabelProductName.Text = "Product Name"
    Me.LabelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'LabelVersion
    '
    Me.LabelVersion.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelVersion.Location = New System.Drawing.Point(136, 20)
    Me.LabelVersion.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
    Me.LabelVersion.MaximumSize = New System.Drawing.Size(0, 17)
    Me.LabelVersion.Name = "LabelVersion"
    Me.LabelVersion.Size = New System.Drawing.Size(257, 17)
    Me.LabelVersion.TabIndex = 0
    Me.LabelVersion.Text = "Version"
    Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'LabelCopyright
    '
    Me.LabelCopyright.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelCopyright.Location = New System.Drawing.Point(136, 40)
    Me.LabelCopyright.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
    Me.LabelCopyright.MaximumSize = New System.Drawing.Size(0, 17)
    Me.LabelCopyright.Name = "LabelCopyright"
    Me.LabelCopyright.Size = New System.Drawing.Size(257, 17)
    Me.LabelCopyright.TabIndex = 0
    Me.LabelCopyright.Text = "Copyright"
    Me.LabelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'LabelCompanyName
    '
    Me.LabelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelCompanyName.Location = New System.Drawing.Point(136, 60)
    Me.LabelCompanyName.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
    Me.LabelCompanyName.MaximumSize = New System.Drawing.Size(0, 17)
    Me.LabelCompanyName.Name = "LabelCompanyName"
    Me.LabelCompanyName.Size = New System.Drawing.Size(257, 17)
    Me.LabelCompanyName.TabIndex = 0
    Me.LabelCompanyName.Text = "Company Name"
    Me.LabelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'TextBoxDescription
    '
    '
    '
    '
    Me.TextBoxDescription.CustomButton.Image = Nothing
    Me.TextBoxDescription.CustomButton.Location = New System.Drawing.Point(161, 1)
    Me.TextBoxDescription.CustomButton.Name = ""
    Me.TextBoxDescription.CustomButton.Size = New System.Drawing.Size(95, 95)
    Me.TextBoxDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
    Me.TextBoxDescription.CustomButton.TabIndex = 1
    Me.TextBoxDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
    Me.TextBoxDescription.CustomButton.UseSelectable = True
    Me.TextBoxDescription.CustomButton.Visible = False
    Me.TextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TextBoxDescription.Lines = New String() {"Description :", "", "(At runtime, the labels' text will be replaced with the application's assembly in" &
            "formation.", "Customize the application's assembly information in the Application pane of Proje" &
            "ct Designer.)"}
    Me.TextBoxDescription.Location = New System.Drawing.Point(136, 83)
    Me.TextBoxDescription.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
    Me.TextBoxDescription.MaxLength = 32767
    Me.TextBoxDescription.Multiline = True
    Me.TextBoxDescription.Name = "TextBoxDescription"
    Me.TextBoxDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
    Me.TextBoxDescription.ReadOnly = True
    Me.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
    Me.TextBoxDescription.SelectedText = ""
    Me.TextBoxDescription.SelectionLength = 0
    Me.TextBoxDescription.SelectionStart = 0
    Me.TextBoxDescription.Size = New System.Drawing.Size(257, 97)
    Me.TextBoxDescription.TabIndex = 0
    Me.TextBoxDescription.TabStop = False
    Me.TextBoxDescription.Text = resources.GetString("TextBoxDescription.Text")
    Me.TextBoxDescription.UseSelectable = True
    Me.TextBoxDescription.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
    Me.TextBoxDescription.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
    '
    'OKButton
    '
    Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.OKButton.Location = New System.Drawing.Point(318, 186)
    Me.OKButton.Name = "OKButton"
    Me.OKButton.Size = New System.Drawing.Size(75, 18)
    Me.OKButton.TabIndex = 0
    Me.OKButton.Text = "&OK"
    Me.OKButton.UseSelectable = True
    '
    'AboutBoxAk
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.OKButton
    Me.ClientSize = New System.Drawing.Size(414, 276)
    Me.Controls.Add(Me.TableLayoutPanel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "AboutBoxAk"
    Me.Padding = New System.Windows.Forms.Padding(9, 60, 9, 9)
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "AboutBoxAk"
    Me.TableLayoutPanel.ResumeLayout(False)
    CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

End Class

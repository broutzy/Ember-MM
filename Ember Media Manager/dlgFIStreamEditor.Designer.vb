﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgFIStreamEditor
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
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.OK_Button = New System.Windows.Forms.Button()
		Me.Cancel_Button = New System.Windows.Forms.Button()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.cbVideoLanguage = New System.Windows.Forms.ComboBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtARatio = New System.Windows.Forms.TextBox()
		Me.rbInterlaced = New System.Windows.Forms.RadioButton()
		Me.rbProgressive = New System.Windows.Forms.RadioButton()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.cbVideoCodec = New System.Windows.Forms.ComboBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtDuration = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtHeight = New System.Windows.Forms.TextBox()
		Me.txtWidth = New System.Windows.Forms.TextBox()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.cbAudioChannels = New System.Windows.Forms.ComboBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.cbAudioCodec = New System.Windows.Forms.ComboBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.cbAudioLanguage = New System.Windows.Forms.ComboBox()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.rbExternal = New System.Windows.Forms.RadioButton()
		Me.rbEmbedded = New System.Windows.Forms.RadioButton()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.cbSubsLanguage = New System.Windows.Forms.ComboBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(87, 215)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 1
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
		Me.TableLayoutPanel1.TabIndex = 0
		'
		'OK_Button
		'
		Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.OK_Button.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.OK_Button.Location = New System.Drawing.Point(3, 3)
		Me.OK_Button.Name = "OK_Button"
		Me.OK_Button.Size = New System.Drawing.Size(67, 23)
		Me.OK_Button.TabIndex = 0
		Me.OK_Button.Text = "OK"
		'
		'Cancel_Button
		'
		Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Cancel_Button.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
		Me.Cancel_Button.Name = "Cancel_Button"
		Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
		Me.Cancel_Button.TabIndex = 1
		Me.Cancel_Button.Text = "Cancel"
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Label8)
		Me.GroupBox1.Controls.Add(Me.cbVideoLanguage)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Controls.Add(Me.txtARatio)
		Me.GroupBox1.Controls.Add(Me.rbInterlaced)
		Me.GroupBox1.Controls.Add(Me.rbProgressive)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.cbVideoCodec)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.txtDuration)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.txtHeight)
		Me.GroupBox1.Controls.Add(Me.txtWidth)
		Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.GroupBox1.Location = New System.Drawing.Point(21, 7)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(191, 194)
		Me.GroupBox1.TabIndex = 1
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Video Streams"
		Me.GroupBox1.Visible = False
		'
		'Label8
		'
		Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.Label8.Location = New System.Drawing.Point(4, 167)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(68, 19)
		Me.Label8.TabIndex = 12
		Me.Label8.Text = "Language"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'cbVideoLanguage
		'
		Me.cbVideoLanguage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.cbVideoLanguage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cbVideoLanguage.DropDownWidth = 120
		Me.cbVideoLanguage.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.cbVideoLanguage.FormattingEnabled = True
		Me.cbVideoLanguage.Location = New System.Drawing.Point(76, 165)
		Me.cbVideoLanguage.Name = "cbVideoLanguage"
		Me.cbVideoLanguage.Size = New System.Drawing.Size(93, 21)
		Me.cbVideoLanguage.TabIndex = 13
		'
		'Label5
		'
		Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.Label5.Location = New System.Drawing.Point(5, 116)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(68, 19)
		Me.Label5.TabIndex = 8
		Me.Label5.Text = "Aspect Ratio"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'txtARatio
		'
		Me.txtARatio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.txtARatio.Location = New System.Drawing.Point(76, 115)
		Me.txtARatio.Name = "txtARatio"
		Me.txtARatio.Size = New System.Drawing.Size(48, 22)
		Me.txtARatio.TabIndex = 9
		'
		'rbInterlaced
		'
		Me.rbInterlaced.AutoSize = True
		Me.rbInterlaced.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.rbInterlaced.Location = New System.Drawing.Point(111, 45)
		Me.rbInterlaced.Name = "rbInterlaced"
		Me.rbInterlaced.Size = New System.Drawing.Size(76, 17)
		Me.rbInterlaced.TabIndex = 3
		Me.rbInterlaced.TabStop = True
		Me.rbInterlaced.Text = "Interlaced"
		Me.rbInterlaced.UseVisualStyleBackColor = True
		'
		'rbProgressive
		'
		Me.rbProgressive.AutoSize = True
		Me.rbProgressive.Checked = True
		Me.rbProgressive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.rbProgressive.Location = New System.Drawing.Point(25, 45)
		Me.rbProgressive.Name = "rbProgressive"
		Me.rbProgressive.Size = New System.Drawing.Size(85, 17)
		Me.rbProgressive.TabIndex = 2
		Me.rbProgressive.TabStop = True
		Me.rbProgressive.Text = "Progressive"
		Me.rbProgressive.UseVisualStyleBackColor = True
		'
		'Label4
		'
		Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.Label4.Location = New System.Drawing.Point(22, 21)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(51, 15)
		Me.Label4.TabIndex = 0
		Me.Label4.Text = "Codec"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'cbVideoCodec
		'
		Me.cbVideoCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbVideoCodec.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.cbVideoCodec.FormattingEnabled = True
		Me.cbVideoCodec.Location = New System.Drawing.Point(76, 19)
		Me.cbVideoCodec.Name = "cbVideoCodec"
		Me.cbVideoCodec.Size = New System.Drawing.Size(93, 21)
		Me.cbVideoCodec.TabIndex = 1
		'
		'Label3
		'
		Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.Label3.Location = New System.Drawing.Point(17, 143)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(56, 13)
		Me.Label3.TabIndex = 10
		Me.Label3.Text = "Duration"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'txtDuration
		'
		Me.txtDuration.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.txtDuration.Location = New System.Drawing.Point(76, 139)
		Me.txtDuration.Name = "txtDuration"
		Me.txtDuration.Size = New System.Drawing.Size(68, 22)
		Me.txtDuration.TabIndex = 11
		'
		'Label2
		'
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.Label2.Location = New System.Drawing.Point(17, 93)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(56, 16)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "Height"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.Label1.Location = New System.Drawing.Point(20, 69)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(53, 19)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Width"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'txtHeight
		'
		Me.txtHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.txtHeight.Location = New System.Drawing.Point(76, 91)
		Me.txtHeight.Name = "txtHeight"
		Me.txtHeight.Size = New System.Drawing.Size(48, 22)
		Me.txtHeight.TabIndex = 7
		'
		'txtWidth
		'
		Me.txtWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.txtWidth.Location = New System.Drawing.Point(76, 68)
		Me.txtWidth.Name = "txtWidth"
		Me.txtWidth.Size = New System.Drawing.Size(48, 22)
		Me.txtWidth.TabIndex = 5
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.Label9)
		Me.GroupBox2.Controls.Add(Me.cbAudioChannels)
		Me.GroupBox2.Controls.Add(Me.Label7)
		Me.GroupBox2.Controls.Add(Me.cbAudioCodec)
		Me.GroupBox2.Controls.Add(Me.Label6)
		Me.GroupBox2.Controls.Add(Me.cbAudioLanguage)
		Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox2.Location = New System.Drawing.Point(21, 7)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(191, 194)
		Me.GroupBox2.TabIndex = 5
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Audio Streams"
		Me.GroupBox2.Visible = False
		'
		'Label9
		'
		Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(3, 75)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(68, 19)
		Me.Label9.TabIndex = 4
		Me.Label9.Text = "Channels"
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'cbAudioChannels
		'
		Me.cbAudioChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbAudioChannels.FormattingEnabled = True
		Me.cbAudioChannels.Location = New System.Drawing.Point(75, 73)
		Me.cbAudioChannels.Name = "cbAudioChannels"
		Me.cbAudioChannels.Size = New System.Drawing.Size(93, 21)
		Me.cbAudioChannels.TabIndex = 5
		'
		'Label7
		'
		Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(3, 48)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(68, 19)
		Me.Label7.TabIndex = 2
		Me.Label7.Text = "Codec"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'cbAudioCodec
		'
		Me.cbAudioCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbAudioCodec.FormattingEnabled = True
		Me.cbAudioCodec.Location = New System.Drawing.Point(75, 46)
		Me.cbAudioCodec.Name = "cbAudioCodec"
		Me.cbAudioCodec.Size = New System.Drawing.Size(93, 21)
		Me.cbAudioCodec.TabIndex = 3
		'
		'Label6
		'
		Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(3, 21)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(68, 19)
		Me.Label6.TabIndex = 0
		Me.Label6.Text = "Language"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'cbAudioLanguage
		'
		Me.cbAudioLanguage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.cbAudioLanguage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cbAudioLanguage.DropDownWidth = 120
		Me.cbAudioLanguage.FormattingEnabled = True
		Me.cbAudioLanguage.Location = New System.Drawing.Point(75, 19)
		Me.cbAudioLanguage.Name = "cbAudioLanguage"
		Me.cbAudioLanguage.Size = New System.Drawing.Size(93, 21)
		Me.cbAudioLanguage.Sorted = True
		Me.cbAudioLanguage.TabIndex = 1
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.rbExternal)
		Me.GroupBox3.Controls.Add(Me.rbEmbedded)
		Me.GroupBox3.Controls.Add(Me.Label10)
		Me.GroupBox3.Controls.Add(Me.cbSubsLanguage)
		Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox3.Location = New System.Drawing.Point(21, 7)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(191, 194)
		Me.GroupBox3.TabIndex = 6
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Subtitle  Streams"
		Me.GroupBox3.Visible = False
		'
		'rbExternal
		'
		Me.rbExternal.AutoSize = True
		Me.rbExternal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.rbExternal.Location = New System.Drawing.Point(94, 46)
		Me.rbExternal.Name = "rbExternal"
		Me.rbExternal.Size = New System.Drawing.Size(67, 17)
		Me.rbExternal.TabIndex = 24
		Me.rbExternal.TabStop = True
		Me.rbExternal.Text = "External"
		Me.rbExternal.UseVisualStyleBackColor = True
		'
		'rbEmbedded
		'
		Me.rbEmbedded.AutoSize = True
		Me.rbEmbedded.Checked = True
		Me.rbEmbedded.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.rbEmbedded.Location = New System.Drawing.Point(8, 46)
		Me.rbEmbedded.Name = "rbEmbedded"
		Me.rbEmbedded.Size = New System.Drawing.Size(81, 17)
		Me.rbEmbedded.TabIndex = 23
		Me.rbEmbedded.TabStop = True
		Me.rbEmbedded.Text = "Embedded"
		Me.rbEmbedded.UseVisualStyleBackColor = True
		'
		'Label10
		'
		Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.Location = New System.Drawing.Point(5, 21)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(71, 19)
		Me.Label10.TabIndex = 22
		Me.Label10.Text = "Language"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'cbSubsLanguage
		'
		Me.cbSubsLanguage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.cbSubsLanguage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cbSubsLanguage.DropDownWidth = 120
		Me.cbSubsLanguage.FormattingEnabled = True
		Me.cbSubsLanguage.Location = New System.Drawing.Point(79, 21)
		Me.cbSubsLanguage.Name = "cbSubsLanguage"
		Me.cbSubsLanguage.Size = New System.Drawing.Size(93, 21)
		Me.cbSubsLanguage.Sorted = True
		Me.cbSubsLanguage.TabIndex = 0
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.White
		Me.Panel1.Controls.Add(Me.GroupBox1)
		Me.Panel1.Controls.Add(Me.GroupBox2)
		Me.Panel1.Controls.Add(Me.GroupBox3)
		Me.Panel1.Location = New System.Drawing.Point(3, 3)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(236, 209)
		Me.Panel1.TabIndex = 1
		'
		'dlgFIStreamEditor
		'
		Me.AcceptButton = Me.OK_Button
		Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
		Me.CancelButton = Me.Cancel_Button
		Me.ClientSize = New System.Drawing.Size(241, 247)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "dlgFIStreamEditor"
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Stream Editor"
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents txtWidth As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbVideoCodec As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDuration As System.Windows.Forms.TextBox
    Friend WithEvents rbInterlaced As System.Windows.Forms.RadioButton
    Friend WithEvents rbProgressive As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtARatio As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbAudioCodec As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbAudioLanguage As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbAudioChannels As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbSubsLanguage As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbVideoLanguage As System.Windows.Forms.ComboBox
    Friend WithEvents rbExternal As System.Windows.Forms.RadioButton
    Friend WithEvents rbEmbedded As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class

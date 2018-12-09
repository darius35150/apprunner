<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuBrowser = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuYahoo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuYouTube = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAmazon = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBtnPanel = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlBrowser = New System.Windows.Forms.WebBrowser()
        Me.grpApps = New System.Windows.Forms.GroupBox()
        Me.btnCmmPrmt = New System.Windows.Forms.Button()
        Me.btnVBox = New System.Windows.Forms.Button()
        Me.btnXSplit = New System.Windows.Forms.Button()
        Me.btnVSCode = New System.Windows.Forms.Button()
        Me.btnNotepad = New System.Windows.Forms.Button()
        Me.btnMars = New System.Windows.Forms.Button()
        Me.btnOxygen = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.grpApps.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBrowser, Me.mnuBtnPanel})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(755, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuBrowser
        '
        Me.mnuBrowser.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuYahoo, Me.mnuYouTube, Me.mnuAmazon})
        Me.mnuBrowser.Name = "mnuBrowser"
        Me.mnuBrowser.Size = New System.Drawing.Size(61, 20)
        Me.mnuBrowser.Text = "Browser"
        '
        'mnuYahoo
        '
        Me.mnuYahoo.Name = "mnuYahoo"
        Me.mnuYahoo.Size = New System.Drawing.Size(180, 22)
        Me.mnuYahoo.Text = "Yahoo"
        '
        'mnuYouTube
        '
        Me.mnuYouTube.Name = "mnuYouTube"
        Me.mnuYouTube.Size = New System.Drawing.Size(180, 22)
        Me.mnuYouTube.Text = "YouTube"
        '
        'mnuAmazon
        '
        Me.mnuAmazon.Name = "mnuAmazon"
        Me.mnuAmazon.Size = New System.Drawing.Size(180, 22)
        Me.mnuAmazon.Text = "Amazon"
        '
        'mnuBtnPanel
        '
        Me.mnuBtnPanel.Name = "mnuBtnPanel"
        Me.mnuBtnPanel.Size = New System.Drawing.Size(78, 20)
        Me.mnuBtnPanel.Text = "Apps Panel"
        '
        'pnlBrowser
        '
        Me.pnlBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBrowser.Location = New System.Drawing.Point(0, 24)
        Me.pnlBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.pnlBrowser.Name = "pnlBrowser"
        Me.pnlBrowser.Size = New System.Drawing.Size(755, 551)
        Me.pnlBrowser.TabIndex = 6
        Me.pnlBrowser.Url = New System.Uri("", System.UriKind.Relative)
        Me.pnlBrowser.Visible = False
        '
        'grpApps
        '
        Me.grpApps.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.grpApps.BackgroundImage = CType(resources.GetObject("grpApps.BackgroundImage"), System.Drawing.Image)
        Me.grpApps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grpApps.Controls.Add(Me.btnCmmPrmt)
        Me.grpApps.Controls.Add(Me.btnVBox)
        Me.grpApps.Controls.Add(Me.btnXSplit)
        Me.grpApps.Controls.Add(Me.btnVSCode)
        Me.grpApps.Controls.Add(Me.btnNotepad)
        Me.grpApps.Controls.Add(Me.btnMars)
        Me.grpApps.Controls.Add(Me.btnOxygen)
        Me.grpApps.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.grpApps.Location = New System.Drawing.Point(28, 39)
        Me.grpApps.Name = "grpApps"
        Me.grpApps.Size = New System.Drawing.Size(686, 508)
        Me.grpApps.TabIndex = 10
        Me.grpApps.TabStop = False
        Me.grpApps.Text = "Apps"
        Me.grpApps.Visible = False
        '
        'btnCmmPrmt
        '
        Me.btnCmmPrmt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCmmPrmt.Location = New System.Drawing.Point(87, 353)
        Me.btnCmmPrmt.Name = "btnCmmPrmt"
        Me.btnCmmPrmt.Size = New System.Drawing.Size(75, 23)
        Me.btnCmmPrmt.TabIndex = 6
        Me.btnCmmPrmt.Text = "Comm Prmt"
        Me.btnCmmPrmt.UseVisualStyleBackColor = True
        '
        'btnVBox
        '
        Me.btnVBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnVBox.Location = New System.Drawing.Point(509, 182)
        Me.btnVBox.Name = "btnVBox"
        Me.btnVBox.Size = New System.Drawing.Size(75, 23)
        Me.btnVBox.TabIndex = 5
        Me.btnVBox.Text = "Virtual Box"
        Me.btnVBox.UseVisualStyleBackColor = True
        '
        'btnXSplit
        '
        Me.btnXSplit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnXSplit.Location = New System.Drawing.Point(293, 191)
        Me.btnXSplit.Name = "btnXSplit"
        Me.btnXSplit.Size = New System.Drawing.Size(75, 23)
        Me.btnXSplit.TabIndex = 4
        Me.btnXSplit.Text = "X Split"
        Me.btnXSplit.UseVisualStyleBackColor = True
        '
        'btnVSCode
        '
        Me.btnVSCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnVSCode.Location = New System.Drawing.Point(87, 191)
        Me.btnVSCode.Name = "btnVSCode"
        Me.btnVSCode.Size = New System.Drawing.Size(75, 23)
        Me.btnVSCode.TabIndex = 3
        Me.btnVSCode.Text = "VS Code"
        Me.btnVSCode.UseVisualStyleBackColor = True
        '
        'btnNotepad
        '
        Me.btnNotepad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnNotepad.Location = New System.Drawing.Point(509, 19)
        Me.btnNotepad.Name = "btnNotepad"
        Me.btnNotepad.Size = New System.Drawing.Size(75, 23)
        Me.btnNotepad.TabIndex = 2
        Me.btnNotepad.Text = "NotPad++"
        Me.btnNotepad.UseVisualStyleBackColor = True
        '
        'btnMars
        '
        Me.btnMars.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMars.Location = New System.Drawing.Point(293, 19)
        Me.btnMars.Name = "btnMars"
        Me.btnMars.Size = New System.Drawing.Size(75, 23)
        Me.btnMars.TabIndex = 1
        Me.btnMars.Text = "Eclipse Mars"
        Me.btnMars.UseVisualStyleBackColor = True
        '
        'btnOxygen
        '
        Me.btnOxygen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnOxygen.Location = New System.Drawing.Point(87, 19)
        Me.btnOxygen.Name = "btnOxygen"
        Me.btnOxygen.Size = New System.Drawing.Size(75, 23)
        Me.btnOxygen.TabIndex = 0
        Me.btnOxygen.Text = "Eclipse Ogn"
        Me.btnOxygen.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 575)
        Me.Controls.Add(Me.grpApps)
        Me.Controls.Add(Me.pnlBrowser)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "App Runner"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpApps.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuBrowser As ToolStripMenuItem
    Friend WithEvents mnuBtnPanel As ToolStripMenuItem
    Friend WithEvents pnlBrowser As WebBrowser
    Friend WithEvents mnuYahoo As ToolStripMenuItem
    Friend WithEvents mnuYouTube As ToolStripMenuItem
    Friend WithEvents mnuAmazon As ToolStripMenuItem
    Friend WithEvents grpApps As GroupBox
    Friend WithEvents btnOxygen As Button
    Friend WithEvents btnCmmPrmt As Button
    Friend WithEvents btnVBox As Button
    Friend WithEvents btnXSplit As Button
    Friend WithEvents btnVSCode As Button
    Friend WithEvents btnNotepad As Button
    Friend WithEvents btnMars As Button
End Class

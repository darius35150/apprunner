Public Class Form1
    Private Sub mnuBtnPanel_Click(sender As Object, e As EventArgs) Handles mnuBtnPanel.Click
        If pnlBrowser.Visible = True Then
            pnlBrowser.Visible = False
        End If
        grpApps.Visible = True
    End Sub

    Private Sub btnOxygen_Click(sender As Object, e As EventArgs) Handles btnOxygen.Click
        Process.Start("C:\eclipse\eclipse.exe")
    End Sub

    Private Sub btnMars_Click(sender As Object, e As EventArgs) Handles btnMars.Click
        Process.Start("C:\eclipse.mars\eclipse.exe")
    End Sub

    Private Sub btnNotepad_Click(sender As Object, e As EventArgs) Handles btnNotepad.Click
        Process.Start("C:\Program Files (x86)\Notepad++\notepad++.exe")
    End Sub

    Private Sub btnVSCode_Click(sender As Object, e As EventArgs) Handles btnVSCode.Click
        Process.Start("C:\Users\dariush\AppData\Local\Programs\Microsoft VS Code\Code.exe")
    End Sub

    Private Sub btnXSplit_Click(sender As Object, e As EventArgs) Handles btnXSplit.Click
        Process.Start("C:\Program Files (x86)\SplitmediaLabs\XSplit Broadcaster\x64\XSplit.Core.exe")
    End Sub

    Private Sub btnVBox_Click(sender As Object, e As EventArgs) Handles btnVBox.Click
        Process.Start("C:\Program Files\Oracle\VirtualBox\VirtualBox.exe")
    End Sub

    Private Sub btnCmmPrmt_Click(sender As Object, e As EventArgs) Handles btnCmmPrmt.Click
        Process.Start("C:\Windows\System32\cmd.exe")
    End Sub

    Private Sub mnuYahoo_Click(sender As Object, e As EventArgs) Handles mnuYahoo.Click
        If pnlBrowser.Visible = False Then
            pnlBrowser.Visible = True
        End If

        If grpApps.Visible = True Then
            grpApps.Visible = False
        End If
        pnlBrowser.Navigate("https://yahoo.com")
        pnlBrowser.ScriptErrorsSuppressed = True
    End Sub

    Private Sub mnuYouTube_Click(sender As Object, e As EventArgs) Handles mnuYouTube.Click
        If pnlBrowser.Visible = False Then
            pnlBrowser.Visible = True
        End If

        If grpApps.Visible = True Then
            grpApps.Visible = False
        End If
        pnlBrowser.Navigate("https://youtube.com")
    End Sub

    Private Sub mnuAmazon_Click(sender As Object, e As EventArgs) Handles mnuAmazon.Click
        If pnlBrowser.Visible = False Then
            pnlBrowser.Visible = True
        End If

        If grpApps.Visible = True Then
            grpApps.Visible = False
        End If
        pnlBrowser.Navigate("https://amazon.com")
    End Sub
End Class

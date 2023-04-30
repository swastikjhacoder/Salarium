#Region "Imports..."
Imports ESAR_Controls.UIControls.eForms
#End Region
#Region "Class frmMainForm..."
Public Class frmMainForm
#Region "WithEvents..."
    Private WithEvents childA As frmChangeSystemDate
#End Region
#Region "Declarations..."
    Dim Docker As New FormDocker(Me, FormDocker.FormDockMode.TopRight, New Padding(5))
    Private userexist As Boolean = False
#End Region
#Region "Methods..."
    Private Sub CheckUser()
        Try
            cmd.CommandText = "select * from Users where CompID='" & My.Settings.LastOpenedCompanyID & "' and CompName='" & My.Settings.LastOpenedCompany & "' and Period='" & My.Settings.Period & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                userexist = True
            Else
                userexist = False
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
            userexist = False
        End Try
    End Sub

    Private Sub VisibleMenus()
        ToolStripSeparator2.Visible = False
        ToolStripSeparator4.Visible = False
        CloseInstituteToolStripMenuItem.Visible = False
        ExportYourDataToolStripMenuItem.Visible = False
        BackupInstitutionDataToolStripMenuItem.Visible = False
        RestoreInstitutionDataToolStripMenuItem.Visible = False
        SynchronizeInstitutionDataThroughTheWebToolStripMenuItem.Visible = False
        EditToolStripMenuItem.Visible = False
    End Sub

    Private Function CheckCompanyExist() As Boolean
        Dim exist As Boolean = False
        Try
            cmd.CommandText = "select * from Company where CompName='" & My.Settings.LastOpenedCompany & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                exist = True
                dr.Close()
            Else
                exist = False
                dr.Close()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
        Return exist
    End Function
#End Region
#Region "Form Events..."
    Private Sub frmMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'My.Settings.Reset()
        Docker.DockForm()
        Docker.UndockForm()
        Docker.DockForm()
        Connect()
        VisibleMenus()
        My.Settings.SalariumDate = Date.Now.ToShortDateString()
        My.Settings.Save()
        If My.Settings.StartWithLastOpenedCompany = False Then
            StartWithLastOpenedInstituteToolStripMenuItem.Checked = False
        Else
            StartWithLastOpenedInstituteToolStripMenuItem.Checked = True
        End If
        If My.Settings.Activated = True Then
            Try
                If My.Settings.InstallDate <> "" Then
                    Dim doj As String = My.Settings.InstallDate
                    Dim DTE As TimeSpan
                    Dim mmdte As Date = Date.Parse(doj)
                    DTE = Date.Parse((Date.Today).ToShortDateString()) - Date.Parse(doj)
                    Dim Days As Integer = CInt(DTE.TotalDays)
                    If Days > 365 Then
                        Me.EMenuStrip1.Enabled = False
                        Dim frm As New frmRosterExpired()
                        frm.MdiParent = Me
                        frm.Show()
                    Else
                        Dim frm As New frmMainTask()
                        frm.MdiParent = Me
                        frm.Show()
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString())
            End Try
        Else
            Dim frm As New frmRegistration()
            frm.MdiParent = Me
            frm.Show()
        End If
    End Sub
#End Region
#Region "Menu Events..."
#Region "File Menu..."
    'Private Sub NewInstituteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewInstituteToolStripMenuItem.Click
    '    For Each frmApproval As Form In Me.MdiChildren
    '        frmApproval.Close()
    '    Next
    '    MainTask = "Create"
    '    If userexist = True Then
    '        Dim frm As New frmLogin()
    '        frm.MdiParent = Me
    '        frm.Show()
    '    Else
    '        Dim frm As New frmCreateCompany()
    '        frm.MdiParent = Me
    '        frm.Show()
    '    End If
    'End Sub

    'Private Sub OpenPreviouslyOpenedInstituteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenPreviouslyOpenedInstituteToolStripMenuItem.Click
    '    Try
    '        Dim exist As Boolean = CheckCompanyExist()
    '        If exist = True Then
    '            For Each frmApproval As Form In Me.MdiChildren
    '                frmApproval.Close()
    '            Next
    '            MainTask = "Open"
    '            CheckUser()
    '            If userexist = True Then
    '                Dim frm As New frmLogin()
    '                frm.MdiParent = Me
    '                frm.Show()
    '            Else
    '                Dim frm As New frmOpeningCompany()
    '                frm.MdiParent = Me
    '                frm.Show()
    '            End If
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub OpenInstituteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenInstituteToolStripMenuItem1.Click
    '    For Each frmApproval As Form In Me.MdiChildren
    '        frmApproval.Close()
    '    Next
    '    MainTask = "Open"
    '    Dim frm As New frmOpenCompany()
    '    frm.MdiParent = Me
    '    frm.Show()
    'End Sub

    'Private Sub CloseInstituteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseInstituteToolStripMenuItem.Click
    '    For Each frmApproval As Form In Me.MdiChildren
    '        frmApproval.Close()
    '    Next
    'End Sub

    'Private Sub ExportYourDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportYourDataToolStripMenuItem.Click
    '    Dim frm As New frmImportExport()
    '    frm.ShowDialog()
    'End Sub

    'Private Sub BackupInstitutionDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupInstitutionDataToolStripMenuItem.Click
    '    Dim frm As New frmBackup()
    '    frm.ShowDialog()
    'End Sub

    'Private Sub RestoreInstitutionDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoreInstitutionDataToolStripMenuItem.Click
    '    Dim frm As New frmRestore()
    '    frm.ShowDialog()
    'End Sub

    'Private Sub SynchronizeInstitutionDataThroughTheWebToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SynchronizeInstitutionDataThroughTheWebToolStripMenuItem.Click

    'End Sub

    'Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
    '    For Each frmApproval As Form In Me.MdiChildren
    '        frmApproval.Close()
    '    Next
    '    Me.Close()
    'End Sub
#End Region
#Region "Edit Menu..."
    'Private Sub FindTransactionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindTransactionsToolStripMenuItem.Click
    '    Dim frm As New frmFindTransaction()
    '    frm.ShowDialog()
    'End Sub

    'Private Sub ChangeDefaultValuesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeDefaultValuesToolStripMenuItem.Click
    '    Dim frm As New frmChangeDefaultIndex()
    '    frm.ShowDialog()
    'End Sub
#End Region
#Region "Options Menu..."
    'Private Sub StartWithLastOpenedInstituteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartWithLastOpenedInstituteToolStripMenuItem.Click
    '    If StartWithLastOpenedInstituteToolStripMenuItem.Checked = True Then
    '        StartWithLastOpenedInstituteToolStripMenuItem.Checked = False
    '        My.Settings.StartWithLastOpenedCompany = False
    '        My.Settings.Save()
    '    Else
    '        StartWithLastOpenedInstituteToolStripMenuItem.Checked = True
    '        My.Settings.StartWithLastOpenedCompany = True
    '        My.Settings.Save()
    '    End If
    'End Sub
#End Region
#Region "Services Menu..."
    'Private Sub CheckForUpdatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
    '    Dim frm As New frmCheckForUpdates()
    '    frm.ShowDialog()
    'End Sub

    'Private Sub MyECreativeAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'End Sub

    'Private Sub CustomerSupportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim frm As New frmCustomerSupport()
    '    frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
    '    frm.StartPosition = FormStartPosition.CenterScreen
    '    frm.WindowState = FormWindowState.Normal
    '    frm.ControlBox = True
    '    frm.ShowDialog()
    'End Sub

    'Private Sub UmbrellaOnTheWebToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'End Sub

    'Private Sub ProductComparisonToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim frm As New frmProductComparison()
    '    frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
    '    frm.StartPosition = FormStartPosition.CenterScreen
    '    frm.WindowState = FormWindowState.Normal
    '    frm.ControlBox = True
    '    frm.ShowDialog()
    'End Sub

    'Private Sub IndustrySpecificSolutionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim frm As New frmIndustrySpecificSolution()
    '    frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
    '    frm.StartPosition = FormStartPosition.CenterScreen
    '    frm.WindowState = FormWindowState.Normal
    '    frm.ControlBox = True
    '    frm.ShowDialog()
    'End Sub

    'Private Sub MidSizedBusinessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim frm As New frmMidSizedBusiness()
    '    frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
    '    frm.StartPosition = FormStartPosition.CenterScreen
    '    frm.WindowState = FormWindowState.Normal
    '    frm.ControlBox = True
    '    frm.ShowDialog()
    'End Sub

    'Private Sub MoreProductsServicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'End Sub

    'Private Sub UmbrellaWebTransactionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim frm As New frmWebTransaction()
    '    frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
    '    frm.StartPosition = FormStartPosition.CenterScreen
    '    frm.WindowState = FormWindowState.Normal
    '    frm.ControlBox = True
    '    frm.ShowDialog()
    'End Sub

    'Private Sub UmbrellaSyncWizardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim frm As New frmSynchronize()
    '    frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
    '    frm.StartPosition = FormStartPosition.CenterScreen
    '    frm.WindowState = FormWindowState.Normal
    '    frm.ControlBox = True
    '    frm.ShowDialog()
    'End Sub

    'Private Sub ObsolescenceInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObsolescenceInformationToolStripMenuItem.Click
    '    Dim frm As New frmObsolescenceInformation()
    '    frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
    '    frm.StartPosition = FormStartPosition.CenterScreen
    '    frm.WindowState = FormWindowState.Normal
    '    frm.ControlBox = True
    '    frm.ShowDialog()
    'End Sub
#End Region
#Region "Help Menu..."
    'Private Sub RosteraRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RosteraRegistrationToolStripMenuItem.Click
    '    RegistrationMenu = True
    '    Dim frm As New frmRegistration()
    '    frm.ShowDialog()
    'End Sub

    'Private Sub AboutUmbrellaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutUmbrellaToolStripMenuItem.Click
    '    Dim frm As New frmAboutRoster()
    '    frm.ShowDialog()
    'End Sub
#End Region
#End Region
#Region "ESAR Infotech Link Clicked..."
    Private Sub lnkesarinfotech_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkesarinfotech.Click
        System.Diagnostics.Process.Start("IEXPLORE.EXE", "http://www.esarinfotech.com")
    End Sub
#End Region
End Class
#End Region
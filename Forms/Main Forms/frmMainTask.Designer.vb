<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainTask
    Inherits ESAR_Controls.UIControls.eForms.eFadeGradientForm

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
        Me.components = New System.ComponentModel.Container()
        Dim DesignerRectTracker1 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainTask))
        Dim DesignerRectTracker2 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker()
        Dim DesignerRectTracker3 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker()
        Dim DesignerRectTracker4 As ESAR_Controls.DesignerRectTracker = New ESAR_Controls.DesignerRectTracker()
        Me.EGradientPanel1 = New ESAR_Controls.UIControls.Panels.eGradientPanel()
        Me.ERoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btncreate = New ESAR_Controls.UIControls.Button.eButton()
        Me.btnopen = New ESAR_Controls.UIControls.Button.eButton()
        Me.EGradientPanel1.SuspendLayout()
        Me.ERoundedPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EGradientPanel1
        '
        Me.EGradientPanel1.Controls.Add(Me.ERoundedPanel1)
        Me.EGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGradientPanel1.EndColor = System.Drawing.Color.RoyalBlue
        Me.EGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.EGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EGradientPanel1.Name = "EGradientPanel1"
        Me.EGradientPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.EGradientPanel1.Size = New System.Drawing.Size(340, 257)
        Me.EGradientPanel1.StartColor = System.Drawing.Color.LightCyan
        Me.EGradientPanel1.TabIndex = 0
        '
        'ERoundedPanel1
        '
        Me.ERoundedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.ERoundedPanel1.BorderRadius = 32
        Me.ERoundedPanel1.Controls.Add(Me.GroupBox1)
        Me.ERoundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ERoundedPanel1.Location = New System.Drawing.Point(10, 10)
        Me.ERoundedPanel1.Name = "ERoundedPanel1"
        Me.ERoundedPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.ERoundedPanel1.Size = New System.Drawing.Size(320, 237)
        Me.ERoundedPanel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btncreate)
        Me.GroupBox1.Controls.Add(Me.btnopen)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 217)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tasks:"
        '
        'btncreate
        '
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btncreate.CenterPtTracker = DesignerRectTracker1
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btncreate.FocusPtTracker = DesignerRectTracker2
        Me.btncreate.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncreate.ImageIndex = 0
        Me.btncreate.Location = New System.Drawing.Point(11, 102)
        Me.btncreate.Name = "btncreate"
        Me.btncreate.Shape = ESAR_Controls.UIControls.Button.eButton.eShape.Ellipse
        Me.btncreate.SideImage = Global.Salarium.My.Resources.Resources.setup_guide_x48
        Me.btncreate.Size = New System.Drawing.Size(278, 57)
        Me.btncreate.TabIndex = 2
        Me.btncreate.Text = "Create Your Company"
        '
        'btnopen
        '
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnopen.CenterPtTracker = DesignerRectTracker3
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnopen.FocusPtTracker = DesignerRectTracker4
        Me.btnopen.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnopen.ImageIndex = 0
        Me.btnopen.Location = New System.Drawing.Point(11, 28)
        Me.btnopen.Name = "btnopen"
        Me.btnopen.Shape = ESAR_Controls.UIControls.Button.eButton.eShape.Ellipse
        Me.btnopen.SideImage = Global.Salarium.My.Resources.Resources.Open_x48
        Me.btnopen.Size = New System.Drawing.Size(278, 57)
        Me.btnopen.TabIndex = 1
        Me.btnopen.Text = "Open Your Company"
        '
        'frmMainTask
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(340, 257)
        Me.ControlBox = False
        Me.Controls.Add(Me.EGradientPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.GradientBegin = System.Drawing.Color.LightCyan
        Me.GradientEnabled = True
        Me.GradientEnd = System.Drawing.Color.RoyalBlue
        Me.GradientMiddle = System.Drawing.Color.LightBlue
        Me.GradientPreset = ESAR_Controls.UIControls.eForms.GradientPresets.RoyalLight
        Me.Name = "frmMainTask"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMainTask"
        Me.EGradientPanel1.ResumeLayout(False)
        Me.ERoundedPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EGradientPanel1 As ESAR_Controls.UIControls.Panels.eGradientPanel
    Friend WithEvents ERoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnopen As ESAR_Controls.UIControls.Button.eButton
    Friend WithEvents btncreate As ESAR_Controls.UIControls.Button.eButton
End Class

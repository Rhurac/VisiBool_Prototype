<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlSplitHorizontal
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.pnlMain = New System.Windows.Forms.TableLayoutPanel()
        Me.rteEditor = New System.Windows.Forms.RichTextBox()
        Me.rteOutput = New System.Windows.Forms.RichTextBox()
        Me.pnlEditorControls = New System.Windows.Forms.TableLayoutPanel()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.txtIndependentVars = New System.Windows.Forms.TextBox()
        Me.pnlOutputControls = New System.Windows.Forms.TableLayoutPanel()
        Me.btnTick = New System.Windows.Forms.Button()
        Me.udTickCount = New System.Windows.Forms.NumericUpDown()
        Me.pnlMain.SuspendLayout()
        Me.pnlEditorControls.SuspendLayout()
        Me.pnlOutputControls.SuspendLayout()
        CType(Me.udTickCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.ColumnCount = 1
        Me.pnlMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlMain.Controls.Add(Me.rteEditor, 0, 0)
        Me.pnlMain.Controls.Add(Me.rteOutput, 0, 2)
        Me.pnlMain.Controls.Add(Me.pnlEditorControls, 0, 1)
        Me.pnlMain.Controls.Add(Me.pnlOutputControls, 0, 3)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.RowCount = 4
        Me.pnlMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.pnlMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.pnlMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.pnlMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.pnlMain.Size = New System.Drawing.Size(800, 700)
        Me.pnlMain.TabIndex = 0
        '
        'rteEditor
        '
        Me.rteEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rteEditor.Location = New System.Drawing.Point(3, 3)
        Me.rteEditor.Name = "rteEditor"
        Me.rteEditor.Size = New System.Drawing.Size(794, 309)
        Me.rteEditor.TabIndex = 0
        Me.rteEditor.Text = ""
        '
        'rteOutput
        '
        Me.rteOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rteOutput.Location = New System.Drawing.Point(3, 353)
        Me.rteOutput.Name = "rteOutput"
        Me.rteOutput.Size = New System.Drawing.Size(794, 309)
        Me.rteOutput.TabIndex = 1
        Me.rteOutput.Text = ""
        '
        'pnlEditorControls
        '
        Me.pnlEditorControls.BackColor = System.Drawing.Color.Transparent
        Me.pnlEditorControls.ColumnCount = 2
        Me.pnlEditorControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlEditorControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.pnlEditorControls.Controls.Add(Me.btnRun, 1, 0)
        Me.pnlEditorControls.Controls.Add(Me.txtIndependentVars, 0, 0)
        Me.pnlEditorControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEditorControls.Location = New System.Drawing.Point(3, 318)
        Me.pnlEditorControls.Name = "pnlEditorControls"
        Me.pnlEditorControls.RowCount = 1
        Me.pnlEditorControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlEditorControls.Size = New System.Drawing.Size(794, 29)
        Me.pnlEditorControls.TabIndex = 2
        '
        'btnRun
        '
        Me.btnRun.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRun.Location = New System.Drawing.Point(716, 3)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(75, 23)
        Me.btnRun.TabIndex = 0
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'txtIndependentVars
        '
        Me.txtIndependentVars.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtIndependentVars.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIndependentVars.Location = New System.Drawing.Point(3, 3)
        Me.txtIndependentVars.Name = "txtIndependentVars"
        Me.txtIndependentVars.ReadOnly = True
        Me.txtIndependentVars.Size = New System.Drawing.Size(707, 22)
        Me.txtIndependentVars.TabIndex = 1
        '
        'pnlOutputControls
        '
        Me.pnlOutputControls.BackColor = System.Drawing.Color.Transparent
        Me.pnlOutputControls.ColumnCount = 2
        Me.pnlOutputControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlOutputControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.pnlOutputControls.Controls.Add(Me.btnTick, 1, 0)
        Me.pnlOutputControls.Controls.Add(Me.udTickCount, 0, 0)
        Me.pnlOutputControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOutputControls.Location = New System.Drawing.Point(3, 668)
        Me.pnlOutputControls.Name = "pnlOutputControls"
        Me.pnlOutputControls.RowCount = 1
        Me.pnlOutputControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlOutputControls.Size = New System.Drawing.Size(794, 29)
        Me.pnlOutputControls.TabIndex = 3
        '
        'btnTick
        '
        Me.btnTick.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnTick.Location = New System.Drawing.Point(716, 3)
        Me.btnTick.Name = "btnTick"
        Me.btnTick.Size = New System.Drawing.Size(75, 23)
        Me.btnTick.TabIndex = 0
        Me.btnTick.Text = "Tick"
        Me.btnTick.UseVisualStyleBackColor = True
        '
        'udTickCount
        '
        Me.udTickCount.Dock = System.Windows.Forms.DockStyle.Right
        Me.udTickCount.Location = New System.Drawing.Point(666, 3)
        Me.udTickCount.Name = "udTickCount"
        Me.udTickCount.Size = New System.Drawing.Size(44, 20)
        Me.udTickCount.TabIndex = 1
        '
        'ctlSplitHorizontal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "ctlSplitHorizontal"
        Me.Size = New System.Drawing.Size(800, 700)
        Me.Tag = "Horizontal"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlEditorControls.ResumeLayout(False)
        Me.pnlEditorControls.PerformLayout()
        Me.pnlOutputControls.ResumeLayout(False)
        CType(Me.udTickCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rteEditor As System.Windows.Forms.RichTextBox
    Friend WithEvents rteOutput As System.Windows.Forms.RichTextBox
    Friend WithEvents pnlEditorControls As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents pnlOutputControls As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnTick As System.Windows.Forms.Button
    Friend WithEvents udTickCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtIndependentVars As System.Windows.Forms.TextBox

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlSplitTabbed
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabEditor = New System.Windows.Forms.TabPage()
        Me.tabOutput = New System.Windows.Forms.TabPage()
        Me.pnlEditorMain = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlEditorControls = New System.Windows.Forms.TableLayoutPanel()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.txtIndependentVars = New System.Windows.Forms.TextBox()
        Me.pnlOutputMain = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlOutputControls = New System.Windows.Forms.TableLayoutPanel()
        Me.btnTick = New System.Windows.Forms.Button()
        Me.udTickCount = New System.Windows.Forms.NumericUpDown()
        Me.rteOutput = New System.Windows.Forms.RichTextBox()
        Me.rteEditor = New System.Windows.Forms.RichTextBox()
        Me.TabControl1.SuspendLayout()
        Me.tabEditor.SuspendLayout()
        Me.tabOutput.SuspendLayout()
        Me.pnlEditorMain.SuspendLayout()
        Me.pnlEditorControls.SuspendLayout()
        Me.pnlOutputMain.SuspendLayout()
        Me.pnlOutputControls.SuspendLayout()
        CType(Me.udTickCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabEditor)
        Me.TabControl1.Controls.Add(Me.tabOutput)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 700)
        Me.TabControl1.TabIndex = 0
        '
        'tabEditor
        '
        Me.tabEditor.Controls.Add(Me.pnlEditorMain)
        Me.tabEditor.Location = New System.Drawing.Point(4, 27)
        Me.tabEditor.Name = "tabEditor"
        Me.tabEditor.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEditor.Size = New System.Drawing.Size(792, 669)
        Me.tabEditor.TabIndex = 0
        Me.tabEditor.Text = "Editor"
        Me.tabEditor.UseVisualStyleBackColor = True
        '
        'tabOutput
        '
        Me.tabOutput.Controls.Add(Me.pnlOutputMain)
        Me.tabOutput.Location = New System.Drawing.Point(4, 27)
        Me.tabOutput.Name = "tabOutput"
        Me.tabOutput.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOutput.Size = New System.Drawing.Size(792, 669)
        Me.tabOutput.TabIndex = 1
        Me.tabOutput.Text = "Run"
        Me.tabOutput.UseVisualStyleBackColor = True
        '
        'pnlEditorMain
        '
        Me.pnlEditorMain.ColumnCount = 1
        Me.pnlEditorMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlEditorMain.Controls.Add(Me.pnlEditorControls, 0, 1)
        Me.pnlEditorMain.Controls.Add(Me.rteEditor, 0, 0)
        Me.pnlEditorMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEditorMain.Location = New System.Drawing.Point(3, 3)
        Me.pnlEditorMain.Name = "pnlEditorMain"
        Me.pnlEditorMain.RowCount = 2
        Me.pnlEditorMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.0!))
        Me.pnlEditorMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.pnlEditorMain.Size = New System.Drawing.Size(786, 663)
        Me.pnlEditorMain.TabIndex = 0
        '
        'pnlEditorControls
        '
        Me.pnlEditorControls.ColumnCount = 2
        Me.pnlEditorControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlEditorControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.pnlEditorControls.Controls.Add(Me.btnRun, 1, 0)
        Me.pnlEditorControls.Controls.Add(Me.txtIndependentVars, 0, 0)
        Me.pnlEditorControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEditorControls.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlEditorControls.Location = New System.Drawing.Point(3, 632)
        Me.pnlEditorControls.Name = "pnlEditorControls"
        Me.pnlEditorControls.RowCount = 1
        Me.pnlEditorControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlEditorControls.Size = New System.Drawing.Size(780, 28)
        Me.pnlEditorControls.TabIndex = 0
        '
        'btnRun
        '
        Me.btnRun.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRun.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRun.Location = New System.Drawing.Point(702, 3)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(75, 22)
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
        Me.txtIndependentVars.Size = New System.Drawing.Size(693, 22)
        Me.txtIndependentVars.TabIndex = 1
        '
        'pnlOutputMain
        '
        Me.pnlOutputMain.ColumnCount = 1
        Me.pnlOutputMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlOutputMain.Controls.Add(Me.pnlOutputControls, 0, 1)
        Me.pnlOutputMain.Controls.Add(Me.rteOutput, 0, 0)
        Me.pnlOutputMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOutputMain.Location = New System.Drawing.Point(3, 3)
        Me.pnlOutputMain.Name = "pnlOutputMain"
        Me.pnlOutputMain.RowCount = 2
        Me.pnlOutputMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.0!))
        Me.pnlOutputMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.pnlOutputMain.Size = New System.Drawing.Size(786, 663)
        Me.pnlOutputMain.TabIndex = 1
        '
        'pnlOutputControls
        '
        Me.pnlOutputControls.ColumnCount = 2
        Me.pnlOutputControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlOutputControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.pnlOutputControls.Controls.Add(Me.btnTick, 1, 0)
        Me.pnlOutputControls.Controls.Add(Me.udTickCount, 0, 0)
        Me.pnlOutputControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOutputControls.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlOutputControls.Location = New System.Drawing.Point(3, 632)
        Me.pnlOutputControls.Name = "pnlOutputControls"
        Me.pnlOutputControls.RowCount = 1
        Me.pnlOutputControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlOutputControls.Size = New System.Drawing.Size(780, 28)
        Me.pnlOutputControls.TabIndex = 0
        '
        'btnTick
        '
        Me.btnTick.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnTick.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTick.Location = New System.Drawing.Point(702, 3)
        Me.btnTick.Name = "btnTick"
        Me.btnTick.Size = New System.Drawing.Size(75, 22)
        Me.btnTick.TabIndex = 0
        Me.btnTick.Text = "Tick"
        Me.btnTick.UseVisualStyleBackColor = True
        '
        'udTickCount
        '
        Me.udTickCount.Dock = System.Windows.Forms.DockStyle.Right
        Me.udTickCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udTickCount.Location = New System.Drawing.Point(652, 3)
        Me.udTickCount.Name = "udTickCount"
        Me.udTickCount.Size = New System.Drawing.Size(44, 22)
        Me.udTickCount.TabIndex = 1
        '
        'rteOutput
        '
        Me.rteOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rteOutput.Location = New System.Drawing.Point(3, 3)
        Me.rteOutput.Name = "rteOutput"
        Me.rteOutput.Size = New System.Drawing.Size(780, 623)
        Me.rteOutput.TabIndex = 1
        Me.rteOutput.Text = ""
        '
        'rteEditor
        '
        Me.rteEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rteEditor.Location = New System.Drawing.Point(0, 3)
        Me.rteEditor.Name = "rteEditor"
        Me.rteEditor.Size = New System.Drawing.Size(783, 626)
        Me.rteEditor.TabIndex = 1
        Me.rteEditor.Text = ""
        '
        'ctlSplitTabbed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "ctlSplitTabbed"
        Me.Size = New System.Drawing.Size(800, 700)
        Me.Tag = "Tabbed"
        Me.TabControl1.ResumeLayout(False)
        Me.tabEditor.ResumeLayout(False)
        Me.tabOutput.ResumeLayout(False)
        Me.pnlEditorMain.ResumeLayout(False)
        Me.pnlEditorControls.ResumeLayout(False)
        Me.pnlEditorControls.PerformLayout()
        Me.pnlOutputMain.ResumeLayout(False)
        Me.pnlOutputControls.ResumeLayout(False)
        CType(Me.udTickCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabEditor As System.Windows.Forms.TabPage
    Friend WithEvents pnlEditorMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlEditorControls As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents tabOutput As System.Windows.Forms.TabPage
    Friend WithEvents txtIndependentVars As System.Windows.Forms.TextBox
    Friend WithEvents pnlOutputMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlOutputControls As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnTick As System.Windows.Forms.Button
    Friend WithEvents udTickCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents rteEditor As System.Windows.Forms.RichTextBox
    Friend WithEvents rteOutput As System.Windows.Forms.RichTextBox

End Class

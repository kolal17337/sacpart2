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
        Me.btn_calculate = New System.Windows.Forms.Button()
        Me.lbl_read = New System.Windows.Forms.Label()
        Me.lbl_engmarks = New System.Windows.Forms.Label()
        Me.lbl_mathsmarks = New System.Windows.Forms.Label()
        Me.lbl_pemarks = New System.Windows.Forms.Label()
        Me.lbl_engavg = New System.Windows.Forms.Label()
        Me.lbl_mathavg = New System.Windows.Forms.Label()
        Me.lbl_peavg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_calculate
        '
        Me.btn_calculate.Location = New System.Drawing.Point(55, 40)
        Me.btn_calculate.Name = "btn_calculate"
        Me.btn_calculate.Size = New System.Drawing.Size(234, 139)
        Me.btn_calculate.TabIndex = 0
        Me.btn_calculate.Text = "click to calculate average"
        Me.btn_calculate.UseVisualStyleBackColor = True
        '
        'lbl_read
        '
        Me.lbl_read.AutoSize = True
        Me.lbl_read.Location = New System.Drawing.Point(52, 195)
        Me.lbl_read.Name = "lbl_read"
        Me.lbl_read.Size = New System.Drawing.Size(39, 13)
        Me.lbl_read.TabIndex = 1
        Me.lbl_read.Text = "Label1"
        '
        'lbl_engmarks
        '
        Me.lbl_engmarks.AutoSize = True
        Me.lbl_engmarks.Location = New System.Drawing.Point(52, 232)
        Me.lbl_engmarks.Name = "lbl_engmarks"
        Me.lbl_engmarks.Size = New System.Drawing.Size(39, 13)
        Me.lbl_engmarks.TabIndex = 2
        Me.lbl_engmarks.Text = "Label2"
        '
        'lbl_mathsmarks
        '
        Me.lbl_mathsmarks.AutoSize = True
        Me.lbl_mathsmarks.Location = New System.Drawing.Point(52, 275)
        Me.lbl_mathsmarks.Name = "lbl_mathsmarks"
        Me.lbl_mathsmarks.Size = New System.Drawing.Size(39, 13)
        Me.lbl_mathsmarks.TabIndex = 3
        Me.lbl_mathsmarks.Text = "Label3"
        '
        'lbl_pemarks
        '
        Me.lbl_pemarks.AutoSize = True
        Me.lbl_pemarks.Location = New System.Drawing.Point(52, 320)
        Me.lbl_pemarks.Name = "lbl_pemarks"
        Me.lbl_pemarks.Size = New System.Drawing.Size(39, 13)
        Me.lbl_pemarks.TabIndex = 4
        Me.lbl_pemarks.Text = "Label4"
        '
        'lbl_engavg
        '
        Me.lbl_engavg.AutoSize = True
        Me.lbl_engavg.Location = New System.Drawing.Point(334, 40)
        Me.lbl_engavg.Name = "lbl_engavg"
        Me.lbl_engavg.Size = New System.Drawing.Size(39, 13)
        Me.lbl_engavg.TabIndex = 5
        Me.lbl_engavg.Text = "Label5"
        '
        'lbl_mathavg
        '
        Me.lbl_mathavg.AutoSize = True
        Me.lbl_mathavg.Location = New System.Drawing.Point(334, 77)
        Me.lbl_mathavg.Name = "lbl_mathavg"
        Me.lbl_mathavg.Size = New System.Drawing.Size(39, 13)
        Me.lbl_mathavg.TabIndex = 6
        Me.lbl_mathavg.Text = "Label6"
        '
        'lbl_peavg
        '
        Me.lbl_peavg.AutoSize = True
        Me.lbl_peavg.Location = New System.Drawing.Point(334, 123)
        Me.lbl_peavg.Name = "lbl_peavg"
        Me.lbl_peavg.Size = New System.Drawing.Size(39, 13)
        Me.lbl_peavg.TabIndex = 7
        Me.lbl_peavg.Text = "Label7"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_peavg)
        Me.Controls.Add(Me.lbl_mathavg)
        Me.Controls.Add(Me.lbl_engavg)
        Me.Controls.Add(Me.lbl_pemarks)
        Me.Controls.Add(Me.lbl_mathsmarks)
        Me.Controls.Add(Me.lbl_engmarks)
        Me.Controls.Add(Me.lbl_read)
        Me.Controls.Add(Me.btn_calculate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_calculate As Button
    Friend WithEvents lbl_read As Label
    Friend WithEvents lbl_engmarks As Label
    Friend WithEvents lbl_mathsmarks As Label
    Friend WithEvents lbl_pemarks As Label
    Friend WithEvents lbl_engavg As Label
    Friend WithEvents lbl_mathavg As Label
    Friend WithEvents lbl_peavg As Label
End Class

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
        Me.btnRead = New System.Windows.Forms.Button()
        Me.lbl_read = New System.Windows.Forms.Label()
        Me.lbl_engmarks = New System.Windows.Forms.Label()
        Me.lbl_mathsmarks = New System.Windows.Forms.Label()
        Me.lbl_pemarks = New System.Windows.Forms.Label()
        Me.lblNames = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(55, 40)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(234, 139)
        Me.btnRead.TabIndex = 0
        Me.btnRead.Text = "click to read file"
        Me.btnRead.UseVisualStyleBackColor = True
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
        Me.lbl_engmarks.Location = New System.Drawing.Point(52, 287)
        Me.lbl_engmarks.Name = "lbl_engmarks"
        Me.lbl_engmarks.Size = New System.Drawing.Size(39, 13)
        Me.lbl_engmarks.TabIndex = 2
        Me.lbl_engmarks.Text = "Label2"
        '
        'lbl_mathsmarks
        '
        Me.lbl_mathsmarks.AutoSize = True
        Me.lbl_mathsmarks.Location = New System.Drawing.Point(52, 330)
        Me.lbl_mathsmarks.Name = "lbl_mathsmarks"
        Me.lbl_mathsmarks.Size = New System.Drawing.Size(39, 13)
        Me.lbl_mathsmarks.TabIndex = 3
        Me.lbl_mathsmarks.Text = "Label3"
        '
        'lbl_pemarks
        '
        Me.lbl_pemarks.AutoSize = True
        Me.lbl_pemarks.Location = New System.Drawing.Point(52, 375)
        Me.lbl_pemarks.Name = "lbl_pemarks"
        Me.lbl_pemarks.Size = New System.Drawing.Size(39, 13)
        Me.lbl_pemarks.TabIndex = 4
        Me.lbl_pemarks.Text = "Label4"
        '
        'lblNames
        '
        Me.lblNames.AutoSize = True
        Me.lblNames.Location = New System.Drawing.Point(52, 247)
        Me.lblNames.Name = "lblNames"
        Me.lblNames.Size = New System.Drawing.Size(39, 13)
        Me.lblNames.TabIndex = 5
        Me.lblNames.Text = "Label1"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(327, 60)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(291, 98)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "click to search for a student name"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblNames)
        Me.Controls.Add(Me.lbl_pemarks)
        Me.Controls.Add(Me.lbl_mathsmarks)
        Me.Controls.Add(Me.lbl_engmarks)
        Me.Controls.Add(Me.lbl_read)
        Me.Controls.Add(Me.btnRead)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRead As Button
    Friend WithEvents lbl_read As Label
    Friend WithEvents lbl_engmarks As Label
    Friend WithEvents lbl_mathsmarks As Label
    Friend WithEvents lbl_pemarks As Label
    Friend WithEvents lblNames As Label
    Friend WithEvents btnSearch As Button
End Class

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
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.radTrainee = New System.Windows.Forms.RadioButton()
        Me.radWorker = New System.Windows.Forms.RadioButton()
        Me.radManager = New System.Windows.Forms.RadioButton()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.lblPay = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(210, 64)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(100, 20)
        Me.txtHours.TabIndex = 0
        '
        'radTrainee
        '
        Me.radTrainee.AutoSize = True
        Me.radTrainee.Location = New System.Drawing.Point(42, 195)
        Me.radTrainee.Name = "radTrainee"
        Me.radTrainee.Size = New System.Drawing.Size(61, 17)
        Me.radTrainee.TabIndex = 1
        Me.radTrainee.TabStop = True
        Me.radTrainee.Text = "Trainee"
        Me.radTrainee.UseVisualStyleBackColor = True
        '
        'radWorker
        '
        Me.radWorker.AutoSize = True
        Me.radWorker.Location = New System.Drawing.Point(165, 195)
        Me.radWorker.Name = "radWorker"
        Me.radWorker.Size = New System.Drawing.Size(60, 17)
        Me.radWorker.TabIndex = 2
        Me.radWorker.TabStop = True
        Me.radWorker.Text = "Worker"
        Me.radWorker.UseVisualStyleBackColor = True
        '
        'radManager
        '
        Me.radManager.AutoSize = True
        Me.radManager.Location = New System.Drawing.Point(287, 195)
        Me.radManager.Name = "radManager"
        Me.radManager.Size = New System.Drawing.Size(67, 17)
        Me.radManager.TabIndex = 3
        Me.radManager.TabStop = True
        Me.radManager.Text = "Manager"
        Me.radManager.UseVisualStyleBackColor = True
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(64, 341)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(75, 23)
        Me.btnPay.TabIndex = 4
        Me.btnPay.Text = "Your Pay"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'lblPay
        '
        Me.lblPay.AutoSize = True
        Me.lblPay.Location = New System.Drawing.Point(249, 346)
        Me.lblPay.Name = "lblPay"
        Me.lblPay.Size = New System.Drawing.Size(83, 13)
        Me.lblPay.TabIndex = 5
        Me.lblPay.Text = "Your Pay: $0.00"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(86, 64)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(76, 13)
        Me.lblHours.TabIndex = 6
        Me.lblHours.Text = "Hours Worked"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 450)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblPay)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.radManager)
        Me.Controls.Add(Me.radWorker)
        Me.Controls.Add(Me.radTrainee)
        Me.Controls.Add(Me.txtHours)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents radTrainee As System.Windows.Forms.RadioButton
    Friend WithEvents radWorker As System.Windows.Forms.RadioButton
    Friend WithEvents radManager As System.Windows.Forms.RadioButton
    Friend WithEvents btnPay As System.Windows.Forms.Button
    Friend WithEvents lblPay As System.Windows.Forms.Label
    Friend WithEvents lblHours As System.Windows.Forms.Label

End Class

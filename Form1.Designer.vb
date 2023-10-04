<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblHeight = New Label()
        txtHeight = New TextBox()
        lblWeight = New Label()
        txtWeight = New TextBox()
        lblBMI = New Label()
        txtBMI = New TextBox()
        lblComment = New Label()
        txtComment = New TextBox()
        btnCalculate = New Button()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' lblHeight
        ' 
        lblHeight.AutoSize = True
        lblHeight.Location = New Point(222, 74)
        lblHeight.Name = "lblHeight"
        lblHeight.Size = New Size(54, 20)
        lblHeight.TabIndex = 0
        lblHeight.Text = "Height"
        ' 
        ' txtHeight
        ' 
        txtHeight.Location = New Point(423, 71)
        txtHeight.Name = "txtHeight"
        txtHeight.Size = New Size(158, 27)
        txtHeight.TabIndex = 1
        ' 
        ' lblWeight
        ' 
        lblWeight.AutoSize = True
        lblWeight.Location = New Point(222, 128)
        lblWeight.Name = "lblWeight"
        lblWeight.Size = New Size(56, 20)
        lblWeight.TabIndex = 0
        lblWeight.Text = "Weight"
        ' 
        ' txtWeight
        ' 
        txtWeight.Location = New Point(423, 125)
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(158, 27)
        txtWeight.TabIndex = 1
        ' 
        ' lblBMI
        ' 
        lblBMI.AutoSize = True
        lblBMI.Location = New Point(222, 182)
        lblBMI.Name = "lblBMI"
        lblBMI.Size = New Size(86, 20)
        lblBMI.TabIndex = 0
        lblBMI.Text = "Your BMI is "
        ' 
        ' txtBMI
        ' 
        txtBMI.Location = New Point(423, 179)
        txtBMI.Name = "txtBMI"
        txtBMI.Size = New Size(158, 27)
        txtBMI.TabIndex = 1
        ' 
        ' lblComment
        ' 
        lblComment.AutoSize = True
        lblComment.Location = New Point(222, 237)
        lblComment.Name = "lblComment"
        lblComment.Size = New Size(74, 20)
        lblComment.TabIndex = 0
        lblComment.Text = "Comment"
        ' 
        ' txtComment
        ' 
        txtComment.Location = New Point(423, 234)
        txtComment.Name = "txtComment"
        txtComment.Size = New Size(266, 27)
        txtComment.TabIndex = 1
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(258, 334)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(94, 29)
        btnCalculate.TabIndex = 2
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(454, 334)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 29)
        btnClose.TabIndex = 2
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btnClose)
        Controls.Add(btnCalculate)
        Controls.Add(txtComment)
        Controls.Add(lblComment)
        Controls.Add(txtBMI)
        Controls.Add(lblBMI)
        Controls.Add(txtWeight)
        Controls.Add(lblWeight)
        Controls.Add(txtHeight)
        Controls.Add(lblHeight)
        Name = "Form1"
        Text = "BMI Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeight As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents lblWeight As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents lblBMI As Label
    Friend WithEvents txtBMI As TextBox
    Friend WithEvents lblComment As Label
    Friend WithEvents txtComment As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClose As Button
End Class

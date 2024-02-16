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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(589, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(144, 149)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(481, 185)
        txtUsername.Multiline = True
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Email Adress"
        txtUsername.Size = New Size(367, 53)
        txtUsername.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(481, 268)
        txtPassword.Multiline = True
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Password"
        txtPassword.Size = New Size(367, 54)
        txtPassword.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(481, 364)
        Button1.Name = "Button1"
        Button1.Size = New Size(367, 34)
        Button1.TabIndex = 3
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Wheat
        ClientSize = New Size(1257, 697)
        Controls.Add(Button1)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button

End Class

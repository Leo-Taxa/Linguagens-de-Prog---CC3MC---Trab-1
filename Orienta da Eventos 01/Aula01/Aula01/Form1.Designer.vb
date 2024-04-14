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
        Label1 = New Label()
        txtnome = New TextBox()
        btnok = New Button()
        btnSair = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AccessibleName = "lblname"
        Label1.AutoSize = True
        Label1.Location = New Point(11, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 15)
        Label1.TabIndex = 0
        Label1.Text = "Coloque seu nome"
        ' 
        ' txtnome
        ' 
        txtnome.AccessibleName = "txtnome"
        txtnome.Location = New Point(11, 28)
        txtnome.Name = "txtnome"
        txtnome.Size = New Size(314, 23)
        txtnome.TabIndex = 1
        ' 
        ' btnok
        ' 
        btnok.AccessibleName = "btnok"
        btnok.Location = New Point(43, 137)
        btnok.Name = "btnok"
        btnok.Size = New Size(75, 23)
        btnok.TabIndex = 2
        btnok.Text = "&OK"
        btnok.UseVisualStyleBackColor = True
        ' 
        ' btnSair
        ' 
        btnSair.Location = New Point(214, 137)
        btnSair.Name = "btnSair"
        btnSair.Size = New Size(75, 23)
        btnSair.TabIndex = 3
        btnSair.Text = "S&air"
        btnSair.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(337, 177)
        Controls.Add(btnSair)
        Controls.Add(btnok)
        Controls.Add(txtnome)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Hello World"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtnome As TextBox
    Friend WithEvents btnok As Button
    Friend WithEvents btnSair As Button

End Class

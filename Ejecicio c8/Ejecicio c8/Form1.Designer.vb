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
        btEjecutar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lblMostrarMayor = New Label()
        lblMostrarMenor = New Label()
        lblMostrarSuma = New Label()
        SuspendLayout()
        ' 
        ' btEjecutar
        ' 
        btEjecutar.Location = New Point(288, 77)
        btEjecutar.Name = "btEjecutar"
        btEjecutar.Size = New Size(185, 68)
        btEjecutar.TabIndex = 0
        btEjecutar.Text = "Ejecutar"
        btEjecutar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(116, 193)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 20)
        Label1.TabIndex = 1
        Label1.Text = "El numero mayor es:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(303, 193)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 20)
        Label2.TabIndex = 2
        Label2.Text = "El numero menor es:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(490, 198)
        Label3.Name = "Label3"
        Label3.Size = New Size(184, 20)
        Label3.TabIndex = 3
        Label3.Text = "El resultado de la suma es:"
        ' 
        ' lblMostrarMayor
        ' 
        lblMostrarMayor.AutoSize = True
        lblMostrarMayor.Location = New Point(170, 230)
        lblMostrarMayor.Name = "lblMostrarMayor"
        lblMostrarMayor.Size = New Size(0, 20)
        lblMostrarMayor.TabIndex = 4
        ' 
        ' lblMostrarMenor
        ' 
        lblMostrarMenor.AutoSize = True
        lblMostrarMenor.Location = New Point(360, 230)
        lblMostrarMenor.Name = "lblMostrarMenor"
        lblMostrarMenor.Size = New Size(0, 20)
        lblMostrarMenor.TabIndex = 5
        ' 
        ' lblMostrarSuma
        ' 
        lblMostrarSuma.AutoSize = True
        lblMostrarSuma.Location = New Point(565, 230)
        lblMostrarSuma.Name = "lblMostrarSuma"
        lblMostrarSuma.Size = New Size(0, 20)
        lblMostrarSuma.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblMostrarSuma)
        Controls.Add(lblMostrarMenor)
        Controls.Add(lblMostrarMayor)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btEjecutar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btEjecutar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMostrarMayor As Label
    Friend WithEvents lblMostrarMenor As Label
    Friend WithEvents lblMostrarSuma As Label
End Class

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
        components = New ComponentModel.Container()
        Btn_Iniciar = New Button()
        Tmr_nave = New Timer(components)
        SuspendLayout()
        ' 
        ' Btn_Iniciar
        ' 
        Btn_Iniciar.Location = New Point(897, 12)
        Btn_Iniciar.Name = "Btn_Iniciar"
        Btn_Iniciar.Size = New Size(75, 23)
        Btn_Iniciar.TabIndex = 0
        Btn_Iniciar.Text = "Iniciar"
        Btn_Iniciar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(984, 561)
        Controls.Add(Btn_Iniciar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Btn_Iniciar As Button
    Friend WithEvents Tmr_nave As Timer
End Class

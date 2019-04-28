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
        Me.components = New System.ComponentModel.Container()
        Me.LigarBtn = New System.Windows.Forms.Button()
        Me.DesligarBtn = New System.Windows.Forms.Button()
        Me.Y0_Chk = New System.Windows.Forms.CheckBox()
        Me.Y2_Chk = New System.Windows.Forms.CheckBox()
        Me.Y1_Chk = New System.Windows.Forms.CheckBox()
        Me.X1_Chk = New System.Windows.Forms.CheckBox()
        Me.X2_Chk = New System.Windows.Forms.CheckBox()
        Me.X0_Chk = New System.Windows.Forms.CheckBox()
        Me.X3_Chk = New System.Windows.Forms.CheckBox()
        Me.enviar_checkboxes_Btn = New System.Windows.Forms.Button()
        Me.velocidade_box = New System.Windows.Forms.TextBox()
        Me.estado_connecao_box = New System.Windows.Forms.TextBox()
        Me.velocidade_lida_box = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TimerReceive = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LigarBtn
        '
        Me.LigarBtn.Location = New System.Drawing.Point(12, 12)
        Me.LigarBtn.Name = "LigarBtn"
        Me.LigarBtn.Size = New System.Drawing.Size(145, 46)
        Me.LigarBtn.TabIndex = 0
        Me.LigarBtn.Text = "Ligar a 127.0.0.1"
        Me.LigarBtn.UseVisualStyleBackColor = True
        '
        'DesligarBtn
        '
        Me.DesligarBtn.Location = New System.Drawing.Point(12, 64)
        Me.DesligarBtn.Name = "DesligarBtn"
        Me.DesligarBtn.Size = New System.Drawing.Size(145, 46)
        Me.DesligarBtn.TabIndex = 1
        Me.DesligarBtn.Text = "Desligar 127.0.0.1"
        Me.DesligarBtn.UseVisualStyleBackColor = True
        '
        'Y0_Chk
        '
        Me.Y0_Chk.AutoSize = True
        Me.Y0_Chk.Location = New System.Drawing.Point(213, 13)
        Me.Y0_Chk.Name = "Y0_Chk"
        Me.Y0_Chk.Size = New System.Drawing.Size(39, 17)
        Me.Y0_Chk.TabIndex = 2
        Me.Y0_Chk.Text = "Y0"
        Me.Y0_Chk.UseVisualStyleBackColor = True
        '
        'Y2_Chk
        '
        Me.Y2_Chk.AutoSize = True
        Me.Y2_Chk.Location = New System.Drawing.Point(213, 59)
        Me.Y2_Chk.Name = "Y2_Chk"
        Me.Y2_Chk.Size = New System.Drawing.Size(39, 17)
        Me.Y2_Chk.TabIndex = 3
        Me.Y2_Chk.Text = "Y2"
        Me.Y2_Chk.UseVisualStyleBackColor = True
        '
        'Y1_Chk
        '
        Me.Y1_Chk.AutoSize = True
        Me.Y1_Chk.Location = New System.Drawing.Point(213, 36)
        Me.Y1_Chk.Name = "Y1_Chk"
        Me.Y1_Chk.Size = New System.Drawing.Size(39, 17)
        Me.Y1_Chk.TabIndex = 4
        Me.Y1_Chk.Text = "Y1"
        Me.Y1_Chk.UseVisualStyleBackColor = True
        '
        'X1_Chk
        '
        Me.X1_Chk.AutoSize = True
        Me.X1_Chk.Location = New System.Drawing.Point(61, 192)
        Me.X1_Chk.Name = "X1_Chk"
        Me.X1_Chk.Size = New System.Drawing.Size(39, 17)
        Me.X1_Chk.TabIndex = 7
        Me.X1_Chk.Text = "X1"
        Me.X1_Chk.UseVisualStyleBackColor = True
        '
        'X2_Chk
        '
        Me.X2_Chk.AutoSize = True
        Me.X2_Chk.Location = New System.Drawing.Point(61, 215)
        Me.X2_Chk.Name = "X2_Chk"
        Me.X2_Chk.Size = New System.Drawing.Size(39, 17)
        Me.X2_Chk.TabIndex = 6
        Me.X2_Chk.Text = "X2"
        Me.X2_Chk.UseVisualStyleBackColor = True
        '
        'X0_Chk
        '
        Me.X0_Chk.AutoSize = True
        Me.X0_Chk.Location = New System.Drawing.Point(61, 169)
        Me.X0_Chk.Name = "X0_Chk"
        Me.X0_Chk.Size = New System.Drawing.Size(39, 17)
        Me.X0_Chk.TabIndex = 5
        Me.X0_Chk.Text = "X0"
        Me.X0_Chk.UseVisualStyleBackColor = True
        '
        'X3_Chk
        '
        Me.X3_Chk.AutoSize = True
        Me.X3_Chk.Location = New System.Drawing.Point(61, 238)
        Me.X3_Chk.Name = "X3_Chk"
        Me.X3_Chk.Size = New System.Drawing.Size(39, 17)
        Me.X3_Chk.TabIndex = 8
        Me.X3_Chk.Text = "X3"
        Me.X3_Chk.UseVisualStyleBackColor = True
        '
        'enviar_checkboxes_Btn
        '
        Me.enviar_checkboxes_Btn.Location = New System.Drawing.Point(246, 91)
        Me.enviar_checkboxes_Btn.Name = "enviar_checkboxes_Btn"
        Me.enviar_checkboxes_Btn.Size = New System.Drawing.Size(145, 29)
        Me.enviar_checkboxes_Btn.TabIndex = 9
        Me.enviar_checkboxes_Btn.Text = "Enviar CheckBoxes"
        Me.enviar_checkboxes_Btn.UseVisualStyleBackColor = True
        '
        'velocidade_box
        '
        Me.velocidade_box.Location = New System.Drawing.Point(289, 59)
        Me.velocidade_box.Name = "velocidade_box"
        Me.velocidade_box.Size = New System.Drawing.Size(100, 20)
        Me.velocidade_box.TabIndex = 10
        Me.velocidade_box.Text = "0"
        '
        'estado_connecao_box
        '
        Me.estado_connecao_box.Location = New System.Drawing.Point(12, 133)
        Me.estado_connecao_box.Name = "estado_connecao_box"
        Me.estado_connecao_box.Size = New System.Drawing.Size(377, 20)
        Me.estado_connecao_box.TabIndex = 11
        '
        'velocidade_lida_box
        '
        Me.velocidade_lida_box.Location = New System.Drawing.Point(169, 215)
        Me.velocidade_lida_box.Name = "velocidade_lida_box"
        Me.velocidade_lida_box.Size = New System.Drawing.Size(83, 20)
        Me.velocidade_lida_box.TabIndex = 12
        Me.velocidade_lida_box.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(169, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Velocidade do motor lida"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(285, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Velocidade do motor"
        '
        'TimerReceive
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.velocidade_lida_box)
        Me.Controls.Add(Me.estado_connecao_box)
        Me.Controls.Add(Me.velocidade_box)
        Me.Controls.Add(Me.enviar_checkboxes_Btn)
        Me.Controls.Add(Me.X3_Chk)
        Me.Controls.Add(Me.X1_Chk)
        Me.Controls.Add(Me.X2_Chk)
        Me.Controls.Add(Me.X0_Chk)
        Me.Controls.Add(Me.Y1_Chk)
        Me.Controls.Add(Me.Y2_Chk)
        Me.Controls.Add(Me.Y0_Chk)
        Me.Controls.Add(Me.DesligarBtn)
        Me.Controls.Add(Me.LigarBtn)
        Me.Name = "Form1"
        Me.Text = "TCP_IP_Client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LigarBtn As Button
    Friend WithEvents DesligarBtn As Button
    Friend WithEvents Y0_Chk As CheckBox
    Friend WithEvents Y2_Chk As CheckBox
    Friend WithEvents Y1_Chk As CheckBox
    Friend WithEvents X1_Chk As CheckBox
    Friend WithEvents X2_Chk As CheckBox
    Friend WithEvents X0_Chk As CheckBox
    Friend WithEvents X3_Chk As CheckBox
    Friend WithEvents enviar_checkboxes_Btn As Button
    Friend WithEvents velocidade_box As TextBox
    Friend WithEvents estado_connecao_box As TextBox
    Friend WithEvents velocidade_lida_box As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TimerReceive As Timer
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calor_Autor
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
        Me.Panel_calor_autor = New System.Windows.Forms.Panel()
        Me.Cmb_calor_autor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_MostrarEcuacion_Autores = New System.Windows.Forms.Panel()
        Me.Foto_Ecuacion = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel_calor_autor.SuspendLayout()
        Me.Panel_MostrarEcuacion_Autores.SuspendLayout()
        CType(Me.Foto_Ecuacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_calor_autor
        '
        Me.Panel_calor_autor.Controls.Add(Me.Cmb_calor_autor)
        Me.Panel_calor_autor.Controls.Add(Me.Label1)
        Me.Panel_calor_autor.Location = New System.Drawing.Point(22, 22)
        Me.Panel_calor_autor.Name = "Panel_calor_autor"
        Me.Panel_calor_autor.Size = New System.Drawing.Size(581, 63)
        Me.Panel_calor_autor.TabIndex = 3
        '
        'Cmb_calor_autor
        '
        Me.Cmb_calor_autor.FormattingEnabled = True
        Me.Cmb_calor_autor.Items.AddRange(New Object() {"Choi - Okos (1986)"})
        Me.Cmb_calor_autor.Location = New System.Drawing.Point(77, 27)
        Me.Cmb_calor_autor.Name = "Cmb_calor_autor"
        Me.Cmb_calor_autor.Size = New System.Drawing.Size(304, 21)
        Me.Cmb_calor_autor.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Escoja el autor deseado"
        '
        'Panel_MostrarEcuacion_Autores
        '
        Me.Panel_MostrarEcuacion_Autores.Controls.Add(Me.Foto_Ecuacion)
        Me.Panel_MostrarEcuacion_Autores.Location = New System.Drawing.Point(23, 103)
        Me.Panel_MostrarEcuacion_Autores.Name = "Panel_MostrarEcuacion_Autores"
        Me.Panel_MostrarEcuacion_Autores.Size = New System.Drawing.Size(580, 226)
        Me.Panel_MostrarEcuacion_Autores.TabIndex = 4
        '
        'Foto_Ecuacion
        '
        Me.Foto_Ecuacion.Location = New System.Drawing.Point(31, 19)
        Me.Foto_Ecuacion.Name = "Foto_Ecuacion"
        Me.Foto_Ecuacion.Size = New System.Drawing.Size(512, 154)
        Me.Foto_Ecuacion.TabIndex = 0
        Me.Foto_Ecuacion.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(491, 345)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 29)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Calor_Autor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 386)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel_MostrarEcuacion_Autores)
        Me.Controls.Add(Me.Panel_calor_autor)
        Me.Name = "Calor_Autor"
        Me.Text = "Calor_Autor"
        Me.Panel_calor_autor.ResumeLayout(False)
        Me.Panel_calor_autor.PerformLayout()
        Me.Panel_MostrarEcuacion_Autores.ResumeLayout(False)
        CType(Me.Foto_Ecuacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_calor_autor As Panel
    Friend WithEvents Cmb_calor_autor As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel_MostrarEcuacion_Autores As Panel
    Friend WithEvents Foto_Ecuacion As PictureBox
    Friend WithEvents Button1 As Button
End Class
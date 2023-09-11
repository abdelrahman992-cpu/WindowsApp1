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
        Me.chicken = New System.Windows.Forms.CheckBox()
        Me.salad = New System.Windows.Forms.CheckBox()
        Me.drink = New System.Windows.Forms.CheckBox()
        Me.menu1 = New System.Windows.Forms.GroupBox()
        Me.menu2 = New System.Windows.Forms.GroupBox()
        Me.chicken2 = New System.Windows.Forms.RadioButton()
        Me.chicken1 = New System.Windows.Forms.RadioButton()
        Me.menu4 = New System.Windows.Forms.GroupBox()
        Me.drink4 = New System.Windows.Forms.RadioButton()
        Me.drink3 = New System.Windows.Forms.RadioButton()
        Me.drink2 = New System.Windows.Forms.RadioButton()
        Me.drink1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.menu3 = New System.Windows.Forms.GroupBox()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.salad1 = New System.Windows.Forms.CheckBox()
        Me.salad2 = New System.Windows.Forms.CheckBox()
        Me.menu1.SuspendLayout()
        Me.menu2.SuspendLayout()
        Me.menu4.SuspendLayout()
        Me.menu3.SuspendLayout()
        Me.SuspendLayout()
        '
        'chicken
        '
        Me.chicken.AutoSize = True
        Me.chicken.Location = New System.Drawing.Point(30, 51)
        Me.chicken.Name = "chicken"
        Me.chicken.Size = New System.Drawing.Size(65, 17)
        Me.chicken.TabIndex = 0
        Me.chicken.Text = "Chicken"
        Me.chicken.UseVisualStyleBackColor = True
        '
        'salad
        '
        Me.salad.AutoSize = True
        Me.salad.Location = New System.Drawing.Point(30, 101)
        Me.salad.Name = "salad"
        Me.salad.Size = New System.Drawing.Size(53, 17)
        Me.salad.TabIndex = 1
        Me.salad.Text = "Salad"
        Me.salad.UseVisualStyleBackColor = True
        '
        'drink
        '
        Me.drink.AutoSize = True
        Me.drink.Location = New System.Drawing.Point(30, 148)
        Me.drink.Name = "drink"
        Me.drink.Size = New System.Drawing.Size(49, 17)
        Me.drink.TabIndex = 2
        Me.drink.Text = "drink"
        Me.drink.UseVisualStyleBackColor = True
        '
        'menu1
        '
        Me.menu1.Controls.Add(Me.chicken)
        Me.menu1.Controls.Add(Me.drink)
        Me.menu1.Controls.Add(Me.salad)
        Me.menu1.Location = New System.Drawing.Point(30, 28)
        Me.menu1.Name = "menu1"
        Me.menu1.Size = New System.Drawing.Size(200, 390)
        Me.menu1.TabIndex = 3
        Me.menu1.TabStop = False
        Me.menu1.Text = "Main Menu"
        '
        'menu2
        '
        Me.menu2.Controls.Add(Me.chicken2)
        Me.menu2.Controls.Add(Me.chicken1)
        Me.menu2.Location = New System.Drawing.Point(247, 28)
        Me.menu2.Name = "menu2"
        Me.menu2.Size = New System.Drawing.Size(200, 100)
        Me.menu2.TabIndex = 4
        Me.menu2.TabStop = False
        Me.menu2.Text = "Chicken"
        '
        'chicken2
        '
        Me.chicken2.AutoSize = True
        Me.chicken2.Location = New System.Drawing.Point(41, 51)
        Me.chicken2.Name = "chicken2"
        Me.chicken2.Size = New System.Drawing.Size(48, 17)
        Me.chicken2.TabIndex = 1
        Me.chicken2.TabStop = True
        Me.chicken2.Text = "Fried"
        Me.chicken2.UseVisualStyleBackColor = True
        '
        'chicken1
        '
        Me.chicken1.AutoSize = True
        Me.chicken1.Location = New System.Drawing.Point(41, 20)
        Me.chicken1.Name = "chicken1"
        Me.chicken1.Size = New System.Drawing.Size(54, 17)
        Me.chicken1.TabIndex = 0
        Me.chicken1.TabStop = True
        Me.chicken1.Text = "Grilled"
        Me.chicken1.UseVisualStyleBackColor = True
        '
        'menu4
        '
        Me.menu4.Controls.Add(Me.drink4)
        Me.menu4.Controls.Add(Me.drink3)
        Me.menu4.Controls.Add(Me.drink2)
        Me.menu4.Controls.Add(Me.drink1)
        Me.menu4.Location = New System.Drawing.Point(247, 282)
        Me.menu4.Name = "menu4"
        Me.menu4.Size = New System.Drawing.Size(200, 136)
        Me.menu4.TabIndex = 6
        Me.menu4.TabStop = False
        Me.menu4.Text = "Drink Choice"
        '
        'drink4
        '
        Me.drink4.AutoSize = True
        Me.drink4.Location = New System.Drawing.Point(24, 92)
        Me.drink4.Name = "drink4"
        Me.drink4.Size = New System.Drawing.Size(79, 17)
        Me.drink4.TabIndex = 3
        Me.drink4.TabStop = True
        Me.drink4.Text = "Fresh Juice"
        Me.drink4.UseVisualStyleBackColor = True
        '
        'drink3
        '
        Me.drink3.AutoSize = True
        Me.drink3.Location = New System.Drawing.Point(24, 68)
        Me.drink3.Name = "drink3"
        Me.drink3.Size = New System.Drawing.Size(72, 17)
        Me.drink3.TabIndex = 2
        Me.drink3.TabStop = True
        Me.drink3.Text = "Soft Drink"
        Me.drink3.UseVisualStyleBackColor = True
        '
        'drink2
        '
        Me.drink2.AutoSize = True
        Me.drink2.Location = New System.Drawing.Point(24, 44)
        Me.drink2.Name = "drink2"
        Me.drink2.Size = New System.Drawing.Size(70, 17)
        Me.drink2.TabIndex = 1
        Me.drink2.TabStop = True
        Me.drink2.Text = "Hot Drink"
        Me.drink2.UseVisualStyleBackColor = True
        '
        'drink1
        '
        Me.drink1.AutoSize = True
        Me.drink1.Location = New System.Drawing.Point(24, 20)
        Me.drink1.Name = "drink1"
        Me.drink1.Size = New System.Drawing.Size(54, 17)
        Me.drink1.TabIndex = 0
        Me.drink1.TabStop = True
        Me.drink1.Text = "Water"
        Me.drink1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(638, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(637, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(641, 331)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(636, 465)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(329, 464)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Total"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(65, 453)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(627, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Price"
        '
        'menu3
        '
        Me.menu3.Controls.Add(Me.salad2)
        Me.menu3.Controls.Add(Me.salad1)
        Me.menu3.Location = New System.Drawing.Point(271, 148)
        Me.menu3.Name = "menu3"
        Me.menu3.Size = New System.Drawing.Size(200, 100)
        Me.menu3.TabIndex = 14
        Me.menu3.TabStop = False
        Me.menu3.Text = "Salad"
        '
        'salad1
        '
        Me.salad1.AutoSize = True
        Me.salad1.Location = New System.Drawing.Point(26, 28)
        Me.salad1.Name = "salad1"
        Me.salad1.Size = New System.Drawing.Size(59, 17)
        Me.salad1.TabIndex = 15
        Me.salad1.Text = "Ceasor"
        Me.salad1.UseVisualStyleBackColor = True
        '
        'salad2
        '
        Me.salad2.AutoSize = True
        Me.salad2.Location = New System.Drawing.Point(26, 54)
        Me.salad2.Name = "salad2"
        Me.salad2.Size = New System.Drawing.Size(55, 17)
        Me.salad2.TabIndex = 16
        Me.salad2.Text = "Green"
        Me.salad2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 516)
        Me.Controls.Add(Me.menu3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.menu4)
        Me.Controls.Add(Me.menu2)
        Me.Controls.Add(Me.menu1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.menu1.ResumeLayout(False)
        Me.menu1.PerformLayout()
        Me.menu2.ResumeLayout(False)
        Me.menu2.PerformLayout()
        Me.menu4.ResumeLayout(False)
        Me.menu4.PerformLayout()
        Me.menu3.ResumeLayout(False)
        Me.menu3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chicken As CheckBox
    Friend WithEvents salad As CheckBox
    Friend WithEvents drink As CheckBox
    Friend WithEvents menu1 As GroupBox
    Friend WithEvents menu2 As GroupBox
    Friend WithEvents menu4 As GroupBox
    Friend WithEvents chicken2 As RadioButton
    Friend WithEvents chicken1 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents drink4 As RadioButton
    Friend WithEvents drink3 As RadioButton
    Friend WithEvents drink2 As RadioButton
    Friend WithEvents drink1 As RadioButton
    Friend WithEvents menu3 As GroupBox
    Friend WithEvents DirectoryEntry1 As DirectoryServices.DirectoryEntry
    Friend WithEvents salad1 As CheckBox
    Friend WithEvents salad2 As CheckBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FMain
	Inherits System.Windows.Forms.Form

	'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

	'Wird vom Windows Form-Designer benötigt.
	Private components As System.ComponentModel.IContainer

	'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
	'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
	'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.pMenu = New System.Windows.Forms.Panel()
		Me.btnSettings = New System.Windows.Forms.Button()
		Me.btnSkill = New System.Windows.Forms.Button()
		Me.btnMap = New System.Windows.Forms.Button()
		Me.btnDungeon = New System.Windows.Forms.Button()
		Me.btnHome = New System.Windows.Forms.Button()
		Me.pHomeContent = New System.Windows.Forms.Panel()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.PictureBox10 = New System.Windows.Forms.PictureBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.PictureBox7 = New System.Windows.Forms.PictureBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.PictureBox4 = New System.Windows.Forms.PictureBox()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.pMenu.SuspendLayout()
		Me.pHomeContent.SuspendLayout()
		CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'pMenu
		'
		Me.pMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.pMenu.Controls.Add(Me.btnSettings)
		Me.pMenu.Controls.Add(Me.btnSkill)
		Me.pMenu.Controls.Add(Me.btnMap)
		Me.pMenu.Controls.Add(Me.btnDungeon)
		Me.pMenu.Controls.Add(Me.btnHome)
		Me.pMenu.Dock = System.Windows.Forms.DockStyle.Left
		Me.pMenu.Location = New System.Drawing.Point(0, 0)
		Me.pMenu.Name = "pMenu"
		Me.pMenu.Size = New System.Drawing.Size(115, 450)
		Me.pMenu.TabIndex = 0
		'
		'btnSettings
		'
		Me.btnSettings.FlatAppearance.BorderSize = 0
		Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSettings.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSettings.ForeColor = System.Drawing.Color.White
		Me.btnSettings.Location = New System.Drawing.Point(0, 419)
		Me.btnSettings.Name = "btnSettings"
		Me.btnSettings.Size = New System.Drawing.Size(115, 31)
		Me.btnSettings.TabIndex = 5
		Me.btnSettings.Text = "Settings"
		Me.btnSettings.UseVisualStyleBackColor = True
		'
		'btnSkill
		'
		Me.btnSkill.FlatAppearance.BorderSize = 0
		Me.btnSkill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSkill.Font = New System.Drawing.Font("Arial", 9.75!)
		Me.btnSkill.ForeColor = System.Drawing.Color.White
		Me.btnSkill.Location = New System.Drawing.Point(0, 196)
		Me.btnSkill.Name = "btnSkill"
		Me.btnSkill.Size = New System.Drawing.Size(115, 31)
		Me.btnSkill.TabIndex = 4
		Me.btnSkill.Text = "Skill"
		Me.btnSkill.UseVisualStyleBackColor = True
		'
		'btnMap
		'
		Me.btnMap.FlatAppearance.BorderSize = 0
		Me.btnMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMap.Font = New System.Drawing.Font("Arial", 9.75!)
		Me.btnMap.ForeColor = System.Drawing.Color.White
		Me.btnMap.Location = New System.Drawing.Point(0, 159)
		Me.btnMap.Name = "btnMap"
		Me.btnMap.Size = New System.Drawing.Size(115, 31)
		Me.btnMap.TabIndex = 3
		Me.btnMap.Text = "Map"
		Me.btnMap.UseVisualStyleBackColor = True
		'
		'btnDungeon
		'
		Me.btnDungeon.FlatAppearance.BorderSize = 0
		Me.btnDungeon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnDungeon.Font = New System.Drawing.Font("Arial", 9.75!)
		Me.btnDungeon.ForeColor = System.Drawing.Color.White
		Me.btnDungeon.Location = New System.Drawing.Point(0, 122)
		Me.btnDungeon.Name = "btnDungeon"
		Me.btnDungeon.Size = New System.Drawing.Size(115, 31)
		Me.btnDungeon.TabIndex = 2
		Me.btnDungeon.Text = "Dungeon"
		Me.btnDungeon.UseVisualStyleBackColor = True
		'
		'btnHome
		'
		Me.btnHome.FlatAppearance.BorderSize = 0
		Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnHome.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnHome.ForeColor = System.Drawing.Color.White
		Me.btnHome.Location = New System.Drawing.Point(0, 85)
		Me.btnHome.Name = "btnHome"
		Me.btnHome.Size = New System.Drawing.Size(115, 31)
		Me.btnHome.TabIndex = 1
		Me.btnHome.Text = "Home"
		Me.btnHome.UseVisualStyleBackColor = True
		'
		'pHomeContent
		'
		Me.pHomeContent.Controls.Add(Me.Label3)
		Me.pHomeContent.Controls.Add(Me.PictureBox10)
		Me.pHomeContent.Controls.Add(Me.Label2)
		Me.pHomeContent.Controls.Add(Me.PictureBox7)
		Me.pHomeContent.Controls.Add(Me.Label1)
		Me.pHomeContent.Controls.Add(Me.PictureBox4)
		Me.pHomeContent.Controls.Add(Me.PictureBox3)
		Me.pHomeContent.Controls.Add(Me.PictureBox2)
		Me.pHomeContent.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pHomeContent.Location = New System.Drawing.Point(115, 0)
		Me.pHomeContent.Name = "pHomeContent"
		Me.pHomeContent.Size = New System.Drawing.Size(685, 450)
		Me.pHomeContent.TabIndex = 2
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
		Me.Label3.Location = New System.Drawing.Point(224, 225)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(77, 22)
		Me.Label3.TabIndex = 11
		Me.Label3.Text = "helltide"
		'
		'PictureBox10
		'
		Me.PictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PictureBox10.Image = Global.D4_Tools.My.Resources.Resources.Helltide
		Me.PictureBox10.Location = New System.Drawing.Point(228, 250)
		Me.PictureBox10.Name = "PictureBox10"
		Me.PictureBox10.Size = New System.Drawing.Size(187, 105)
		Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox10.TabIndex = 8
		Me.PictureBox10.TabStop = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
		Me.Label2.Location = New System.Drawing.Point(6, 225)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(122, 22)
		Me.Label2.TabIndex = 7
		Me.Label2.Text = "zone events"
		'
		'PictureBox7
		'
		Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PictureBox7.Image = Global.D4_Tools.My.Resources.Resources.Gathering_Legion
		Me.PictureBox7.Location = New System.Drawing.Point(10, 250)
		Me.PictureBox7.Name = "PictureBox7"
		Me.PictureBox7.Size = New System.Drawing.Size(187, 105)
		Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox7.TabIndex = 4
		Me.PictureBox7.TabStop = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
		Me.Label1.Location = New System.Drawing.Point(6, 23)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(135, 22)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "world bosses"
		'
		'PictureBox4
		'
		Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PictureBox4.Image = Global.D4_Tools.My.Resources.Resources.wbWandering_Death
		Me.PictureBox4.Location = New System.Drawing.Point(452, 48)
		Me.PictureBox4.Name = "PictureBox4"
		Me.PictureBox4.Size = New System.Drawing.Size(187, 105)
		Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox4.TabIndex = 2
		Me.PictureBox4.TabStop = False
		'
		'PictureBox3
		'
		Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PictureBox3.Image = Global.D4_Tools.My.Resources.Resources.wbAvarice
		Me.PictureBox3.Location = New System.Drawing.Point(228, 48)
		Me.PictureBox3.Name = "PictureBox3"
		Me.PictureBox3.Size = New System.Drawing.Size(187, 105)
		Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox3.TabIndex = 1
		Me.PictureBox3.TabStop = False
		'
		'PictureBox2
		'
		Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PictureBox2.Image = Global.D4_Tools.My.Resources.Resources.wbAshava
		Me.PictureBox2.Location = New System.Drawing.Point(10, 48)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(187, 105)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox2.TabIndex = 0
		Me.PictureBox2.TabStop = False
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.D4_Tools.My.Resources.Resources.d4_logo
		Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(112, 58)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 1
		Me.PictureBox1.TabStop = False
		'
		'FMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Black
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.pHomeContent)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.pMenu)
		Me.Name = "FMain"
		Me.Text = "D4 Tools"
		Me.pMenu.ResumeLayout(False)
		Me.pHomeContent.ResumeLayout(False)
		Me.pHomeContent.PerformLayout()
		CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents pMenu As Panel
	Friend WithEvents btnHome As Button
	Friend WithEvents btnDungeon As Button
	Friend WithEvents btnSkill As Button
	Friend WithEvents btnMap As Button
	Friend WithEvents btnSettings As Button
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents pHomeContent As Panel
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents PictureBox4 As PictureBox
	Friend WithEvents PictureBox3 As PictureBox
	Friend WithEvents Label3 As Label
	Friend WithEvents PictureBox10 As PictureBox
	Friend WithEvents Label2 As Label
	Friend WithEvents PictureBox7 As PictureBox
	Friend WithEvents Label1 As Label
End Class

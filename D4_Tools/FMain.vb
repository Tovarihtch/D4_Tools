Public Class FMain
	Private Sub FMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.BackColor = Color.FromArgb(&H12, &H13, &H14)
		Me.pMenu.BackColor = Color.FromArgb(&H16, &H17, &H18)
	End Sub

	Private Sub btnDungeon_Click(sender As Object, e As EventArgs) Handles btnDungeon.Click
		Me.pHomeContent.Visible = False
	End Sub

	Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
		Me.pHomeContent.Visible = True
	End Sub

	Private Sub btnMap_Click(sender As Object, e As EventArgs) Handles btnMap.Click
		Me.pHomeContent.Visible = False
	End Sub

	Private Sub btnSkill_Click(sender As Object, e As EventArgs) Handles btnSkill.Click
		Me.pHomeContent.Visible = False
	End Sub
End Class

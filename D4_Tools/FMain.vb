﻿Imports System.Net
Imports System.Web.Script.Serialization
Imports Windows.Data.Xml.Dom
Imports D4_Tools.DataLayer
Imports Windows.UI.Notifications

Public Class FMain
	'World Boss
	Private countdownTimer As New Timer()
	Private nextCountdownTimer As New Timer()
	Private targetDateTime As DateTime
	Private nextTargetDateTime As DateTime
	Private notificationShown As Boolean = False
	Private actualBoss As String
	Private nextBoss As String

	'Legion
	Private countdownLegionTimer As New Timer()
	Private nextCountdownLegionTimer As New Timer()
	Private legionNotificationShown As Boolean = False
	Private legionTargetDateTime As DateTime
	Private legionNextTargetDateTime As DateTime
	Private legionTerritory As String
	Private legionZone As String

	Private Sub FMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.pHomeContent.BackColor = Color.FromArgb(&H12, &H13, &H14)
		Me.pMenu.BackColor = Color.FromArgb(&H16, &H17, &H18)
		Me.pbLogo.BackColor = Color.FromArgb(0, 0, 0, 0)
		Me.btnTracker.BackColor = Color.FromArgb(&H16, &H17, &H18)
		Me.btnMap.BackColor = Color.FromArgb(&H16, &H17, &H18)
		Me.btnSkill.BackColor = Color.FromArgb(&H16, &H17, &H18)
		Me.btnDungeon.BackColor = Color.FromArgb(&H16, &H17, &H18)

		Dim eventData As Dictionary(Of String, Object) = LoadEventData()

		If eventData IsNot Nothing Then
			DisplayEventData(eventData)
		End If
	End Sub
	Private Sub FMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		Dim notifyIcon As NotifyIcon = TryCast(sender, NotifyIcon)
		If notifyIcon IsNot Nothing Then
			notifyIcon.Dispose()
		End If
	End Sub
	Private Function LoadEventData() As Dictionary(Of String, Object)
		Dim url As String = "https://d4armory.io/api/events/recent"

		Try
			Dim webClient As New WebClient()
			Dim jsonData As String = webClient.DownloadString(url)

			Dim serializer As New JavaScriptSerializer()
			Dim eventData As Dictionary(Of String, Object) = serializer.Deserialize(Of Dictionary(Of String, Object))(jsonData)

			Return eventData

		Catch ex As Exception
			MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Return Nothing
		End Try
	End Function

	Private Sub DisplayEventData(eventData As Dictionary(Of String, Object))

		If eventData.ContainsKey("boss") Then
			Dim bossData As Dictionary(Of String, Object) = DirectCast(eventData("boss"), Dictionary(Of String, Object))
			actualBoss = CStr(bossData("expectedName"))
			nextBoss = CStr(bossData("nextExpectedName"))

			targetDateTime = UnixTimeStampToDateTime(CLng(bossData("expected")))
			nextTargetDateTime = UnixTimeStampToDateTime(CLng(bossData("nextExpected")))

			StartCountdown()
			StartNextCountdown()
		Else
		End If

		If eventData.ContainsKey("legion") Then
			Dim legionData As Dictionary(Of String, Object) = DirectCast(eventData("legion"), Dictionary(Of String, Object))
			legionTerritory = CStr(legionData("territory"))
			legionZone = CStr(legionData("zone"))

			legionTargetDateTime = UnixTimeStampToDateTime(CLng(legionData("expected")))
			legionNextTargetDateTime = UnixTimeStampToDateTime(CLng(legionData("nextExpected")))

			StartLegionCountdown()
			StartNextLegionCountdown()
		Else
		End If
	End Sub

	Private Function UnixTimeStampToDateTime(unixTimeStamp As Long) As DateTime
		Return New DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(unixTimeStamp)
	End Function
#Region "World Boss"
	Private Sub StartCountdown()
		countdownTimer.Interval = 1000
		AddHandler countdownTimer.Tick, AddressOf UpdateCountdown
		countdownTimer.Start()
		UpdateCountdown(Nothing, EventArgs.Empty)
	End Sub

	Private Sub StartNextCountdown()
		nextCountdownTimer.Interval = 1000

		AddHandler nextCountdownTimer.Tick, AddressOf UpdateNextCountdown
		nextCountdownTimer.Start()
		UpdateNextCountdown(Nothing, EventArgs.Empty)
	End Sub
	Private Sub UpdateNextCountdown(sender As Object, e As EventArgs)
		Dim currentTime As DateTime = DateTime.UtcNow
		Dim remainingTime As TimeSpan = nextTargetDateTime - currentTime

		If nextBoss = "Ashava" Then
			If remainingTime.Ticks > 0 Then
				lblCountdownBossOne.Text = String.Format("{0:00}:{1:00}:{2:00}", remainingTime.Hours, remainingTime.Minutes, remainingTime.Seconds)
				CheckNotification(remainingTime, nextBoss)
			Else
				lblCountdownBossOne.Text = "00:00:00"
				countdownTimer.Stop()
			End If
		ElseIf nextBoss = "Avarice" Then
			If remainingTime.Ticks > 0 Then
				lblCountdownBossTwo.Text = String.Format("{0:00}:{1:00}:{2:00}", remainingTime.Hours, remainingTime.Minutes, remainingTime.Seconds)
				CheckNotification(remainingTime, nextBoss)
			Else
				lblCountdownBossTwo.Text = "00:00:00"
				countdownTimer.Stop()
			End If
		ElseIf nextBoss = "The Wandering Death" Then
			If remainingTime.Ticks > 0 Then
				lblCountdownBossThree.Text = String.Format("{0:00}:{1:00}:{2:00}", remainingTime.Hours, remainingTime.Minutes, remainingTime.Seconds)
				CheckNotification(remainingTime, nextBoss)
			Else
				lblCountdownBossThree.Text = "00:00:00"
				countdownTimer.Stop()
			End If
		Else
			lblCountdownBossOne.Text = "00:00:00"
			lblCountdownBossTwo.Text = "00:00:00"
			lblCountdownBossThree.Text = "00:00:00"
			lblCountdownLegionOne.Text = "00:00:00"
			lblCountdownLegionTwo.Text = "00:00:00"
			lblCountdownHelltideOne.Text = "00:00:00"
		End If
	End Sub
	Private Sub UpdateCountdown(sender As Object, e As EventArgs)
		Dim currentTime As DateTime = DateTime.UtcNow
		Dim remainingTime As TimeSpan = targetDateTime - currentTime

		If actualBoss = "Ashava" Then
			If remainingTime.Ticks > 0 Then
				lblCountdownBossOne.Text = String.Format("{0:00}:{1:00}:{2:00}", remainingTime.Hours, remainingTime.Minutes, remainingTime.Seconds)
				CheckNotification(remainingTime, actualBoss)
			Else
				lblCountdownBossOne.Text = "00:00:00"
				countdownTimer.Stop()
			End If
		ElseIf actualBoss = "Avarice" Then
			If remainingTime.Ticks > 0 Then
				lblCountdownBossTwo.Text = String.Format("{0:00}:{1:00}:{2:00}", remainingTime.Hours, remainingTime.Minutes, remainingTime.Seconds)
				CheckNotification(remainingTime, actualBoss)
			Else
				lblCountdownBossTwo.Text = "00:00:00"
				countdownTimer.Stop()
			End If
		ElseIf actualBoss = "The Wandering Death" Then
			If remainingTime.Ticks > 0 Then
				lblCountdownBossThree.Text = String.Format("{0:00}:{1:00}:{2:00}", remainingTime.Hours, remainingTime.Minutes, remainingTime.Seconds)
				CheckNotification(remainingTime, actualBoss)
			Else
				lblCountdownBossThree.Text = "00:00:00"
				countdownTimer.Stop()
			End If
		Else
			lblCountdownBossOne.Text = "00:00:00"
			lblCountdownBossTwo.Text = "00:00:00"
			lblCountdownBossThree.Text = "00:00:00"
			lblCountdownLegionOne.Text = "00:00:00"
			lblCountdownLegionTwo.Text = "00:00:00"
			lblCountdownHelltideOne.Text = "00:00:00"
		End If
	End Sub
	Private Sub CheckNotification(remainingTime As TimeSpan, bossName As String)
		'If remainingTime.TotalMinutes <= 15 AndAlso remainingTime.TotalMinutes >= 14 Then
		If remainingTime.Hours = 0 AndAlso remainingTime.Minutes = 15 AndAlso remainingTime.Seconds = 0 AndAlso Not notificationShown Then
			ShowNotification("Es sind nur noch 15 Minuten übrig!", bossName)
			notificationShown = True
		Else
			notificationShown = False
		End If
	End Sub
	Private Sub ShowNotification(message As String, bossName As String)
		Dim notifyIcon As New NotifyIcon()
		notifyIcon.Icon = SystemIcons.Information
		notifyIcon.BalloonTipTitle = "World Boss ('" & bossName & "')"
		notifyIcon.BalloonTipText = message
		notifyIcon.Visible = True
		notifyIcon.ShowBalloonTip(5000)
	End Sub
#End Region
#Region "Legion"
	Private Sub StartLegionCountdown()
		countdownLegionTimer.Interval = 1000
		AddHandler countdownLegionTimer.Tick, AddressOf UpdateLegionCountdown
		countdownLegionTimer.Start()
		UpdateLegionCountdown(Nothing, EventArgs.Empty)
	End Sub
	Private Sub UpdateLegionCountdown(sender As Object, e As EventArgs)
		Dim currentTime As DateTime = DateTime.UtcNow
		Dim remainingTime As TimeSpan = legionTargetDateTime - currentTime

		If remainingTime.Ticks > 0 Then
			lblCountdownLegionOne.Text = String.Format("{0:00}:{1:00}:{2:00}", remainingTime.Hours, remainingTime.Minutes, remainingTime.Seconds)
			lblLegionTerritory.Text = legionTerritory
			lblLegionZone.Text = legionZone
			CheckNotification(remainingTime, legionTerritory, legionZone)
		Else
			lblCountdownLegionOne.Text = "00:00:00"
			countdownLegionTimer.Stop()
		End If
	End Sub
	Private Sub StartNextLegionCountdown()
		nextCountdownLegionTimer.Interval = 1000

		AddHandler nextCountdownLegionTimer.Tick, AddressOf UpdateNextLegionCountdown
		nextCountdownLegionTimer.Start()
		UpdateNextLegionCountdown(Nothing, EventArgs.Empty)
	End Sub
	Private Sub UpdateNextLegionCountdown(sender As Object, e As EventArgs)
		Dim currentTime As DateTime = DateTime.UtcNow
		Dim remainingTime As TimeSpan = legionNextTargetDateTime - currentTime

		If remainingTime.Ticks > 0 Then
			lblCountdownLegionTwo.Text = String.Format("{0:00}:{1:00}:{2:00}", remainingTime.Hours, remainingTime.Minutes, remainingTime.Seconds)
			CheckNotification(remainingTime, legionTerritory, legionZone)
		Else
			lblCountdownLegionTwo.Text = "00:00:00"
			nextCountdownLegionTimer.Stop()
		End If
	End Sub

	Private Sub CheckNotification(remainingTime As TimeSpan, territory As String, zone As String)
		If remainingTime.Hours = 0 AndAlso remainingTime.Minutes = 5 AndAlso remainingTime.Seconds = 0 AndAlso Not notificationShown Then
			ShowNotification("Es sind nur noch 5 Minuten übrig!", territory, zone)
			legionNotificationShown = True
		Else
			legionNotificationShown = False
		End If
	End Sub
	Private Sub ShowNotification(message As String, territory As String, zone As String)
		Dim notifyIcon As New NotifyIcon()
		notifyIcon.Icon = SystemIcons.Information
		notifyIcon.BalloonTipTitle = "Legion (Territory: '" & territory & "' - Zone: '" & zone & "')"
		notifyIcon.BalloonTipText = message
		notifyIcon.Visible = True
		notifyIcon.ShowBalloonTip(5000)
	End Sub
#End Region
#Region "Menu"
	Private Sub btnTracker_Click(sender As Object, e As EventArgs) Handles btnTracker.Click
		Me.pHomeContent.Visible = True
	End Sub
	Private Sub btnDungeon_Click(sender As Object, e As EventArgs) Handles btnDungeon.Click
		Me.pHomeContent.Visible = False
	End Sub

	Private Sub btnMap_Click(sender As Object, e As EventArgs) Handles btnMap.Click
		Me.pHomeContent.Visible = False
	End Sub

	Private Sub btnSkill_Click(sender As Object, e As EventArgs) Handles btnSkill.Click
		Me.pHomeContent.Visible = False
	End Sub
#End Region

End Class

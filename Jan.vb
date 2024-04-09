Public Class Jan


    Private Sub Jan_Load(sender As Object, e As EventArgs) Handles Me.Load
        '初期値空にする
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""

    End Sub

    Private Sub Bstart_Click(sender As Object, e As EventArgs) Handles Bstart.Click
        Label1.ForeColor = Color.Orange
        Label1.Text = "じゃんけん…！"
        Bstart.ForeColor = Color.Gray
        BreStart.ForeColor = Color.Blue

        If Label5.Text <> "" Then
            'アプリケーションを再起動する
            Application.Restart()
        End If

    End Sub


    Private Sub B0_Click(sender As Object, e As EventArgs) Handles B0.Click
        checkStart()
        reJanken()
        hand(handsUp(), 0)
        Label3.Text = "ぽん！"
        Label4.Text = "プレイヤー「グー」を出しました"
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        checkStart()
        reJanken()
        hand(handsUp(), 1)
        Label3.Text = "ぽん！"
        Label4.Text = "プレイヤー「チョキ」を出しました"

    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        checkStart()
        reJanken()
        hand(handsUp(), 2)
        Label3.Text = "ぽん！"
        Label4.Text = "プレイヤー「パー」を出しました"

    End Sub

    Private Sub BreStart_Click(sender As Object, e As EventArgs) Handles BreStart.Click
        'アプリケーションを再起動する
        Application.Restart()
    End Sub



    Function handsUp() As Integer
        Dim random As New System.Random()
        Dim rand As Integer = random.Next(0, 3)
        Return rand
    End Function

    Private Sub hand(rand As Integer, playerHand As Integer)

        If rand = 0 Then
            Label2.Text = "相手「グー」を出しました"
        ElseIf rand = 1 Then
            Label2.Text = "相手「チョキ」を出しました"
        ElseIf rand = 2 Then
            Label2.Text = "相手「パー」を出しました"
        End If


        If rand = playerHand Then
            'あいこ
            draw()
            'グー
        ElseIf rand = 0 And playerHand = 1 Then
            lose()
        ElseIf rand = 0 And playerHand = 2 Then
            win()
            'チョキ
        ElseIf rand = 1 And playerHand = 2 Then
            lose()
        ElseIf rand = 1 And playerHand = 0 Then
            win()
            'パー
        ElseIf rand = 2 And playerHand = 0 Then
            lose()
        ElseIf rand = 2 And playerHand = 1 Then
            win()
        End If

    End Sub


    Private Sub win()
        Label5.ForeColor = Color.Red
        Label5.Text = "勝ちました"
    End Sub

    Private Sub lose()
        Label5.ForeColor = Color.Blue
        Label5.Text = "負けました"
    End Sub

    Private Sub draw()
        Label5.ForeColor = Color.Orange
        Label5.Text = "引き分け"
    End Sub


    Private Sub checkStart()
        If Label1.Text = "" Then
            Label1.ForeColor = Color.Orange
            Label1.Text = "じゃんけん…！"

        End If
    End Sub

    Private Sub reJanken()
        If Label5.Text <> "" Then
            'アプリケーションを再起動する
            Application.Restart()
        End If
    End Sub


End Class

﻿Public Class Form5
    Dim score As Integer
    Dim isAllowed As Boolean = False
    Sub New(ByVal sc As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        score = sc
        Label7.Text = score
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label5.Text = Label5.Text - 1
        Label2.Text = Label2.Text - 500
        If Label5.Text = 0 Then
            Timer1.Stop()
            MsgBox("Times Up")
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            isAllowed = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Close()
    End Sub
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Timer1.Enabled = False
        Timer1.Stop()
        PictureBox2.Enabled = False
        PictureBox3.Enabled = False
        PictureBox4.Enabled = False
        PictureBox5.Enabled = False
        isAllowed = True
        MsgBox("wrong Choice!!")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Timer1.Enabled = False
        Timer1.Stop()
        PictureBox2.Enabled = False
        PictureBox3.Enabled = False
        PictureBox4.Enabled = False
        PictureBox5.Enabled = False
        isAllowed = True
        MsgBox("wrong Choice!!")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Timer1.Enabled = False
        Timer1.Stop()
        PictureBox2.Enabled = False
        PictureBox3.Enabled = False
        PictureBox4.Enabled = False
        PictureBox5.Enabled = False
        isAllowed = True
        MsgBox("wrong Choice!!")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Timer1.Enabled = False
        Timer1.Stop()
        PictureBox2.Enabled = False
        PictureBox3.Enabled = False
        PictureBox4.Enabled = False
        PictureBox5.Enabled = False
        isAllowed = True
        Label7.Text = CInt(Label7.Text) + CInt(Label2.Text)
        MsgBox("Right Choice!!")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
Imports System.Data.OleDb

Public Class Form1
    Dim co As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\pc\Desktop\Stage\acess\Gestion des employees2.accdb;Jet OLEDB:Database Password=123123123")
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader


    '\Gestion des employees2.accdb

    Sub remplir()
        co.Open()
        cmd.Connection = co
        cmd.CommandText = "select * from InfoPersonel"
        rd = cmd.ExecuteReader
        While rd.Read
            'GunaDataGridView1.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5), rd(6), rd(7))
        End While
        co.Close()



    End Sub
    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_etatfam.Items.Add("marié(e)")
        txt_etatfam.Items.Add("célibataire(e)")
        remplir()

    End Sub

    Private Sub GunaGradientButton3_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub GunaGradientButton3_Click_1(sender As Object, e As EventArgs) Handles GunaGradientButton3.Click
        co.Open()
        cmd.Connection = co
        cmd.CommandText = "insert into InfoPersonel values('" + txt_nom.Text + "','" + txt_prenom.Text + "','" + date_nais.Value + "','" + txt_etatfam.Text + "','" + txt_cin.Text + "','" + txt_villeNais.Text + "'," + txt_nbrEnfant.Text + ",'" + txt_add.Text + "')"
        cmd.ExecuteNonQuery()
        co.Close()
        MsgBox("تم أضافة المعلومات الشخصية بنجاح")
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click

    End Sub

    Private Sub GunaGradientButton1_Click_1(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        Me.Hide()
        congeevb.Show()

    End Sub

    Private Sub GunaGradientButton4_Click(sender As Object, e As EventArgs) Handles GunaGradientButton4.Click
        Me.Hide()
        daymoma.Show()

    End Sub
End Class

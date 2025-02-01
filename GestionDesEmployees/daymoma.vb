Imports System.Data.OleDb

Public Class daymoma
    Dim co As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\pc\Desktop\Stage\acess\Gestion des employees2.accdb;Jet OLEDB:Database Password=123123123")
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader

    Dim id As Integer
    Dim jf As String
    Dim itar As String



    Sub sendInfo()
        co.Open()
        cmd.Connection = co
        cmd.CommandText = "select cin from InfoPersonel where nom='" + txt_nom.Text + "'and prenom ='" + txt_prenom.Text + "'"
        rd = cmd.ExecuteReader
        While rd.Read
            jf = rd(0)
        End While
        rd.Close()
        cmd.CommandText = "insert into Dimoma(cin,otalosboa,otalwatani,nbrjours)values('" + jf + "','" + txt_semain.Text + "','" + txt_national.Text + "'," + txt_nbrJours.Text + ")"
        cmd.ExecuteNonQuery()
        co.Close()
        MsgBox("good")

    End Sub

    Sub remplirData()
        co.Open()
        cmd.Connection = co
        cmd.CommandText = "select nom, prenom, numtaajir, InfoPersonel.cin, degree, grade, otalosboa, otalwatani, nbrjours from InfoPersonel, InfoProf, Dimoma where InfoPersonel.cin = InfoProf.cin and InfoPersonel.cin = dimoma.cin"
        rd = cmd.ExecuteReader
        While rd.Read
            GunaDataGridView1.Rows.Add(rd(8), rd(7), rd(6), rd(5) + " من " + rd(4), rd(3), rd(2), rd(1), rd(0))
        End While

        co.Close()



    End Sub

    Private Sub daymoma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        remplirData()


    End Sub

    Private Sub GunaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellContentClick

    End Sub

    Private Sub GunaGradientButton7_Click(sender As Object, e As EventArgs) Handles GunaGradientButton7.Click
        sendInfo()
        remplirData()







    End Sub
    Private Sub delete()
        co.Open()
        cmd.Connection = co
        cmd.CommandText = "select cin from InfoPersonel where nom='" + txt_nom.Text + "'and prenom ='" + txt_prenom.Text + "'"
        rd = cmd.ExecuteReader
        While rd.Read
            jf = rd(0)
        End While
        rd.Close()
        cmd.CommandText = "delete from dimoma where cin='" + jf + "'"
        cmd.ExecuteNonQuery()
        MsgBox("good")
        co.Close()
    End Sub

    Private Sub GunaGradientButton3_Click(sender As Object, e As EventArgs) Handles GunaGradientButton3.Click
        delete()
        remplirData()
        Me.Refresh()

    End Sub
End Class
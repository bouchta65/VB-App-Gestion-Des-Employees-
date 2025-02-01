Imports System.Data.OleDb

Public Class Form2
    Dim co As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\pc\Desktop\Stage\acess\Gestion des employees2.accdb;Jet OLEDB:Database Password=123123123")
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader



    Sub remolirEmplacement()
        co.Open()
        cmd.Connection = co
        cmd.CommandText = "select nom,prenom from InfoPersonel"
        rd = cmd.ExecuteReader
        While rd.Read
            combo_emplacement.Items.Add(rd(0) + " " + rd(1))
        End While
        co.Close()
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_fonction.Items.Add("dfh")
        remolirEmplacement()


    End Sub

    Private Sub GunaGradientButton4_Click(sender As Object, e As EventArgs) Handles GunaGradientButton4.Click
        co.Open()
        cmd.Connection = co
        cmd.CommandText = "insert into InfoProf values(" + txt_id.Text + ",'" + cmb_degree.SelectedItem + "','" + txt_locale.Text + "','" + date_degree.Text + "','" + cmb_grade.SelectedItem + "','" + date_ancien.Text + "','" + txt_fonction.SelectedItem + "','" + date_travaill.Text + "','" + combo_emplacement.SelectedItem + "','" + txt_cin.Text + "')"
        cmd.ExecuteNonQuery()
        MsgBox("good")
        co.Close()

    End Sub

    Private Sub txt_id_TextChanged(sender As Object, e As EventArgs) Handles txt_id.TextChanged

    End Sub

    Private Sub txt_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_id.KeyPress

    End Sub
End Class
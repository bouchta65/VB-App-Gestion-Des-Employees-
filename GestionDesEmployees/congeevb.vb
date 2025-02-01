Imports System.Data.OleDb

Public Class congeevb

    Dim co As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\pc\Desktop\Stage\acess\Gestion des employees2.accdb;Jet OLEDB:Database Password=123123123")
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader




    Private Sub GunaGradientButton3_Click(sender As Object, e As EventArgs) Handles GunaGradientButton3.Click
        Dim cin As String
        co.Open()
        cmd.Connection = co
        cmd.CommandText = "select cin from InfoPersonel where nom = '" + txt_nom.Text + "' and prenom='" + txt_prenom.Text + "'"
        rd = cmd.ExecuteReader
        While rd.Read
            cin = rd(0)
        End While
        rd.Close()
        cmd.CommandText = "insert into Congee(type,debut,fin,cin) values ('" + cmb_type.SelectedItem + "','" + debut.Text + "','" + fin.Text + "','" + cin + "')"
        cmd.ExecuteNonQuery()
        co.Close()
        MsgBox("تم إضافة الرخصة بنجاح")
    End Sub

    Private Sub congeevb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_type.Items.Add("إجازة مرضية")
        cmb_type.Items.Add("إجازة مرضية")
        cmb_type.Items.Add("إجازة مرضية")

    End Sub
End Class
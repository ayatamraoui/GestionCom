Imports System.Data.SqlClient
Public Class Form1
    Dim ds As New DataSet()
    Dim con As New SqlConnection
    Dim cmdCommande, cmdArticle As SqlCommand
    Dim adaptCommande, adaptArticle As SqlDataAdapter
    Dim dt As DataTable
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = Connecter("Data Source = localhost ; Initial Catalog = GestionCom2 ; Integrated Security = true")
        con.Open()

        ds = New DataSet

        remplireDS()
        RemplireCombo()

    End Sub

    Function Connecter(ByVal ch As String) As SqlConnection
        Dim connexion As New SqlConnection(ch)
        Return connexion
    End Function
    Private Sub BtnArt_Click(sender As Object, e As EventArgs) Handles BtnArt.Click

        con = Connecter("Data Source = localhost ; Initial Catalog = GestionCom2 ; Integrated Security = true")
        con.Open()
        Dim command As New SqlCommand("select * from ARTICLE", con)
        Dim da As New SqlDataAdapter(command)
        da.Fill(ds, "ARTICLE")
        Dgv.DataSource = ds.Tables("ARTICLE")

    End Sub

    Sub RemplireCombo()
        cmbCom.ValueMember = "Numcom"
        cmbCom.DataSource = ds.Tables("COMMANDE")

        CmbArt.DisplayMember = "dstart"
        CmbArt.ValueMember = "Numart"
        CmbArt.DataSource = ds.Tables("ARTICLE")
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Dim dv As New DataView(ds.Tables("ARTICLE"))
        dv.RowFilter = "dstart  LIKE '%" & TxtSearch.Text & "%' "
        Dgv.DataSource = dv
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        con = Connecter("Data Source = localhost ; Initial Catalog = GestionCom2 ; Integrated Security = true")
        con.Open()
        Dim comand As New SqlCommand("INSERT INTO lignedecommande values(cmbCom.SelectedItem,CmbArt.SelectedItem,txtQte.Text)", con)
    End Sub

    Sub remplireDS()

        cmdCommande = New SqlCommand("SELECT * FROM commande;", con)
        cmdArticle = New SqlCommand("SELECT * FROM Article;", con)

        adaptCommande = New SqlDataAdapter(cmdCommande)
        adaptArticle = New SqlDataAdapter(cmdArticle)

        adaptCommande.Fill(ds, "commande")
        adaptArticle.Fill(ds, "Article")


    End Sub
End Class

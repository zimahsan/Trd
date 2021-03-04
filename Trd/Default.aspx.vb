Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
'-------------------------------------------

Imports System.Web.Script.Serialization '(Importing System.Web.Script.Serialization) This is used to read and convert JSON strings.
Imports System.ComponentModel '(Importing System.ComponentModel) This is used to sort data on DataGridView.
Imports System.IO
Imports Newtonsoft.Json

Public Class _Default
    Inherits Page

    Private ifc As New FirebaseConfig() With
        {
        .AuthSecret = "oX4VYTjWAH5dwLJnFugzGxHmSwTJAnOUco8H58U5",
        .BasePath = "https://trade-937af-default-rtdb.firebaseio.com/"
        }


    Private client As IFirebaseClient
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        Try
            client = New FireSharp.FirebaseClient(ifc)
        Catch ex As Exception
            MsgBox("not happening")
        End Try





    End Sub

    Private Sub submit_ServerClick(sender As Object, e As EventArgs) Handles submit.ServerClick


        Dim std As New User() With
            {
            .FirstName = TextBox1.Text,
            .LasttName = TextBox2.Text,
            .Email = TextBox3.Text,
            .Password = TextBox4.Text
            }

        Dim setter = client.Set("User/" + TextBox3.Text, std)
        MsgBox("stored!")





    End Sub



    Private Sub UpdateRTB(ByVal records As Dictionary(Of String, User))
        
    End Sub

    Private Sub DataGridView1_DataBinding(sender As Object, e As EventArgs) Handles DataGridView1.DataBinding
        'Dim dt As New DataTable()
        'dt.Columns.Add("Full Name")
        'dt.Columns.Add("Roll No")
        'dt.Columns.Add("Grade")
        'dt.Columns.Add("Section")

        'DataGridView1.Columns.Clear()

        'Dim res = client.Get("Counter")
        'Dim Counter = Integer.Parse(res.ResultAs(Of String))

        'For i = 1 To Counter
        '    Dim res2 = client.Get("Sno/" + Convert.ToString(i) + "/Email")
        '    Dim RollNo = res2.ResultAs(Of String)

        '    Dim res3 = client.Get("User/" + RollNo)
        '    Dim std = res3.ResultAs(Of User)

        '    If (std.FirstName <> "") Then '(std <> null)
        '        dt.Rows.Add(std.FirstName, std.LasttName, std.Email, std.Password)
        '    End If

        'Next

        'For Each item As DataRow In dt.Rows
        '    DataGridView1.Rows.Add(item.ItemArray)
        'Next
    End Sub
End Class
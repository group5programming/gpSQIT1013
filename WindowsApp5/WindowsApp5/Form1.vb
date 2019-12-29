Public Class waterdatabase
    Private Sub WaterBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles StudentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.WaterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WaterDBDataSet)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WaterDBDataSet.water' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.WaterDBDataSet.Table1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WaterBindingSource.MovePrevious()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WaterBindingSource.AddNew()
        WaterTableAdapter.Update(WaterDBDataSet.student)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WaterBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WaterBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
End Class

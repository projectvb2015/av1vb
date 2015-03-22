Public Class frmProfessor
    Friend diaNasc As String

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim sair As String

        sair = MsgBox("Deseja Realmente Sair? Seus Dados Serão Perdidos.", MsgBoxStyle.YesNoCancel, "Atenção!")
        If sair = vbYes Then
            End
        End If
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        MsgBox("Dados Salvos Com Sucesso!", MsgBoxStyle.Information, "Aviso")
    End Sub

    Private Sub cmbDiaRg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDiaRg.SelectedIndexChanged
        diaNasc = cmbDiaRg.SelectedItem
        MsgBox(diaNasc)
    End Sub
End Class
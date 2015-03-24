Public Class frmAluno
    Dim NM_NomeAluno As String
    Dim NM_SobrenomeAluno As String
    Dim DS_NaturalidadeAluno As String
    Dim DS_EtiniaAluno As String
    Dim NO_CPFAluno As Integer
    Dim NO_RGAluno As Integer
    Dim DS_NacionalidadeAluno As String
    Dim DT_DataEmissaoRGAluno As Date
    Dim SG_UFRGAluno As String
    Dim SG_OrgaoEmissorRGAluno As Integer
    Dim DT_NascimentoAluno As Date
    Dim IC_EmancipadoAluno As String
    Dim IC_SexoAluno As String
    Dim NM_EmailAluno As String
    Dim NM_NomeResponsavel As String
    Dim NM_SobrenomeResponsavel As String
    Dim NO_CPFResponsavel As Integer
    Dim NO_RGResponsavel As Integer
    Dim DT_DataEmissaoRGResponsavel As Date
    Dim SG_UFRGResponsavel As String
    Dim SG_OrgaoEmissorRGResponsavel As Integer
    Dim DT_NascimentoResponsavel As Date
    Dim NM_EmailResponsavel As String
    Dim NO_CEPAluno As Integer
    Dim NM_RuaAluno As String
    Dim NO_RuaAluno As Integer
    Dim DS_ComplementoAluno As String
    Dim NM_BairroAluno As String
    Dim NM_CidadeAluno As String
    Dim NM_PaisAluno As String
    Dim SG_UFAluno As String
    Dim NO_tellAluno As Integer
    Dim NO_cellAluno As Integer

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim sair As String

        sair = MsgBox("Deseja Realmente Sair? Seus Dados Serão Perdidos.", MsgBoxStyle.YesNoCancel, "Atenção!")
        If sair = vbYes Then
            End
        End If
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim salvar As String
        salvar = MsgBox("Tem certeza que deseja salvar esses dados? ", MsgBoxStyle.YesNoCancel, )
        If salvar = vbYes Then
            NM_NomeAluno = txtName.Text
            NM_SobrenomeAluno = txtSname.Text
            DS_NaturalidadeAluno = txtNaturalidade.Text
            DS_EtiniaAluno = cmbEtnia.Text
            DS_NacionalidadeAluno = cmbNacionalidade.Text
            SG_UFRGAluno = CmbUFRGAluno.Text

            MsgBox(NM_NomeAluno & vbCrLf & NM_SobrenomeAluno & vbCrLf & DS_NaturalidadeAluno & vbCrLf &
                   DS_EtiniaAluno & vbCrLf & DS_NacionalidadeAluno & vbCrLf & SG_UFRGAluno & NO_CPFAluno)
            End
        End If
    End Sub
End Class
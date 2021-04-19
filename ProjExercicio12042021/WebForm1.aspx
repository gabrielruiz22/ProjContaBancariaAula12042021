<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ProjExercicio12042021.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 264px;
        }
        .auto-style3 {
            width: 264px;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Nome" runat="server" Text="Nome:"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="TxtNome" runat="server" Width="260px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Estado" runat="server" Text="Estado:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtEstado" runat="server" Width="259px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Cidade" runat="server" Text="Cidade:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtCidade" runat="server" Width="258px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Endereco" runat="server" Text="Endereco:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtEndereco" runat="server" Width="258px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Telefone" runat="server" Text="Telefone:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtTelefone" runat="server" Width="259px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Cpf" runat="server" Text="CPF:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtCpf" runat="server" Width="260px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Email" runat="server" Text="E-mail:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtEmail" runat="server" Width="261px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="LblTipoConta" runat="server" Text="Tipo Conta (1- Corrente / 2- Poupança):"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtTipoConta" runat="server" Width="262px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="BtnSalvar" runat="server" Text="Salvar" Height="26px" OnClick="BtnSalvar_Click" />
                </td>
            </tr>
        </table>
        <asp:GridView ID="GVCliente" runat="server" OnSelectedIndexChanged="Page_Load">
        </asp:GridView>
    </form>
</body>
</html>

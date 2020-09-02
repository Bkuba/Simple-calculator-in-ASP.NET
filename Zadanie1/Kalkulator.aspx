<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kalkulator.aspx.cs" Inherits="Zadanie1.Kalkulator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style4 {
            width: 242px;
        }
        .auto-style5 {
            width: 237px;
        }
        .auto-style6 {
            width: 299px;
        }
        .auto-style7 {
            width: 171px;
        }
        .auto-style8 {
            width: 79px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Kalkulator</h1>
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="labFirstNum" runat="server" Text="Podaj pierwsza liczbe"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:Label ID="labSecondNum" runat="server" Text="Podaj druga liczbe "></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="btnDodaj" runat="server" OnClick="btnDodaj_Click" Text="dodaj" />
                        <asp:Button ID="btnOdejmij" runat="server" OnClick="btnOdejmij_Click" Text="odejmij" />
                        <asp:Button ID="btnPomnoz" runat="server" OnClick="btnPomnoz_Click" Text="pomnoz" />
                        <asp:Button ID="btnPodziel" runat="server" OnClick="btnPodziel_Click" Text="podziel" />
                    </td>
                    <td class="auto-style7">
                        <asp:Label ID="labThirdNum" runat="server" Text="Podaj trzecia liczbe" Visible="False"></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:Button ID="btnDodaj1" runat="server" OnClick="btnDodaj1_Click" Text="dodaj" Visible="False" />
                    </td>
                    <td>
                        <asp:Button ID="btnOdejmij1" runat="server" OnClick="btnOdejmij1_Click" Text="odejmij" Visible="False" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbFirstNum" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="tbSecondNum" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="btnPodajTrzeciaLicz" runat="server" OnClick="btnPodajTrzeciaLicz_Click" Text="podaj trzecia liczbe" />
                    </td>
                    <td class="auto-style7">
                        <asp:TextBox ID="tbThirdNum" runat="server" Visible="False"></asp:TextBox>
                    </td>
                    <td class="auto-style8">
                        <asp:Button ID="btnPomnoz1" runat="server" OnClick="btnPomnoz1_Click" Text="pomnoz" Visible="False" />
                    </td>
                    <td>
                        <asp:Button ID="btnPodziel1" runat="server" OnClick="btnPodziel1_Click" Text="podziel" Visible="False" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td class="auto-style6">
                        <asp:Label ID="labResult" runat="server" Text="WYNIK" Visible="False"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        &nbsp;</td>
                    <td class="auto-style8">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="tbResult" runat="server" Visible="False"></asp:TextBox>
                    </td>
                    <td class="auto-style7">
                        <asp:Button ID="btnSaveToBase" runat="server" Height="50px" OnClick="btnSaveToBase_Click" Text="zapisz wynik w bazie" Visible="False" Width="166px" />
                    </td>
                    <td class="auto-style8">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataFromBase.aspx.cs" Inherits="Zadanie1.DataFromBase" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 329px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btnShowAllData" runat="server" OnClick="btnShowAllData_Click" Text="Wyswietl dane z tabeli" Width="162px" />
                    </td>
                    <td class="auto-style2">
                        <asp:Button ID="btnNumOfEntries" runat="server" Height="36px" OnClick="btnNumOfEntries_Click" Text="Wyswietl ilosc wpisow w tabeli" Width="283px" />
                    </td>
                    <td>
                        <asp:Button ID="btnLatesEntry" runat="server" OnClick="btnLatesEntry_Click" Text="Wyswietl najnowszy wpis" Width="232px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:TextBox ID="tbAllData" runat="server" Height="72px" TextMode="MultiLine" Width="238px"></asp:TextBox>
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ShipperClient.Default" %>

<link href="Style.css" rel="stylesheet" />
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WCF LAB3, ShipperClient</title>
    
    <meta name="description" content="LAB 3 - WCF - ShipperClient" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <style type="text/css">
        .auto-style1 {
            width: 159px;
        }
        .auto-style2 {
            height: 91px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
<div class = "wrapper">
    <div class = "content">
        <table class="table">
            <tr>
                <td colspan="2" class="auto-style2">
                    <h1>EDIT SHIPPER INFORMATION</h1>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="EnterShipper_Label" runat="server" Text="Label">Enter shipper id:</asp:Label> <br/>
                </td>
                <td>
                    <asp:TextBox ID="EnterShipperID_TextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="GetShipper_Button" runat="server" Text="Get Shipper!" Height="25px" OnClick="GetShipper_Button_Click" Width="168px" /></td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="EditShipper_Label" runat="server" Text="Edit shipper:"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="DisplayShipperID_Label" runat="server" Text="ShipperID:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="DisplayShipperID_TextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="CompanyName_Label" runat="server" Text="Company Name:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="CompanyName_TextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Phone_Label" runat="server" Text="Phone number:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="Phone_TextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="SaveShipper_Button" runat="server" Height="25px" Text="Save Shipper!" Width="168px" OnClick="SaveShipper_Button_Click" />
                </td>
            </tr>
            </table>
    </div>
</div>

   

    </form>

   

</body>
</html>

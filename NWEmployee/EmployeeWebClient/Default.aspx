<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EmployeeWebClient.Default" %>

<link href="Style.css" rel="stylesheet" />
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WCF LAB3, EmployeeClient</title>

    <meta name="description" content="LAB 3 - WCF - Employee Webclient" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <style type="text/css">
        .auto-style1 {
            width: 172px;
        }

        .auto-style2 {
            height: 91px;
        }
        .auto-style3 {
            width: 172px;
            height: 28px;
        }
        .auto-style4 {
            height: 28px;
            width: 393px;
        }
        .auto-style5 {
            width: 172px;
            height: 30px;
        }
        .auto-style6 {
            height: 30px;
            width: 393px;
        }
        .auto-style7 {
            width: 393px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="wrapper">
            <div class="content">
                <table class="table">
                    <tr>
                        <td colspan="2" class="auto-style2">
                            <h3>EDIT EMPLOYEE INFORMATION</h3>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Enter EmployeeID</td>
                        <td class="auto-style7">
                            <asp:TextBox ID="EnterEmployeeID_TextBox" runat="server" Width="290px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td class="auto-style7">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td class="auto-style7">
                            <asp:Button ID="GetEmployee_Button" runat="server" Text="Get Employee!" Height="25px" OnClick="GetEmployee_Button_Click" Width="290px" /></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;Edit information</td>
                        <td class="auto-style7">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td class="auto-style7">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">EmployeeID</td>
                        <td class="auto-style7">
                            <asp:TextBox ID="DisplayEmployee_TextBox" runat="server" Width="290px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Lastname</td>
                        <td class="auto-style7">
                            <asp:TextBox ID="LastName_TextBox" runat="server" Width="290px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Firstname</td>
                        <td class="auto-style7">
                            <asp:TextBox ID="FirstName_TextBox" runat="server" Width="290px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Title</td>
                        <td class="auto-style7">
                            <asp:TextBox ID="Title_TextBox" runat="server" Width="290px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Title Of Courtesy</td>
                        <td class="auto-style7">
                            <asp:TextBox ID="TitleOfCourtesy_TextBox" runat="server" Width="290px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Birth Date</td>
                        <td class="auto-style7">
                            <asp:TextBox ID="BirthDate_TextBox" runat="server" Width="290px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Hire Date</td>
                        <td class="auto-style4">
                            <asp:TextBox ID="HireDate_TextBox" runat="server" Width="290px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Adress</td>
                        <td class="auto-style7">
                            <asp:TextBox ID="Adress_TextBox" runat="server" Width="290px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">City</td>
                        <td class="auto-style7">
                            <asp:TextBox ID="City_TextBox" runat="server" Width="290px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Region</td>
                        <td class="auto-style7">
                            <asp:TextBox ID="Region_TextBox" runat="server" Width="290px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Postal Code</td>
                        <td class="auto-style7">
                            <asp:TextBox ID="PostalCode_TextBox" runat="server" Width="290px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Country</td>
                        <td class="auto-style7">
                            <asp:TextBox ID="Country_TextBox" runat="server" Width="290px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">Home Phone</td>
                        <td class="auto-style6">
                            <asp:TextBox ID="HomePhone_TextBox" runat="server" Width="290px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">Extension</td>
                        <td class="auto-style6">
                            <asp:TextBox ID="Extension_TextBox" runat="server" Width="290px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Notes</td>
                        <td class="auto-style7">
                            <asp:TextBox ID="Notes_TextBox" runat="server" Width="290px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Reports To</td>
                        <td class="auto-style7">
                            <asp:TextBox ID="ReportsTo_TextBox" runat="server" Width="290px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td class="auto-style7">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td class="auto-style7">
                            <asp:Button ID="SaveEmployee_Button" runat="server" Height="25px" Text="Save Employeee!" Width="290px" OnClick="SaveEmployee_Button_Click" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>



    </form>
</body>
</html>

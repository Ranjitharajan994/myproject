<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Userregistration.aspx.cs" Inherits="myproject.Userregistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 0px;
        }
        .auto-style2 {
            width: 505px;
        }
        .auto-style3 {
            width: 505px;
            height: 27px;
        }
        .auto-style4 {
            height: 27px;
        }
    .auto-style5 {
        width: 333px;
    }
    .auto-style6 {
        height: 27px;
        width: 333px;
    }
        .auto-style7 {
            width: 437px;
        }
        .auto-style8 {
            width: 437px;
            height: 27px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Size="Large" ForeColor="Black" Text="Name"></asp:Label>
            </td>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style5">
                <asp:Label ID="Label2" runat="server" Font-Bold="False" Font-Size="Large" ForeColor="Black" Text="Phone"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please Enter Your Name" ForeColor="#CC0000" Font-Size="Medium"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter a Valid Phone Number" Font-Size="Medium" ForeColor="#CC0000" ValidationExpression="^[789]\d{9}$ "></asp:RegularExpressionValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="Label3" runat="server" Font-Bold="False" Font-Size="Large" ForeColor="Black" Text="Email"></asp:Label>
            </td>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style5">
                <asp:Label ID="Label4" runat="server" Font-Bold="False" Font-Size="Large" ForeColor="Black" Text="Address"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style2">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter a Valid Email Address" Font-Size="Medium" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style1" TextMode="MultiLine" Width="262px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox4" ErrorMessage="Enter Your Address" ForeColor="#CC0000" Font-Size="Medium"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="Label5" runat="server" Font-Bold="False" Font-Size="Large" ForeColor="Black" Text="State"></asp:Label>
            </td>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style5">
                <asp:Label ID="Label7" runat="server" Font-Bold="False" Font-Size="Large" ForeColor="Black" Text="District"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:DropDownList ID="DropDownList1" runat="server" Width="73px" AutoPostBack="True" OnTextChanged="DropDownList1_TextChanged">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Choose Your State" ForeColor="#CC0000" Font-Size="Medium"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style6">
                <asp:DropDownList ID="DropDownList2" runat="server" Width="40px">
                </asp:DropDownList>
            </td>
            <td class="auto-style4">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DropDownList2" ErrorMessage="Choose Your District"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="Label8" runat="server" Font-Bold="False" Font-Size="Large" ForeColor="Black" Text="Pincode"></asp:Label>
            </td>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style5">
                <asp:Label ID="Label9" runat="server" Font-Bold="False" Font-Size="Large" ForeColor="Black" Text="Username"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox7" ErrorMessage="Enter Your Pincode" ForeColor="#CC0000" Font-Size="Medium"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style6">
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style4">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox8" ErrorMessage="Enter User Name" ForeColor="#CC0000" Font-Size="Medium"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="Label10" runat="server" Font-Bold="False" Font-Size="Large" ForeColor="Black" Text="Password"></asp:Label>
            </td>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox9" ErrorMessage="Enter Password" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style5">
                <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="Black" OnClick="Button1_Click" Text="Register" />
            </td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

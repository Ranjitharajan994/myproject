﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Adminregistration.aspx.cs" Inherits="myproject.Adminregistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 322px;
        }
        .auto-style2 {
            width: 322px;
            height: 50px;
        }
        .auto-style3 {
            height: 50px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style1">
                <asp:Label ID="Label7" runat="server" Font-Italic="True" Font-Size="X-Large" ForeColor="Black" Text="Registration Form"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                &nbsp;</td>
            <td class="auto-style1">
                <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Size="Large" ForeColor="Black" Text="Name" Font-Italic="True"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="mt-0" Height="27px" Width="212px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please Enter Your Name" ForeColor="#CC0000" Font-Size="Medium"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                &nbsp;</td>
            <td class="auto-style1">
                <asp:Label ID="Label2" runat="server" Font-Bold="False" Font-Size="Large" ForeColor="Black" Text="Address" Font-Italic="True"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Width="212px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Please Enter Your Address" ForeColor="#CC0000" Font-Size="Medium"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                &nbsp;</td>
            <td class="auto-style1">
                <asp:Label ID="Label3" runat="server" Font-Bold="False" Font-Size="Large" ForeColor="Black" Text="Phone" Font-Italic="True"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Width="212px"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="Enter a Valid Phone Number" Font-Size="Medium" ForeColor="#CC0000" ValidationExpression="^[789]\d{9}$ "></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style2">
                <asp:Label ID="Label4" runat="server" Font-Bold="False" Font-Size="Large" ForeColor="Black" Text="Email" Font-Italic="True"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox4" runat="server" Width="212px"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox4" ErrorMessage="RegularExpressionValidator" Font-Size="Medium" ForeColor="#CC0000"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                &nbsp;</td>
            <td class="auto-style1">
                <asp:Label ID="Label5" runat="server" Font-Bold="False" Font-Size="Large" ForeColor="Black" Text="Username" Font-Italic="True"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server" Width="212px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox5" ErrorMessage="Enter Username" ForeColor="#CC0000" Font-Size="Medium"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                &nbsp;</td>
            <td class="auto-style1">
                <asp:Label ID="Label6" runat="server" Font-Bold="False" Font-Size="Large" ForeColor="Black" Text="Password" Font-Italic="True"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server" TextMode="Password" Width="212px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox6" ErrorMessage="Enter Password" ForeColor="#CC0000" Font-Size="Medium"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                &nbsp;</td>
            <td class="auto-style1">
                <asp:Label ID="Label8" runat="server" Font-Italic="True" Font-Size="Large" ForeColor="Black" Text="Confirm Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server" Width="212px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                &nbsp;</td>
            <td class="auto-style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Font-Bold="False" Font-Size="Large" OnClick="Button1_Click" Text="Register Here" Width="183px" Font-Italic="True" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="viewbill.aspx.cs" Inherits="myproject.viewbill" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 79px;
        }
        .auto-style2 {
            height: 27px;
        }
        .auto-style3 {
            width: 79px;
            height: 27px;
        }
        .auto-style4 {
            height: 44px;
        }
        .auto-style5 {
            width: 79px;
            height: 44px;
        }
        .auto-style6 {
            width: 100%;
            height: 286px;
        }
        .auto-style7 {
            height: 57px;
        }
    .auto-style8 {
        width: 318px;
    }
    .auto-style9 {
        height: 27px;
        width: 318px;
    }
    .auto-style10 {
        height: 44px;
        width: 318px;
    }
        .auto-style11 {
            margin-top: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style8">
                <asp:Label ID="Label16" runat="server" Font-Size="Large" ForeColor="White" Text="PlantKart Online Plant Shop"></asp:Label>
                <br />
                <asp:Label ID="Label17" runat="server" Font-Size="Medium" ForeColor="White" Text="Malampuzha Road,Palakkad-678651"></asp:Label>
                <br />
                <asp:Label ID="Label18" runat="server" Font-Size="Small" ForeColor="White" Text="Phone :0491-2555789"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label1" runat="server" Font-Italic="True" Font-Size="X-Large" ForeColor="Black" Text="         INVOICE"></asp:Label>
                </td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style9"></td>
            <td class="auto-style2"></td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style8">
                <asp:Label ID="Label2" runat="server" Font-Italic="True" Font-Size="Large" ForeColor="Black" Text="Invoice Number"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label4" runat="server" Font-Size="Large" ForeColor="Black" Text="Label"></asp:Label>
            </td>
            <td class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
            <td class="auto-style8">
                <asp:Label ID="Label3" runat="server" Font-Italic="True" Font-Size="Large" ForeColor="Black" Text="Date Of Issue"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label6" runat="server" Font-Size="Large" ForeColor="Black" Text="Label"></asp:Label>
            </td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style8">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" Height="248px" Width="826px">
                    <Columns>
                        <asp:BoundField DataField="product_name" HeaderText="Name" />
                        <asp:BoundField DataField="product_price" HeaderText="Price" />
                        <asp:BoundField DataField="product_quantity" HeaderText="Quantity" />
                        <asp:BoundField DataField="total_price" HeaderText="Total" />
                    </Columns>
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle ForeColor="#003399" HorizontalAlign="Left" BackColor="#99CCCC" />
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />
                </asp:GridView>
            </td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>
                <br />
            </td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style8">
                <asp:Label ID="Label5" runat="server" Font-Italic="True" Font-Size="Large" ForeColor="Black" Text="Grand Total :"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="Medium" ForeColor="Black" Text="Label"></asp:Label>
            </td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style8">
                &nbsp;</td>
            <td>
                <br />
            </td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style8">
                <asp:Label ID="Label19" runat="server" Font-Size="Large" ForeColor="Black" Text="Account Already Exists         :  "></asp:Label>
                </td>
            <td>
                <asp:ImageButton ID="ImageButton1" runat="server" CssClass="auto-style11" Height="72px" ImageUrl="~/NewFolder1/buyproduct.jpg" OnClick="ImageButton1_Click" Width="278px" />
                <br />
            </td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style8">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style8">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
            <td class="auto-style8">
                <asp:Label ID="Label20" runat="server" Font-Size="Large" ForeColor="Black" Text="New User Click Here     :"></asp:Label>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" BackColor="White" BorderStyle="Double" Font-Bold="True" Font-Size="Medium" ForeColor="Black" OnClick="Button1_Click" Text="Add Account Details" Height="54px" Width="284px" />
            </td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style2">
                <asp:Panel ID="Panel1" runat="server" Height="163px" Visible="False" Width="677px">
                    <table class="auto-style6">
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label12" runat="server" Font-Bold="False" Font-Size="Medium" ForeColor="Black" Text="Account Number"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label13" runat="server" Font-Size="Medium" ForeColor="Black" Text="Account Type"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style7">
                                <asp:Label ID="Label14" runat="server" Font-Size="Medium" ForeColor="Black" Text="Balance Amount"></asp:Label>
                            </td>
                            <td class="auto-style7">
                                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style9"></td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style10"></td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>
                <asp:Button ID="Button2" runat="server" BackColor="White" BorderColor="White" Font-Bold="True" Font-Italic="False" Font-Size="Medium" ForeColor="Black" OnClick="Button2_Click" Text="OK" Visible="False" Width="280px" Height="50px" />
            </td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>
                <asp:Label ID="Label15" runat="server" Font-Italic="True" Font-Size="Large" ForeColor="Black" Text="Label" Visible="False"></asp:Label>
            </td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
    </table>
</asp:Content>

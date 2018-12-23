<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Parcel.aspx.cs" Inherits="ParseTheParcel.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">   
   
    <div>
     <table border ="0">
        <thead>
           <th colspan="2"> Please enter details </th>
        </thead>
        <tr>
            <td style="width: 192px">Lenght (mm)</td>
            <td style="width: 265px">
        <asp:TextBox ID="txtLen" runat="server" style="margin-left: 0px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 192px">Breadth (mm)</td>
            <td style="width: 265px">
        <asp:TextBox ID="txtBrd" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 192px">Height (mm)</td>
            <td style="width: 265px">
        <asp:TextBox ID="txtHgt" runat="server" ></asp:TextBox>
            </td>
        </tr>
        <td style="width: 192px">Weight (kg)</td>
        <td style="width: 265px">
        <asp:TextBox ID="txtwght" runat="server"></asp:TextBox></td>
        <tr>
            <td colspan="2">
                <asp:Button ID="Button1" runat="server" Text="Button"  OnClick="Button1_Click" />
            </td>
        </tr>
        </table>
    </div>
    <div>
         <table>
         <tr>
            <td style="width: 194px">           
                <asp:Label ID="Label1" runat="server" Text="Parcel Type" Visible="False"></asp:Label>
            </td>
             <td>
                 <asp:Label ID="lblParcelType" runat="server" Visible="False" ></asp:Label>                
            </td>
        </tr>
         <tr>
            <td style="width: 194px">              
                <asp:Label ID="Label2" runat="server" Text="Parcel Cost $" Visible="False"></asp:Label>                
           </td>
            <td>
                 <asp:Label ID="lblParcelCost" runat="server" Visible="False" ></asp:Label>                
            </td>
        </tr>
        <tr>
             <td style="width: 194px">
                 <asp:Label ID="Label3" runat="server" Visible="False" ></asp:Label>                
            </td>
        </tr>
    </table>
    </div>    
</asp:Content>

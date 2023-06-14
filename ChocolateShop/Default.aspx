<%@ Page Title="Chocolates" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChocolateShop._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <h1><%:Title %></h1>

    <h2>Choose Chocolate!</h2>
    <p class="lead">Browse the offer and order!</p>

    <div>
        <table style="width:75%">
            <tr>
                <td style="width:435px;font-size:large" class="text-right">
                    You can choose from the best quality chocolates
                </td>
                <td class="text-center">
                    <asp:Image ID="Image1" ImageUrl="~/Image/StartChocolate.jpg" runat="server"
                        height="180px" Width="270px" />
                </td>
            </tr>
        </table>
    </div>

</asp:Content>

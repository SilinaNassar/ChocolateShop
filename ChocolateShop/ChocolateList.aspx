<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChocolateList.aspx.cs" Inherits="ChocolateShop.ChocolateList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section>
        <div>
            <hgroup>
                <h2><%:Page.Title %></h2>
            </hgroup>
            <asp:ListView ID="chocList" runat="server" DataKeyNames="ChocolateId"
                GroupItemCount="5" ItemType="ChocolateShop.Models.Chocolate" SelectMethod="ChocolateList_GetData">
                <EmptyDataTemplate>
                    <table>
                        <tr>
                            <td>No data</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
                    <td />
                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                    <td runat="server">
                        <table>
                            <tr>
                              <td>
                                <img
                                  src="/Catalog/<%#:Item.Image%>" width="130" height="130" style="border: solid" />
                              </td>
                            </tr>
                            <tr>
                            <td>
                               <span>
                                   <%#:Item.ChocolateName %>
                               </span>
                                <br />
                                <a href="/OrderPage.aspx?chococode=<%#:Item.ChocolateId %>">
                                    <span class="ListItem"><b>Order</b></span>
                                </a>
                            </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        </p>
                    </td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table style="width:100%;">
                        <tbody>
                            <tr>
                                <td>
                                    <table id="groupPlaceholderContainer" runat="server" style="width:100%">
                                        <tr id="groupPlaceholder"></tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                            </tr>
                            <tr></tr>
                        </tbody>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
        </div>
    </section>

</asp:Content>

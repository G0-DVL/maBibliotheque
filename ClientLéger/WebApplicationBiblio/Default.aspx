<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplicationBiblio._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">



    <div class="container-fluid">
	    <div class="row">
		    <div class="col-md-4">
                <table>
                    <tbody>
                        <tr>
                            <td>
                                <asp:Label ID="LabelTitre" runat="server" Text="Titre : "></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBoxTitre" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="LabelAnneeParution" runat="server" Text="AnneeParution : "></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBoxAnneeParution" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="LabelAuteur" runat="server" Text="Auteur : "></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="DropDownListAuteur" runat="server" OnSelectedIndexChanged="DropDownListAuteur_SelectedIndexChanged"></asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="LabelGenre" runat="server" Text="Genre : "></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="DropDownListGenre" runat="server"></asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="LabelEmplacement" runat="server" Text="Emplacement : "></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="DropDownListEmplacement" runat="server"></asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Button ID="ButtonRechercher" runat="server" OnClick="ButtonRechercher_Click" Text="Rechercher" />
                            </td>
                        </tr>
                    </tbody>
                </table>
                
		    </div>
		    <div class="col-md-8">
                <asp:GridView ID="GridViewLivre" runat="server" AllowSorting="True" OnSorting="GridViewLivre_Sorting" ViewStateMode="Enabled" Width="100%" CssClass="Table"></asp:GridView>
		    </div>
		    <div class="col-md-12">
                <asp:GridView ID="GridView1" runat="server" AllowSorting="True" OnSorting="GridViewLivre_Sorting" ViewStateMode="Enabled" Width="100%" CssClass="Table"></asp:GridView>
		    </div>
		    <div class="col-md-12">
                <asp:GridView ID="GridView2" runat="server" AllowSorting="True" OnSorting="GridViewLivre_Sorting" ViewStateMode="Enabled" Width="100%"></asp:GridView>
		    </div>
	    </div>
    </div>
</asp:Content>

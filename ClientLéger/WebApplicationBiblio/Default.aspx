﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplicationBiblio._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
	    <div class="row">
		    <div class="col-md-12">
			    <div class="jumbotron well">
				    <h2>
					    Bienvenue à la bibliothèque BLIBLI YO !
				    </h2>
			    </div>
		    </div>
		    <div class="col-md-12">
                <hr />
                
                <p><%
                    if (GridViewLivre.Rows.Count > 0) {
                        Response.Write(GridViewLivre.Rows.Count + " ");
                        if (GridViewLivre.Rows.Count > 1) {
                            Response.Write("résultats correspondent à votre recherche");
                        }
                        else {
                            Response.Write("résultat correspond à votre recherche");
                        }

                        if("" != ViewState["orderBy"].ToString()) {
                            Regex rRegex = new Regex(";([^=]+)=[AD]");
                            Response.Write(", ordonné par " + rRegex.Replace(ViewState["orderBy"].ToString(), ", $1").Substring(2));
                        }
                                                       %></p>
                <asp:GridView ID="GridViewLivre" runat="server" AllowSorting="True" OnSorting="GridViewLivre_Sorting" ViewStateMode="Enabled" Width="100%" CssClass="center-table"></asp:GridView>
                <hr />
                        <%
                    }
                    else {
                            Response.Write("Veuillez saisir un élément de recherche : </p>");
                    } %>
		    </div>
		    <div class="col-md-12">
                <table class="center-table">
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
                                <asp:DropDownList ID="DropDownListAuteur" runat="server"></asp:DropDownList>
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
	    </div>
    </div>
</asp:Content>

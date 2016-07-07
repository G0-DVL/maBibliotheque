using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationBiblio
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (maBibliothequeEntities monContext = new maBibliothequeEntities())
            {
                if (0 == DropDownListAuteur.Items.Count)
                {
                    var oAuteurQuery = from tableAuteur in monContext.auteurs
                                       select tableAuteur;
                    var aAuteurList = oAuteurQuery.ToList();
                    DropDownListAuteur.Items.Add(new ListItem("Sélectionnez un auteur", ""));
                    foreach (auteur oAuteur in aAuteurList)
                    {
                        DropDownListAuteur.Items.Add(new ListItem(oAuteur.auteur_prenom + " " + oAuteur.auteur_nom, oAuteur.auteur_ID.ToString()));
                    }
                }

                if (0 == DropDownListGenre.Items.Count)
                {
                    var oGenreQuery = from tableGenre in monContext.genres
                                      select tableGenre;
                    var aGenreList = oGenreQuery.ToList();
                    DropDownListGenre.Items.Add(new ListItem("Sélectionnez un genre", ""));
                    foreach (genre oGenre in aGenreList)
                    {
                        DropDownListGenre.Items.Add(new ListItem(oGenre.genre_libelle, oGenre.genre_ID.ToString()));
                    }
                }

                if (0 == DropDownListEmplacement.Items.Count)
                {
                    var oEmplacementQuery = from tableEmplacement in monContext.emplacements
                                            select tableEmplacement;
                    var aEmplacementList = oEmplacementQuery.ToList();
                    DropDownListEmplacement.Items.Add(new ListItem("Sélectionnez un emplacement", ""));
                    foreach (emplacement oEmplacement in aEmplacementList)
                    {
                        DropDownListEmplacement.Items.Add(new ListItem(oEmplacement.emplacement_libelle, oEmplacement.emplacement_ID.ToString()));
                    }
                }
            }
        }

        protected void ButtonRechercher_Click(object sender, EventArgs e)
        {
            loadGridViewLivre();
        }

        protected void loadGridViewLivre(Boolean bReinitialiseFonctionDeTri = true)
        {
            if (true == bReinitialiseFonctionDeTri)
            {
                ViewState["orderBy"] = "";
            }

            using (maBibliothequeEntities monContext = new maBibliothequeEntities())
            {

                var oQuery = from tableLivre in monContext.livres
                             join tableGenre in monContext.genres on tableLivre.genre_ID equals tableGenre.genre_ID
                             join tableAuteur in monContext.auteurs on tableLivre.auteur_ID equals tableAuteur.auteur_ID
                             join tableEmplacement in monContext.emplacements on tableLivre.emplacement_ID equals tableEmplacement.emplacement_ID
                             select new
                             {
                                 tableLivre.livre_ID,
                                 tableLivre.livre_titre,
                                 tableLivre.livre_annee_parution,
                                 tableGenre.genre_ID,
                                 tableGenre.genre_libelle,
                                 tableAuteur.auteur_ID,
                                 tableAuteur.auteur_nom,
                                 tableAuteur.auteur_prenom,
                                 tableEmplacement.emplacement_ID,
                                 tableEmplacement.emplacement_libelle
                             };
                if ("" != TextBoxTitre.Text)
                {
                    oQuery = oQuery.Where(tableLivre => tableLivre.livre_titre.Contains(TextBoxTitre.Text));
                }
                if ("" != TextBoxAnneeParution.Text)
                {
                    int iYear = int.Parse(TextBoxAnneeParution.Text);
                    oQuery = oQuery.Where(tableLivre => tableLivre.livre_annee_parution >= new DateTime(iYear, 1, 1));
                }
                if ("" != DropDownListAuteur.SelectedValue)
                {
                    oQuery = oQuery.Where(tableLivre => tableLivre.auteur_ID.ToString() == DropDownListAuteur.SelectedValue);
                }
                if ("" != DropDownListGenre.SelectedValue)
                {
                    oQuery = oQuery.Where(tableLivre => tableLivre.genre_ID.ToString() == DropDownListGenre.SelectedValue);
                }
                if ("" != DropDownListEmplacement.SelectedValue)
                {
                    oQuery = oQuery.Where(tableLivre => tableLivre.emplacement_ID.ToString() == DropDownListEmplacement.SelectedValue);
                }

                if ("" != ViewState["orderBy"].ToString())
                {
                    foreach (string sOrderByString in ViewState["orderBy"].ToString().Split(';').Skip(1))
                    {
                        string sSortExpression = sOrderByString.Substring(0, sOrderByString.IndexOf('='));
                        string sSortDirection = sOrderByString.Substring(sOrderByString.IndexOf('=') + 1);

                        switch (sSortExpression)
                        {
                            case "Titre":
                                if ("A" == sSortDirection)
                                    oQuery = oQuery.OrderBy(tableLivre => tableLivre.livre_titre);
                                else
                                    oQuery = oQuery.OrderByDescending(tableLivre => tableLivre.livre_titre);
                                break;
                            case "Année":
                                if ("A" == sSortDirection)
                                    oQuery = oQuery.OrderBy(tableLivre => tableLivre.livre_annee_parution);
                                else
                                    oQuery = oQuery.OrderByDescending(tableLivre => tableLivre.livre_annee_parution);
                                break;
                            case "Genre":
                                if ("A" == sSortDirection)
                                    oQuery = oQuery.OrderBy(tableLivre => tableLivre.genre_libelle);
                                else
                                    oQuery = oQuery.OrderByDescending(tableLivre => tableLivre.genre_libelle);
                                break;
                            case "Auteur":
                                if ("A" == sSortDirection)
                                    oQuery = oQuery.OrderBy(tableLivre => tableLivre.auteur_prenom + " " + tableLivre.auteur_nom);
                                else
                                    oQuery = oQuery.OrderByDescending(tableLivre => tableLivre.auteur_prenom + " " + tableLivre.auteur_nom);
                                break;
                            case "Emplacement":
                                if ("A" == sSortDirection)
                                    oQuery = oQuery.OrderBy(tableLivre => tableLivre.emplacement_libelle);
                                else
                                    oQuery = oQuery.OrderByDescending(tableLivre => tableLivre.emplacement_libelle);
                                break;
                            default:
                                Response.Write("FAIL ON Sorting " + sSortDirection + " for " + sSortExpression);
                                break;
                        }
                    }
                }

                var aListLivre = oQuery.AsEnumerable().Select(o => new {
                    Titre = o.livre_titre,
                    Année = o.livre_annee_parution,
                    Genre = o.genre_libelle,
                    Auteur = o.auteur_prenom + " " + o.auteur_nom,
                    Emplacement = o.emplacement_libelle
                }).ToList();

                GridViewLivre.DataSource = aListLivre;
                GridViewLivre.DataBind();
                GridView1.DataSource = aListLivre;
                GridView1.DataBind();
                GridView2.DataSource = aListLivre;
                GridView2.DataBind();
            }

        }
        private string getColumnSortExpression(string sColumnName)
        {
            return "LivreSort" + sColumnName.Substring(sColumnName.IndexOf("_"));
        }

        //  Gère la variable ViewState pour permettre le tri du résultat de la requête
        protected void GridViewLivre_Sorting(object sender, GridViewSortEventArgs e)
        {
            //  Response.Write(e.SortDirection + " / " + e.SortExpression + "<br/>");
            string sExpressiontoFind = ";" + e.SortExpression + "=";
            string sSortDirection = "A";
            int iExpressionPosition = ViewState["orderBy"].ToString().IndexOf(sExpressiontoFind);
            if (-1 != iExpressionPosition)
            {
                sSortDirection = ViewState["orderBy"].ToString().Substring(iExpressionPosition + sExpressiontoFind.Length, 1);
                ViewState["orderBy"] = ViewState["orderBy"].ToString().Replace(sExpressiontoFind + sSortDirection, "");
                sSortDirection = "A" == sSortDirection ? "D" : "A";
            }
            ViewState["orderBy"] = ViewState["orderBy"].ToString() + sExpressiontoFind + sSortDirection;
            loadGridViewLivre(false);
            //  Response.Write(ViewState["orderBy"] + "<hr/>");
        }

        protected void DropDownListAuteur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
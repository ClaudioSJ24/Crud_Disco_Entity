using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatAccess;
using Logic;

namespace Presentations
{
    public partial class InsertA : System.Web.UI.Page
    {
        private GenreController gc = new GenreController();
        AlbumController ac = new AlbumController();

        public AlbumController Ac { get => ac; set => ac = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            fillDropDL();
        }
        private void fillDropDL()
        {
            List<genresD> list = gc.allGenres();
            foreach (var g in list)
            {
                DropDownListG.Items.Add(g.nameG);
            }
        }

        protected void ButtonInsertA_Click(object sender, EventArgs e)
        {
            save();
        }

        private void save()
        {
            albumsD album = new albumsD()
            {
                nameA = TextBoxName.Text,
                author = TextBoxAuthor.Text,
                genre_id = idGenre(DropDownListG.SelectedItem.Value)

            };
            LabelResul.Text = Ac.saveA(album);
            TextBoxName.Text = "";
            TextBoxAuthor.Text = "";
        }

        private int idGenre(String name)
        {
            List<genresD> list = gc.allGenres();
            int id = 0;
            foreach (var g in list)
            {
                if (g.nameG == name)
                {
                    id = g.id;
                    break;
                }

            }
            return id;
        }

        protected void ButtonShowTA_Click(object sender, EventArgs e)
        {
            GridViewSA.Visible = true;
            GridViewSA.DataSource = "";
            GridViewSA.DataSource = Ac.getAll();
            GridViewSA.DataBind();
            //DropDownListG.Items.Clear();
            //fillDropDL();
            LabelResul.Text = "";
        }
    }
}
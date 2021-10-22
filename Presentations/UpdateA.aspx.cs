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
    public partial class UpdateA : System.Web.UI.Page
    {
        AlbumController ac = new AlbumController();

        public AlbumController Ac { get => ac; set => ac = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            fillDropDLA();
        }
        
        private void fillDropDLG()
        {
            GenreController gc = new GenreController();
            List<genresD> list = gc.allGenres();
            foreach (var g in list)
            {
                DropDownListG.Items.Add(g.nameG);
            }
        }

        private void fillDropDLA()
        {
            List<albumsD> list = Ac.getAll();
            foreach (var a in list)
            {
                DropDownListA.Items.Add(a.id.ToString());
            }


        }

        protected void DropDownListA_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_a = int.Parse(DropDownListA.SelectedItem.Value);
            List<albumsD> list = Ac.getAll();
            foreach (var a in list)
            {
                if (a.id == id_a)
                {
                    TextBoxName.Text = a.nameA;
                    TextBoxAuthor.Text = a.author;
                    fillDropDLG();
                    break;
                }
            }
        }



        protected void ButtonUpdateA_Click(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            albumsD a = new albumsD();
            int a_id = int.Parse(DropDownListA.SelectedItem.Value);
            a.id = a_id;
            a.nameA = TextBoxName.Text;
            a.author = TextBoxAuthor.Text;
            a.genre_id = id_Genre(DropDownListG.SelectedItem.Value);
            LabelResul.Text = Ac.updateA(a);
            TextBoxName.Text = "";
            TextBoxAuthor.Text = "";
            DropDownListA.Items.Clear();
            fillDropDLA();
            DropDownListG.Items.Clear();


        }

        private int id_Genre(string value)
        {
            GenreController gc = new GenreController();
            List<genresD> list = gc.allGenres();
            int id_g = 0;
            foreach (var g in list)
            {
                if (g.nameG == value)
                {
                    id_g = g.id;
                    break;
                }
            }
            return id_g;
        }

        protected void ButtonShowTA_Click(object sender, EventArgs e)
        {
            GridViewSA.Visible = true;
            GridViewSA.DataSource = Ac.getAll();
            GridViewSA.DataBind();
            LabelResul.Text = "";
            TextBoxName.Text = "";
            TextBoxAuthor.Text = "";
            DropDownListA.Items.Clear();
            fillDropDLA();
            DropDownListG.Items.Clear();

        }
        protected void DropDownListG_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
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
    public partial class UpdateG : System.Web.UI.Page
    {
        GenreController gc = new GenreController();

        public GenreController Gc { get => gc; set => gc = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            fillDropDownList();
        }
        private void fillDropDownList()
        {

            List<genresD> list = Gc.allGenres();

            foreach (var g in list)
            {
                DropDownListG.Items.Add(g.id.ToString());
            }


        }

        protected void ButtonUpdateG_Click(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            genresD g = new genresD();
            int id = int.Parse(DropDownListG.SelectedItem.Value);
            g.id = id;
            String name = TextBoxGenreD.Text;
            g.nameG = name;
            LabelResul.Text = Gc.updateGenre(g);
            DropDownListG.Items.Clear();
            fillDropDownList();
            TextBoxGenreD.Text = "";

        }

        protected void ButtonShowTG_Click(object sender, EventArgs e)
        {
            GridViewUG.Visible = true;
            GridViewUG.DataSource = "";
            GridViewUG.DataSource = Gc.allGenres();
            GridViewUG.DataBind();
            DropDownListG.Items.Clear();
            fillDropDownList();
            TextBoxGenreD.Text = "";

        }

        protected void DropDownListG_SelectedIndexChanged(object sender, EventArgs e)
        {
            int item = Convert.ToInt16(DropDownListG.SelectedItem.Value);
            List<genresD> list = Gc.allGenres();
            foreach (var g in list)
            {
                if (g.id == item)
                {
                    TextBoxGenreD.Text = g.nameG;
                }
            }

            LabelResul.Text = "";
        }
    }
}
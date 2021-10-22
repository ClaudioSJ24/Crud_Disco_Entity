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
    public partial class DeleteG : System.Web.UI.Page
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
            foreach (genresD g in list)
            {
                DropDownListGen.Items.Add(g.id.ToString());

            }
        }
        //boton para eliminar
        protected void ButtonDeleteG_Click(object sender, EventArgs e)
        {
            delete();

        }

        private void delete()
        {
            genresD g = new genresD();
            int id = int.Parse(DropDownListGen.SelectedItem.Value);
            g.id = id;
            LabelResul.Text = Gc.removeGenre(g);
            TextBoxGenreD.Text = "";
            DropDownListGen.Items.Clear();
            fillDropDownList();
        }
        //botón para llenar gridview
        protected void ButtonShowTG_Click(object sender, EventArgs e)
        {
            GridViewDG.Visible = true;
            GridViewDG.DataSource = "";
            GridViewDG.DataSource = Gc.allGenres();
            GridViewDG.DataBind();
            DropDownListGen.Items.Clear();
            fillDropDownList();
        }


        //método de propiedad dropdownlist para asignar género a textbox
        protected void DropDownListGen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int item = Convert.ToInt16(DropDownListGen.SelectedItem.Value);
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
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
    public partial class InsertG : System.Web.UI.Page
    {
        GenreController gc = new GenreController();

        public GenreController Gc { get => gc; set => gc = value; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButtonSaveG_Click(object sender, EventArgs e)
        {
            saveG();

        }

        private void saveG()
        {
            genresD g = new genresD()
            {
                nameG = TextBoxGenre.Text
            };


            LabelResul.Text = Gc.addGenre(g);
            TextBoxGenre.Text = "";
        }

        protected void ButtonShowTG_Click(object sender, EventArgs e)
        {
            GridViewSG.Visible = true;
            GridViewSG.DataSource = Gc.allGenres();
            GridViewSG.DataBind();

        }
    }
}
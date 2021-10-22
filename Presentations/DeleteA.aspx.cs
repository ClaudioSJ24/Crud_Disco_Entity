using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logic;
using DatAccess;

namespace Presentations
{
    public partial class DeleteA : System.Web.UI.Page
    {
        private AlbumController ac = new AlbumController();
        protected void Page_Load(object sender, EventArgs e)
        {
            fillDropDL();
        }
        private void fillDropDL()
        {
            List<albumsD> list = ac.getAll();
            foreach (var a in list)
            {
                DropDownListA.Items.Add(a.id.ToString());
            }
        }

        protected void DropDownListA_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_a = int.Parse(DropDownListA.SelectedItem.Value);
            List<albumsD> list = ac.getAll();
            foreach (var a in list)
            {
                if (a.id == id_a)
                {
                    TextBoxName.Text = a.nameA;
                    TextBoxAuthor.Text = a.author;
                    TextBoxGenre.Text = a.genre_id.ToString();
                    break;
                }

            }
        }

        protected void ButtonDeleteA_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void delete()
        {
            albumsD a = new albumsD();
            int id_a = int.Parse(DropDownListA.SelectedItem.Value);
            a.id = id_a;
            LabelResul.Text = ac.deleteA(a);
            TextBoxAuthor.Text = "";
            TextBoxName.Text = "";
            TextBoxGenre.Text = "";
            DropDownListA.Items.Clear();
            fillDropDL();
        }

        protected void ButtonShowTA_Click(object sender, EventArgs e)
        {
            GridViewSA.Visible = true;
            GridViewSA.DataSource = ac.getAll();
            GridViewSA.DataBind();
            LabelResul.Text = "";
            DropDownListA.Items.Clear();
            fillDropDL();

        }
    }
}
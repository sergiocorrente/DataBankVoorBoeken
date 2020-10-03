using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBankVoorBoeken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateData()
        {


            int selector = Convert.ToInt32(lstBoeken.SelectedValue);
            labId.Text = $"{selector}";
            labAuteur.Text = "";

            lablPagina.Text = "";

            using (BoekenEntities ctx = new BoekenEntities())
            {
                var book = ctx.Boekens.Where(b => b.id == selector);
                //---Join Book with Publisher
                var pubJoin = book
                    .Join(ctx.Uitgeverijens,
                    b => b.uitgeverld,

                    p => p.id,
                    (b, p) => new
                    { b, p });
                //--Join Book with Genre
                var genreJoin = book
                    .Join(ctx.BoekenGenres,
                    b => b.id,
                    bg => bg.Boekid,
                    (b, bg) => new { b, bg })
                    .Join(ctx.Genres,
                    bg2 => bg2.bg.Genreid,
                    g => g.id,
                    (bg2, g) => new { bg2, g });

            
                var authorJoin = book
                    .Join(ctx.BoekenAuteurs,
                    b => b.id,
                    ba => ba.BoekId,
                    (b, ba) => new { b, ba })
                    .Join(ctx.Auteurs,
                    ba2 => ba2.ba.Auteurid,
                    a => a.id,
                    (ba2, a) => new { ba2, a });

                foreach (var item in pubJoin)
                {

                    gbxGegevens.Text = $"{item.b.Title}";
                    lablPagina.Text = $"{item.b.AantalPaginas}";
                    labPublicatie.Text = $"{item.b.Publicatie}";
                    labScore.Text = $"{item.b.Score}";
                    labUigever.Text = $"{item.p.Naam}";

                }
                foreach (var item in genreJoin)
                {
                    labGenre.Text = $"{item.g.Genre1}";
                }
                foreach (var item in authorJoin)
                {
                    labAuteur.Text = ($"{item.a.Voornaam} {item.a.Achternaam}");
                }
            }


        }
        private void LoadBookList()
        {
            using (BoekenEntities ctx = new BoekenEntities())
            {
                var booklist = ctx.Boekens.Select(x => x).ToList();
                lstBoeken.DisplayMember = "Title";
                lstBoeken.ValueMember = "id";
                lstBoeken.DataSource = booklist;
            }

        }

        private void ShowSelectionForm()
        {
            addForm formAdd = new addForm();

            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                switch (formAdd.Selection)
                {
                    case "Boek":
                        ShowBookForm();
                        break;
                    case "Auteur":
                       ShowAuteurForm();
                        break;
                    case "Genre":
                       ShowGenreForm();
                        break;
                    case "Uitgeverij":
                        ShowPublisherForm();
                        break;
                    default:
                        MessageBox.Show("Error");
                        break;
                }
            }

        }



        private void ShowBookForm()
        {
           addBook formAddBook = new addBook();


            if (formAddBook.ShowDialog() == DialogResult.OK)
            {
                LoadBookList();
            }

        }

        private void ShowAuteurForm()
        {
            addAuteur auteurAdd = new addAuteur();


            if (auteurAdd.ShowDialog() == DialogResult.OK)
            {
                LoadBookList();
            }

        }

        private void ShowPublisherForm()
        {
            addUitgever uitgeverijAdd = new addUitgever();


            if (uitgeverijAdd.ShowDialog() == DialogResult.OK)
            {
                LoadBookList();
            }

        }

        private void ShowGenreForm()
        {
            addGenre genreAdd = new addGenre();


            if (genreAdd.ShowDialog() == DialogResult.OK)
            {
                LoadBookList();
            }

        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            LoadBookList();
        }

        private void lstBoeken_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            ShowSelectionForm();
        }



        //private void btnToevoegen_Click(object sender, EventArgs e)
        //{
        //    FormAddBook formAddBook = new FormAddBook(false);
        //    formAddBook.Show();
        //}
    }
}
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
    public partial class addBook : Form
    {
        public string Title;
        public int UitgeverId;
        public int Jaar;
        public int Paginas;
        public int Score;
        //public List<string> Authors;
        public bool IsChanging;
       
        public addBook()
        {   
            InitializeComponent();
        }

        private void addBook_Load(object sender, EventArgs e)
        {
            LoadPublisherList();
            LoadAuteurList();
            LoadGenreList();

            if (IsChanging)
            {
                ChangeTexts();
            }
        }
        private void ChangeTexts()
        {
            Text = "Boek Bewerken...";
            BtnAdd.Text = "Bewerk";
            txtTitle.Text = Title;
            numPages.Value = Paginas;
            numYear.Value = Jaar;
            numScore.Value = Score;
            cbxPublisher.SelectedValue = UitgeverId;
        }

        private void LoadAuteurList()
        {
            using (BoekenEntities ctx = new BoekenEntities())
            {
                var autList = ctx.Auteurs.Select(x => new { Id = x.id, Naam = x.Voornaam + " " + x.Achternaam }).ToList();
                foreach (var author in autList)
                {
                    lvAuthors.Items.Add(author.Naam);
                }
            }

        }

        private void LoadPublisherList()
        {
            using (BoekenEntities ctx = new BoekenEntities())
            {
                var PubList = ctx.Uitgeverijens.Select(x => x).ToList();
                cbxPublisher.DisplayMember = "Naam";
                cbxPublisher.ValueMember = "Id";
                cbxPublisher.DataSource = PubList;
            }
        }

        private void LoadGenreList()
        {
            using (BoekenEntities ctx = new BoekenEntities())
            {
                var genreList = ctx.Genres.Select(x => x).ToList();
                foreach (var genre in genreList)
                {
                    lvGenres.Items.Add(genre.Genre1);
                }

            }
        }

        private void AddNewBook()
        {
            using (BoekenEntities ctx = new BoekenEntities())
            {
                //--Nieuw boek aanmaken
                Boeken newBook = new Boeken()
                {
                    Title = txtTitle.Text,
                    AantalPaginas = (int)numPages.Value,
                    Publicatie = (int)numYear.Value,
                    uitgeverld = (int)cbxPublisher.SelectedValue,
                    Score = (int)numScore.Value
                };
                ctx.Boekens .Add(newBook);
                ctx.SaveChanges();

                //--Nieuw Book-Auteur Tussentabel  entry voor elke auteur
                foreach (ListViewItem author in lvAuthors.CheckedItems)
                {
                    int entry = ctx.Auteurs.Where(a => (a.Voornaam + " " + a.Achternaam) == author.Text).Select(x => x.id).FirstOrDefault();

                    ctx.BoekenAuteurs.Add(new BoekenAuteur()
                    {
                        BoekId = newBook.id,
                        Auteurid = entry
                    });
                }

                //--Nieuw Book-Genre Tussentabel  entry voor elk genre
                foreach (ListViewItem genre in lvGenres.CheckedItems)
                {
                    int entry = ctx.Genres.Where(a => a.Genre1 == genre.Text).Select(x => x.id).FirstOrDefault();

                    ctx.BoekenGenres.Add(new BoekenGenre()
                    {
                        Boekid = newBook.id,
                        Genreid = entry
                    });
                }
                ctx.SaveChanges();
            }

        }
        private void ChangeBook()
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (IsChanging)
            {
                ChangeBook();
            }
            else
            {
                AddNewBook();
            }

            DialogResult = DialogResult.OK;
        }
    }
    
}



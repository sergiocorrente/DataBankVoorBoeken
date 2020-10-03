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
    public partial class addAuteur : Form
    {
        public addAuteur()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using(BoekenEntities ctx= new BoekenEntities())
            {
                ctx.Auteurs.Add(new Auteur() { Voornaam = txtvoornaam.Text, Achternaam = txtFAchternaam.Text });
                ctx.SaveChanges();
            }
            DialogResult = DialogResult.OK;
        }
    }
}

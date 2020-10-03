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
    public partial class addGenre : Form
    {
        public addGenre()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (BoekenEntities ctx = new BoekenEntities())
            {
                ctx.Genres.Add(new Genre() {Genre1=txtGenre.Text});
                ctx.SaveChanges();
            }
            DialogResult = DialogResult.OK;
        }
    }
 }

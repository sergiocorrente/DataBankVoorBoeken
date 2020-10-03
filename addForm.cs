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
    public partial class addForm : Form
    {
        public string Selection = "";
        string[] selectArr = new string[] { "Boek", "Auteur", "Genre", "Uitgeverij" };
        public addForm()
        {
            InitializeComponent();
        }

        private void addForm_Load(object sender, EventArgs e)
        {
            cbxToevoegen.Items.AddRange(selectArr);
            cbxToevoegen.SelectedIndex = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Selection = cbxToevoegen.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
        }
    }
}

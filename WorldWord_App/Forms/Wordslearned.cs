using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldWord_DataLayer.Context;

namespace WorldWord_App.Forms
{
    public partial class Wordslearned : Form
    {
        public Wordslearned()
        {
            InitializeComponent();
        }

        private void Wordslearned_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        void Refresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                txtSearchL.Text = "";
                DGVViewAllwL.AutoGenerateColumns = false;
                DGVViewAllwL.DataSource = db.Learnrepository.GetAllWords();
            }
        }

        private void txtSearchL_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                DGVViewAllwL.DataSource = db.Learnrepository.SearchWords(txtSearchL.Text);
            }
        }

        private void btn_RefreshL_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btn_EditL_Click(object sender, EventArgs e)
        {
            if (DGVViewAllwL.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {

                }
            }
            else
            {
                MessageBox.Show("Please Select a Word", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_DeleteL_Click(object sender, EventArgs e)
        {
            if (DGVViewAllwL.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    if (MessageBox.Show("Are you sure to delete ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        int idword = int.Parse(DGVViewAllwL.CurrentRow.Cells[0].Value.ToString());
                        db.Learnrepository.DeleteWords(idword);
                        db.Save();
                        Refresh();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select a Word", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

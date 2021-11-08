using System;
using WorldWord_DataLayer.Context;
using System.Windows.Forms;
using WorldWord_DataLayer;

namespace WorldWord_App.Forms
{
    public partial class AllWords : Form
    {
        AddorEdit AE = new AddorEdit();
        public AllWords()
        {
            InitializeComponent();
        }

        private void AllWords_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        void Refresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                txtSearch.Text = "";
                DGViewAllW.AutoGenerateColumns = false;
                DGViewAllW.DataSource = db.WordRepository.GetAllWords();
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                DGViewAllW.DataSource = db.WordRepository.SearchWords(txtSearch.Text);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (DGViewAllW.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    if (MessageBox.Show("Are you sure to delete ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        int idword = int.Parse(DGViewAllW.CurrentRow.Cells[0].Value.ToString());
                        db.WordRepository.DeleteWords(idword);
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

        private void btn_AddNewWord_Click(object sender, EventArgs e)
        {
            AddorEdit frm = new AddorEdit();
            frm.ShowDialog();
            Refresh();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (DGViewAllW.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    int IDWord = int.Parse(DGViewAllW.CurrentRow.Cells[0].Value.ToString());
                    AddorEdit frm = new AddorEdit();
                    frm.id = IDWord;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        Refresh();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select a Word", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AddIlearned_Click(object sender, EventArgs e)
        {
            if (DGViewAllW.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    if (MessageBox.Show("Are you sure you want to add this word to your learner list?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        int idword = int.Parse(DGViewAllW.CurrentRow.Cells[0].Value.ToString());
                        string word = DGViewAllW.CurrentRow.Cells[1].Value.ToString();
                        string Translation = DGViewAllW.CurrentRow.Cells[2].Value.ToString();
                        learned learned = new learned()
                        {
                            Translation = Translation,
                            Word = word
                        };
                        db.Learnrepository.InsertWordstolearn(learned);
                        db.WordRepository.DeleteWords(idword);
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
using System;
using WorldWord_DataLayer.Context;
using WorldWord_DataLayer.Services;
using WorldWord_App.Forms;
using System.Windows.Forms;
using WorldWord_DataLayer;
using ValidationComponents;

namespace WorldWord_App.Forms
{
    public partial class AddorEdit : Form
    {
        public int id = 0;
        public AddorEdit()
        {
            InitializeComponent();
        }

        private void AddorEdit_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    this.Text = "Edit";
                    btn_save.Text = "Edit";
                    var word = db.WordRepository.GetWordsbyID(id);
                    txtTranslation.Text = word.Translation;
                    txtWord.Text = word.Word;
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    Words word = new Words()
                    {
                        Translation = txtTranslation.Text,
                        Word = txtWord.Text
                    };


                    if (id == 0)
                    {
                        db.WordRepository.InsertWords(word);
                    }
                    else
                    {
                        word.IDWord = id;
                        db.WordRepository.UpdateWords(word);
                    }

                    db.Save();
                }
                DialogResult = DialogResult.OK;
            }
        }
    }
}
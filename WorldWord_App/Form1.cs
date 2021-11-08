using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldWord_App.Forms;

namespace WorldWord_App
{
    public partial class WorldWord : Form
    {
        public WorldWord()
        {
            InitializeComponent();
        }

        private void WorldWord_Load(object sender, EventArgs e)
        {

        }

        private void btn_AllWord_Click(object sender, EventArgs e)
        {
            AllWords frmAllWord = new AllWords();
            frmAllWord.ShowDialog();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_wordslearned_Click(object sender, EventArgs e)
        {
            Wordslearned frm = new Wordslearned();
            frm.ShowDialog();
        }
    }
}

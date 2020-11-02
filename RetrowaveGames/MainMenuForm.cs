using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetrowaveGames {
    public partial class MainMenuForm : Form {
        public MainMenuForm() {
            InitializeComponent();
        }

        private void tetrisBut_Click(object sender, EventArgs e) {
            TetrisForm tf = new TetrisForm();
            this.Hide();
            tf.Show();
        }

        private void snakeBut_Click(object sender, EventArgs e) {
            SnakeForm sf = new SnakeForm();
            this.Hide();
            sf.Show();
        }

        private void raceBut_Click(object sender, EventArgs e) {
            RaceForm rf = new RaceForm();
            this.Hide();
            rf.Show();
        }

        private void aboutBut_Click(object sender, EventArgs e) {
            AboutForm af = new AboutForm();
            af.Show();
        }
    }
}

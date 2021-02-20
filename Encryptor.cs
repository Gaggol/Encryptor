using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryptor
{
    public partial class Encryptor : Form
    {
        bool firstClick = false;
        bool muteErrors = false;
        string initialString = "";

        public Encryptor() {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e) {
            string txt = TextBox.Text;
            TextBox.Text = Program.Encrypt(txt, muteErrors);
            TextBox.ReadOnly = true;
            firstClick = true;
        }

        private void ResetButton_Click(object sender, EventArgs e) {
            TextBox.Text = "";
            TextBox.ReadOnly = false;
        }

        private void Form1_Load(object sender, EventArgs e) {
            initialString = TextBox.Text;
        }

        private void TextBox_Click(object sender, EventArgs e) {
            if(!firstClick) {
                TextBox.Text = "";
                firstClick = true;
            }
        }

        private void MuteErrors_CheckedChanged(object sender, EventArgs e) {
            if(MuteErrors.CheckState == CheckState.Checked) {
                muteErrors = true;
            } else {
                muteErrors = false;
            }
        }
    }
}

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
    public partial class Form1 : Form
    {
        bool firstClick = false;

        string initialString = "";

        public Form1() {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e) {
            string txt = TextBox.Text;
            TextBox.Text = Program.Encrypt(txt);
            TextBox.ReadOnly = true;
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
    }
}

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
        public Form1() {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e) {
            string txt = TextBox.Text;
            TextBox.Text = Program.Encrypt(txt);
            TextBox.ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Substring(0, 4) == "ISI:")
                label.Text = textBox.Text.Substring(4);
            else if (textBox.Text == "BESARKAN")
                label.Text = label.Text.ToUpper();
            else if (textBox.Text == "KECILKAN")
                label.Text = label.Text.ToLower();
            else if (textBox.Text == "SHOWN")
                label.Show();
            else if (textBox.Text == "HIDE")
                label.Hide();
            else if (textBox.Text.Substring(0, 6) == "WARNA:")
            {
                if (textBox.Text.Substring(6) == "MERAH")
                    label.ForeColor = Color.Red;
                else if (textBox.Text.Substring(6) == "BIRU")
                    label.ForeColor = Color.Blue;
                else if (textBox.Text.Substring(6) == "HIJAU")
                    label.ForeColor = Color.Green;
                else if (textBox.Text.Substring(6) == "DEFAULT")
                    label.ForeColor = Color.Black;
            }
            else if (textBox.Text == "RESTART")
                label.Text = "[EMPTY]";
            else
                MessageBox.Show("Syntax tidak terdaftar!", "ERROR");
        }
    }
}

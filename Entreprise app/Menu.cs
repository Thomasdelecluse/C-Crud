using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Entreprise_app
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 x = new Form1();
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 x = new Form2();
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 x = new Form3();
            x.Show();
        }

        private void keydown(object sender, PreviewKeyDownEventArgs e)
        {
            MessageBox.Show(e.KeyCode + "");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_курс_2_лаба
{
    public partial class str : Form
    {
        public str()
        {
            InitializeComponent();

            textBox1.Text = Properties.Settings.Default.str1.ToString();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string str1 = Convert.ToString(textBox1.Text);
            Properties.Settings.Default.str1 = str1;
            Properties.Settings.Default.Save();

            Reverse1(str1);
        }

        void Reverse1(string str1)
        {
            string[] words = str1.Split(' ');
            Array.Reverse(words);
            string str2 = string.Join(" ", words);
            textBox2.Text = str2;
        }

        private void выходToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            main form = new main();
            form.Show();
            this.Hide();
        }
    }
}

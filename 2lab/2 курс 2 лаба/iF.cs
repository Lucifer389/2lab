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
    public partial class iF : Form
    {
        public iF()
        {
            InitializeComponent();

            textBox1.Text = Properties.Settings.Default.h.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int h = Convert.ToInt32(textBox1.Text);
            Properties.Settings.Default.h = h;
            Properties.Settings.Default.Save();

            if (h < 1 || h > 9999)
            {
                MessageBox.Show("Введено неправильное значение");
                return;
            }
            string s = " ", a = " ";
            int n = h / 100;
            int k = h % 100;
            caseses1(s, n);
            caseses2(a, k);
            label_1if.Text = n.ToString();
            label_3if.Text = k.ToString();
        }
        void caseses1(string s, int n)
        {
            if (n % 10 == 1 && n != 11)
            {
                s = "рубль";
            }
            else
            {
                if (n % 10 >= 2 && n % 10 <= 4)
                {
                    s = "рубля";
                }
                else
                {
                    s = "рублей";
                }
            }
            label_2if.Text = s;
        }

        void caseses2(string a, int k)
        {
            if (k % 10 == 1 && k != 11) a = "копейка";
            if (k % 10 > 1 && k % 10 < 5 && k != 12 && k != 13 && k != 14) a = "копейки";
            if (k % 10 > 4 || k % 10 == 0) a = "копеек";
            label_4if.Text = a;
        }

        private void выходToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            main form = new main();
            form.Show();
            this.Hide();
        }
    }
}

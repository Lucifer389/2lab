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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        private void button_if_Click_1(object sender, EventArgs e)
        {
            //Создаем форму
            iF newForm = new iF();
            newForm.Show();
            this.Hide();
        }

        private void button_str_Click_1(object sender, EventArgs e)
        {
            //Создаем форму
            str newForm = new str();
            newForm.Show();
            this.Hide();
        }

        private void button_exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

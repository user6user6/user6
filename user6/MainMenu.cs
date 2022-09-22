using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user6
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        //создаём объект второй формы
        Redaktor redaktor = new Redaktor();
        private void button1_Click(object sender, EventArgs e)
        {
            //показываем форму
            redaktor.Show();
            //закрываем форму
            this.Close();
        }
    }
}

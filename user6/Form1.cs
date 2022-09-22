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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //создаём объект второй формы
        MainMenu mainmenu = new MainMenu();
        //создаём переменные для авторизации
        public string login, password;
        private void button1_Click(object sender, EventArgs e)
        {
            ///получаем вводимый логин и пароль
            login = textBox1.Text;
            password = textBox2.Text;
            //если логин и пароль правильный пропускаем дальше,если нет выводит сообщение об ошибке
            if(login=="inspector"&&password=="inspector")
            {
                //назначаем главную форму
                mainmenu.Owner = this;
                //показываем форму
                mainmenu.Show();
                //скрываем форму авторизации
                this.Hide();
            }
            else
            {
                label3.Text = "Неверный логин и/или пароль";
                //очищаем текстбоксы
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}

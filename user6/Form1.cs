﻿using System;
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
        private void button1_Click(object sender, EventArgs e)
        {
            //назначаем главную форму
            mainmenu.Owner = this;
            //показываем форму
            mainmenu.Show();
            //скрываем форму авторизации
            this.Hide();
        }
    }
}

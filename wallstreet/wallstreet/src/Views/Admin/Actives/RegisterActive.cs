﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wallstreet.src.Controllers;

namespace wallstreet.src.Views.Admin.ativos
{
    public partial class RegisterActive : Form
    {
        public RegisterActive()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveController activeController = new ActiveController();
            int result = activeController.Register(textBox1.Text, maskedTextBox1.Text, textBox3.Text, textBox4.Text);
            if (result == 1) Console.WriteLine("deu certo");
            else Console.WriteLine("deu erro");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinica_odontologica
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void tb_login_Click(object sender, EventArgs e)
        {
            tb_login.Text = "";
        }

        private void tb_senha_Click(object sender, EventArgs e)
        {
            tb_senha.Text = "";
            tb_senha.PasswordChar = '*';
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
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
    public partial class FormUsuario : Form
    {
        Usuarios objUsuario = new Usuarios();
        public int id_usuario;
        public FormUsuario(int id = 0)
        {
            if (id != 0)
            {
                this.id_usuario = id;
            }
            InitializeComponent();
        }

        private void bt_usuario_cadastrar_Click(object sender, EventArgs e)
        {
            this.objUsuario.setUsuarios(tb_usuario_nome.Text,tb_usuario_email.Text,2,tb_usuario_username.Text,tb_usuario_password.Text);
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            if (id_usuario > 0)
            {
                this.preencheUsuario(id_usuario);
            }
        }

        private void preencheUsuario(int id)
        { 
            DataTable rs = this.objUsuario.getUsuarioById(id);
            tb_usuario_nome.Text = rs.Rows[0].ItemArray[0].ToString();
            tb_usuario_email.Text = rs.Rows[0].ItemArray[1].ToString();
            tb_usuario_username.Text = rs.Rows[0].ItemArray[2].ToString();
            bt_usuario_cadastrar.Text = "Editar";
        }
    }
}

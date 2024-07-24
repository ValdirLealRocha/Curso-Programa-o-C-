﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFB_Academia
{
    public partial class frm_SQLite : Form
    {
        public frm_SQLite()
        {
            InitializeComponent();

            // chama o formulário frm_Login
            frm_Login frmLogin = new frm_Login(this); // manipula o construtor e passo o form atual frm_SQLite
            frmLogin.ShowDialog();
        }

        private void logOnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // abre o fomulário de 
            frm_Login frmLogin = new frm_Login(this);
            frmLogin.ShowDialog();
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // define os valores padrão...
            lbl_Acesso.Text = "0";
            lbl_Usuario.Text = "...";
            pcb_LedLogado.Image = Properties.Resources.led_vermelho;
            class_Global.nivel = 0;
            class_Global.logado = false;
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // valida usuário
            if (class_Global.logado)
            {
                // autorizado o uso do sistema...

            }
            else
            {
                MessageBox.Show("É Necessário Ter um Usuário Logado");
            }
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // valida usuário
            if (class_Global.logado)
            {
                // valida nível de acesso...
                if (class_Global.nivel >= 1) // 0 Básico, 1 Gerente, 2 Master
                {
                    // autorizado o uso do sistema...
                    frm_NovoUsuario frmNovoUsuario = new frm_NovoUsuario();
                    frmNovoUsuario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido, consulte seu Administrador do Sistema!");
                }

            }
            else
            {
                MessageBox.Show("É Necessário Ter um Usuário Logado");
            }
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // valida usuário
            if (class_Global.logado)
            {
                // valida nível de acesso...
                if (class_Global.nivel >= 1) // 0 Básico, 1 Gerente, 2 Master
                {
                    // autorizado o uso do sistema...

                }
                else
                {
                    MessageBox.Show("Acesso não permitido, consulte seu Administrador do Sistema!");
                }

            }
            else
            {
                MessageBox.Show("É Necessário Ter um Usuário Logado");
            }
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // valida usuário
            if (class_Global.logado)
            {
                // valida nível de acesso...
                if (class_Global.nivel >= 2) // 0 Básico, 1 Gerente, 2 Master
                {
                    // autorizado o uso do sistema...

                }
                else
                {
                    MessageBox.Show("Acesso não permitido, consulte seu Administrador do Sistema!");
                }

            }
            else
            {
                MessageBox.Show("É Necessário Ter um Usuário Logado");
            }
        }
    }
}

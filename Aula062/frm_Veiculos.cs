﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula062
{
    public partial class frm_Veiculos : Form
    {
        public frm_Veiculos(string sListaVeiculos)
        {
            InitializeComponent();

            //MessageBox.Show(sListaVeiculos);
            txt_ListaVeiculos.Text = sListaVeiculos;
        }
    }
}

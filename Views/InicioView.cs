﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class InicioView : Form
    {
        public InicioView()
        {
            InitializeComponent();
            this.SetVisibleCore(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pacienteBtn_Click(object sender, EventArgs e)
        {
            PacientesView tela =  new PacientesView();
            tela.Show();
            this.Hide();
        }

        private void InicioView_Load(object sender, EventArgs e)
        {

        }
    }
}

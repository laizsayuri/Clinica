﻿using System;
using System.Collections;
using System.Windows.Forms;

namespace Clinica
{
    public partial class PacientesView : Form
    {
        public PacientesView()
        {
            InitializeComponent();
            
        }

        public PacientesView(ArrayList pacientes)
        {
            InitializeComponent();
            listagem.DataSource = pacientes;

            foreach (Paciente p in pacientes)
            {
                MessageBox.Show(p.ToString());               
            }
        }

        // filtrar
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            InicioView inicio = new InicioView();
            inicio.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PacientesCriarView pacienteCriar = new PacientesCriarView();
            pacienteCriar.Show();
            Close();
        }
    }
}

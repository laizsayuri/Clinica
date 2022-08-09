﻿using System;
using System.Collections;
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
    public partial class PacientesEditarView : Form
    {
        
        //INTERVALO ATÉ 10:20
        
        
        public PacientesEditarView(object paciente)
        {
            InitializeComponent();
            Paciente p = (Paciente) paciente;
            this.codigoValor.Text = p.codp.ToString();
            this.nomeValor.Text = p.nome;
            this.idadeValor.Text = p.idade.ToString();
            this.cpfValor.Text = p.cpf;
            this.doencaValor.Text = p.doenca;
            this.cidadeValor.Text = p.cidade;
        }

        private void PacientesEditar_Load(object sender, EventArgs e)
        {

        }

        private void titulo_label_Click(object sender, EventArgs e)
        {

        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            paciente.codp = int.Parse(this.codigoValor.Text);
            paciente.nome = this.nomeValor.Text;
            paciente.idade = int.Parse(this.idadeValor.Text);
            paciente.cidade = this.cidadeValor.Text;
            paciente.cpf = this.cpfValor.Text;
            paciente.doenca = this.doencaValor.Text;

            ArrayList pacientes = new ArrayList();
            pacientes.Add(paciente);

            PacientesView listagem = new PacientesView(pacientes);
            listagem.Show();
            this.Close();
            
        }
    }
}

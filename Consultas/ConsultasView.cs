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

namespace Clinica.Consultas
{
    public partial class ConsultasView : Form
    {
        public ConsultasView()
        {
            InitializeComponent();
        }

        public ConsultasView(ArrayList consultas)
        {
            InitializeComponent();
            int x = 0;

            foreach (Consulta c in consultas)
            {
                this.listagem.Rows.Add();
                this.listagem.Rows[x].Cells[0].Value = c.Codm;
                this.listagem.Rows[x].Cells[1].Value = c.Codp;
                this.listagem.Rows[x].Cells[2].Value = c.Data;
                this.listagem.Rows[x].Cells[3].Value = c.Hora;                
                x++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InicioView inicio = new InicioView();
            inicio.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConsultasCriarView consultaCriar = new ConsultasCriarView();
            consultaCriar.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowindex = listagem.CurrentCell.RowIndex;

            string codm = listagem.Rows[rowindex].Cells[0].Value.ToString();
            string codp = listagem.Rows[rowindex].Cells[1].Value.ToString();
            string data = listagem.Rows[rowindex].Cells[2].Value.ToString();
            string hora = listagem.Rows[rowindex].Cells[3].Value.ToString();
            

            Consulta consulta = new Consulta();

            consulta.Codm = int.Parse(codm);
            consulta.Codp = int.Parse(codp);
            consulta.DataHora = DateTime.Parse(data + " " + hora);

            ConsultaController controller = new ConsultaController();
            controller.Alterar(consulta);
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowindex = listagem.CurrentCell.RowIndex;

            string codm = listagem.Rows[rowindex].Cells[0].Value.ToString();
            string codp = listagem.Rows[rowindex].Cells[1].Value.ToString();
            string data = listagem.Rows[rowindex].Cells[2].Value.ToString();
            string hora = listagem.Rows[rowindex].Cells[3].Value.ToString();

            Consulta consulta = new Consulta();

            consulta.Codm = int.Parse(codm);
            consulta.Codp = int.Parse(codp);
            consulta.DataHora = DateTime.Parse(data + " " + hora);            

            ConsultaController controller = new ConsultaController();
            controller.Deletar(consulta);

            Close();
        }
    }
}

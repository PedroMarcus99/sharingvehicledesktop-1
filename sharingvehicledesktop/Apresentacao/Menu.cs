﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sharingvehicledesktop.Apresentacao
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadastroCar car = new CadastroCar();
            car.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroMotorista motorista = new CadastroMotorista();
            motorista.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CadastroCombustivel abastecer = new CadastroCombustivel();
            abastecer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastroGasto gasto = new CadastroGasto();
            gasto.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();
            agenda.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            this.Close();
        }
    }
}

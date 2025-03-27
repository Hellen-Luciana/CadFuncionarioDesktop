using BusinessModelAtividades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessAtividades;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsForms_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var funcionario = new FuncionarioModel();
            funcionario.Nome = txtNome.Text;
            funcionario.Idade = Int32.Parse(txtIdade.Text);
            funcionario.CPF = txtCPF.Text;
            FuncionarioBusiness.Salvar(funcionario);

            LimparCampos();

            MessageBox.Show("Usuário salvo com sucesso");

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DataTable dt = FuncionarioBusiness.Mostrar();

            dataGridView1.DataSource = dt;


            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtIdade.Text = string.Empty;
            txtCPF.Text = string.Empty;
        }
    }
}

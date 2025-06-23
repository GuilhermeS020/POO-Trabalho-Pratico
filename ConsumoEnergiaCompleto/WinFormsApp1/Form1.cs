using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Consumidor> consumidores = new();

        public Form1()
        {
            InitializeComponent();
            CarregarDados();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var consumidor = new Consumidor
            {
                Nome = txtNome.Text,
                Documento = txtDocumento.Text
            };

            consumidores.Add(consumidor);
            SalvarDados();
            MessageBox.Show("Consumidor cadastrado.");
        }

        private void btnAdicionarConta_Click(object sender, EventArgs e)
        {
            var doc = txtBuscaDocumento.Text;
            var consumidor = consumidores.FirstOrDefault(c => c.Documento == doc);
            if (consumidor == null)
            {
                MessageBox.Show("Consumidor não encontrado.");
                return;
            }

            var conta = new ContaEnergia
            {
                Tipo = cmbTipo.Text,
                LeituraAnterior = double.Parse(txtAnterior.Text),
                LeituraAtual = double.Parse(txtAtual.Text)
            };

            consumidor.Contas.Add(conta);
            SalvarDados();

            MessageBox.Show($"Conta adicionada. Valor total: R$ {conta.ValorTotal():F2}");
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            var doc = txtBuscaDocumento.Text;
            var consumidor = consumidores.FirstOrDefault(c => c.Documento == doc);
            if (consumidor == null || consumidor.Contas.Count == 0)
            {
                MessageBox.Show("Nenhuma conta encontrada.");
                return;
            }

            var conta = consumidor.Contas.Last(); // última conta
            MessageBox.Show(
                $"Cliente: {consumidor.Nome}\n\n" + // <-- LINHA ADICIONADA AQUI
                $"Consumo: {conta.Consumo} kWh\n" +
                $"Total com impostos: R$ {conta.ValorTotal():F2}\n" +
                $"Sem impostos: R$ {conta.ValorComContribuicao():F2}"
            );
        }

        private void SalvarDados()
        {
            var json = JsonSerializer.Serialize(consumidores, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("dados.json", json);
        }

        private void CarregarDados()
        {
            if (File.Exists("dados.json"))
            {
                var json = File.ReadAllText("dados.json");
                consumidores = JsonSerializer.Deserialize<List<Consumidor>>(json) ?? new();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

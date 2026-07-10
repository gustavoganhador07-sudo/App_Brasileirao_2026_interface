using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabelaBrasileirao
{
    public partial class Atualizartimes : Form
    {
        public Atualizartimes()
        {
            InitializeComponent();
        }

        private async void cb_Serie_SelectedIndexChanged(object sender, EventArgs e)
        {
            string serie = cb_Serie.Text;

            switch (serie)
            {
                case "A":
                    await ConsultarSerieA();
                    break;
                case "B":
                    await ConsultarSerieB();
                    break;
                case "C":
                    await ConsultarSerieC();
                    break;
                case "D":
                    await ConsultarSerieD();
                    break;
                default:
                    MessageBox.Show("Selecione a série.");
                    break;
            }
        }

        private async Task ConsultarSerieA()
        {
            string apiUrl = ApiRotasController.ConsultarSerieA;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var dados = JsonConvert.DeserializeObject<List<ConsultarSerieAModel>>(jsonString);

                        dgvAtualizar.DataSource = dados;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar dados da API: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar à API: " + ex.Message);
                }
            }
        }

        private async Task ConsultarSerieB()
        {
            string apiUrl = ApiRotasController.ConsultarSerieB;
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var dados = JsonConvert.DeserializeObject<List<ConsultarSerieBModel>>(jsonString);
                        dgvAtualizar.DataSource = dados;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar dados da API: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar à API: " + ex.Message);
                }
            }

        }

        private async Task ConsultarSerieC()
        {
            string apiUrl = ApiRotasController.ConsultarSerieC;
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var dados = JsonConvert.DeserializeObject<List<ConsultarSerieCModel>>(jsonString);
                        dgvAtualizar.DataSource = dados;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar dados da API: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar à API: " + ex.Message);
                }
            }
        }

        private async Task ConsultarSerieD()
        {
            string apiUrl = ApiRotasController.ConsultarSerieD;
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var dados = JsonConvert.DeserializeObject<List<ConsultarSerieDModel>>(jsonString);
                        dgvAtualizar.DataSource = dados;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar dados da API: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar à API: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string apiUrl = "http://127.0.0.1:5000";

            switch (cb_Serie.Text)
            {
                case "A":
                    apiUrl = ApiRotasController.InserirSerieA;
                    break;
                case "B":
                    apiUrl = ApiRotasController.InserirSerieB;
                    break;
                case "C":
                    apiUrl = ApiRotasController.InserirSerieC;
                    break;
                case "D":
                    apiUrl = ApiRotasController.InserirSerieD;
                    break;
                default:
                    MessageBox.Show("Selecione a série.");
                    return;
            }

            var dados = new
            {
                NomeClube = txtNome.Text,
                PontosClube = txtPontosClube.Text,
                JogosClube = txtJogosClube.Text,
                SaldosGols = txtSaldosGols.Text,
                VitoriasClube = int.Parse(txtVitoriasClube.Text),
                EmpateClube = int.Parse(txtEmpateClube.Text),
                DerrotasClube = int.Parse(txtDerrotasClube.Text),
                PosicaoClube = int.Parse(txtPosiçaoClube.Text),

            };

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var jsonContent = JsonConvert.SerializeObject(dados);
                    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.PostAsync(apiUrl, content).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Dados inseridos com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao inserir dados na API: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar à API: " + ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private int? _idSelecionado = null;
        private void dgvAtualizar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow linha = dgvAtualizar.Rows[e.RowIndex];

            string serie = cb_Serie.Text;

            switch (serie)
            {
                case "A":
                    _idSelecionado = (int)linha.Cells["idSerieA"].Value;
                    break;
                case "B":
                    _idSelecionado = (int)linha.Cells["idSerieB"].Value;
                    break;
                case "C":
                    _idSelecionado = (int)linha.Cells["idSerieC"].Value;
                    break;
                case "D":
                    _idSelecionado = (int)linha.Cells["idSerieD"].Value;
                    break;
                default:
                    MessageBox.Show("Selecione a série.");
                    break;
            }

            txtNome.Text = linha.Cells["NomeClube"].Value?.ToString();
            txtPontosClube.Text = linha.Cells["PontosClube"].Value?.ToString();
            txtJogosClube.Text = linha.Cells["JogosClube"].Value?.ToString();
            txtSaldosGols.Text = linha.Cells["SaldosGols"].Value?.ToString();
            txtVitoriasClube.Text = linha.Cells["VitoriasClube"].Value?.ToString();
            txtEmpateClube.Text = linha.Cells["EmpateClube"].Value?.ToString();
            txtDerrotasClube.Text = linha.Cells["DerrotasClube"].Value?.ToString();
            txtPosiçaoClube.Text = linha.Cells["PosicaoClube"].Value?.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string apiUrl = "";

            switch (cb_Serie.Text)
            {
                case "A":
                    apiUrl = ApiRotasController.DeletarSerieA;
                    break;
                case "B":
                    apiUrl = ApiRotasController.DeletarSerieB;
                    break;
                case "C":
                    apiUrl = ApiRotasController.DeletarSerieC;
                    break;
                case "D":
                    apiUrl = ApiRotasController.DeletarSerieD;
                    break;
                default:
                    MessageBox.Show("Selecione a série.");
                    return;
            }

            // Verifica se algum registro foi selecionado
            if (_idSelecionado == null)
            {
                MessageBox.Show("Selecione um registro na tabela para excluir.");
                return;
            }

            // Confirma a exclusão
            DialogResult resposta = MessageBox.Show(
                "Deseja realmente excluir este registro?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta == DialogResult.No)
                return;

            // Monta a URL com o ID
            apiUrl = $"{apiUrl}/{_idSelecionado.Value}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = client.DeleteAsync(apiUrl).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Registro excluído com sucesso!");

                        // Limpa a seleção
                        _idSelecionado = null;

                        txtNome.Clear();
                        txtPontosClube.Clear();
                        txtJogosClube.Clear();
                        txtSaldosGols.Clear();
                        txtVitoriasClube.Clear();
                        txtEmpateClube.Clear();
                        txtDerrotasClube.Clear();
                        txtPosiçaoClube.Clear();

                        // Atualize o DataGridView aqui, se você possuir um método para isso.
                        // Exemplo:
                        // CarregarDados();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar à API: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string apiUrl = "";

            switch (cb_Serie.Text)
            {
                case "A":
                    apiUrl = ApiRotasController.AtualizarSerieA;
                    break;
                case "B":
                    apiUrl = ApiRotasController.AtualizarSerieB;
                    break;
                case "C":
                    apiUrl = ApiRotasController.AtualizarSerieC;
                    break;
                case "D":
                    apiUrl = ApiRotasController.AtualizarSerieD;
                    break;
                default:
                    MessageBox.Show("Selecione a série.");
                    return;
            }

            // Verifica se um registro foi selecionado
            if (_idSelecionado == null)
            {
                MessageBox.Show("Selecione um registro na tabela para atualizar.");
                return;
            }

            // Dados que serão atualizados
            var dados = new
            {
                NomeClube = txtNome.Text,
                PontosClube = int.Parse(txtPontosClube.Text),
                JogosClube = int.Parse(txtJogosClube.Text),
                SaldosGols = int.Parse(txtSaldosGols.Text),
                VitoriasClube = int.Parse(txtVitoriasClube.Text),
                EmpateClube = int.Parse(txtEmpateClube.Text),
                DerrotasClube = int.Parse(txtDerrotasClube.Text),
                PosicaoClube = int.Parse(txtPosiçaoClube.Text)
            };

            // Confirma a atualização
            DialogResult resposta = MessageBox.Show(
                "Deseja realmente atualizar este registro?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta == DialogResult.No)
                return;

            // Adiciona o ID à URL
            apiUrl = $"{apiUrl}/{_idSelecionado.Value}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string json = JsonConvert.SerializeObject(dados);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = client.PutAsync(apiUrl, content).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Registro atualizado com sucesso!");

                        _idSelecionado = null;

                        txtNome.Clear();
                        txtPontosClube.Clear();
                        txtJogosClube.Clear();
                        txtSaldosGols.Clear();
                        txtVitoriasClube.Clear();
                        txtEmpateClube.Clear();
                        txtDerrotasClube.Clear();
                        txtPosiçaoClube.Clear();

                        // Atualizar o DataGridView
                        // Exemplo:
                        // CarregarDados();
                    }
                    else
                    {
                        string erro = response.Content.ReadAsStringAsync().Result;

                        MessageBox.Show(
                            $"Erro ao atualizar.\n\nStatus: {response.StatusCode}\n\n{erro}"
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar à API: " + ex.Message);
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (dgvAtualizar.DataSource == null)
                return;

            CurrencyManager cm = (CurrencyManager)BindingContext[dgvAtualizar.DataSource];
            cm.SuspendBinding();

            string texto = txtBuscar.Text.Trim().ToLower();

            foreach (DataGridViewRow linha in dgvAtualizar.Rows)
            {
                if (linha.IsNewRow)
                    continue;

                bool mostrar = false;

                if (rbNomeTime.Checked)
                {
                    string nome = linha.Cells["NomeClube"].Value?.ToString().ToLower() ?? "";
                    mostrar = nome.Contains(texto);
                }
                else if (rbPosicao.Checked)
                {
                    string posicao = linha.Cells["PosicaoClube"].Value?.ToString() ?? "";
                    mostrar = posicao.Contains(texto);
                }

                linha.Visible = mostrar;
            }

            cm.ResumeBinding();
        }
    }
}


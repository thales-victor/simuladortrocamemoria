using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace Trabalho_AED_AOC
{
    public partial class Simulador : MetroForm
    {
        private Random random = new Random();
        List<Cache> MemoriaCache = new List<Cache>();
        List<RAM> MemoriaRAM = new List<RAM>();
        List<string> Blocos = new List<string>();

        #region --- Inicialização ---
        public Simulador()
        {
            InitializeComponent();
        }

        private void Simulador_Load(object sender, EventArgs e)
        {
            // seleciona os valores iniciais dos combo box
            cb_RAM.SelectedIndex = 0;
            cb_Bloco.SelectedIndex = 0;
            cb_Algoritmo.SelectedIndex = 0;
            cb_Tecnica.SelectedIndex = 0;

            txtbox_RAM.Focus();
        }

        #endregion

        #region --- Tecnicas ---
        private void TecnicaDireta(Cache bloco, int linha)
        {
            //insere o bloco na linha correspondente
            MemoriaCache[linha] = bloco;
            dgv_Cache.DataSource = null;
            dgv_Cache.DataSource = MemoriaCache;
            dgv_Cache.Focus();
            dgv_Cache.Rows[linha].Selected = true;
        }

        private void TecnicaAssociativa(Cache bloco, string algoritmo)
        {
            int qtdCache = Convert.ToInt32(txtbox_Cache.Text);
            int linhasCheia = 0;
            string menor = "";
            switch (algoritmo)
            {
                case Algoritmo.LRU: { menor = MemoriaCache[0].HoraUsada.ToString(); } break;
                case Algoritmo.LFU: { menor = MemoriaCache[0].Contador.ToString(); } break;
                case Algoritmo.FIFO: { menor = MemoriaCache[0].HoraCarregada.ToString(); } break;
            }
            int indexMenor = 0;
            var celulasVazias = new List<int>();
            var equalCount = new List<int>();
            var random = new Random();
            int linhaSelecionada = 0;

            //verifica todas as linhas que estão vazias, seleciona os menores valores e seus indices
            for (int i = 0; i < qtdCache; i++)
            {
                if (MemoriaCache[i].Tag != null)
                {
                    switch (algoritmo)
                    {
                        case Algoritmo.LRU:
                            {
                                if (MemoriaCache[i].HoraUsada < Convert.ToDateTime(menor))
                                {
                                    menor = MemoriaCache[i].HoraUsada.ToString();
                                    indexMenor = i;
                                }
                            }
                            break;
                        case Algoritmo.LFU:
                            {
                                if (MemoriaCache[i].Contador < Convert.ToInt32(menor))
                                {
                                    equalCount.Clear();
                                    equalCount.Add(i);
                                    menor = MemoriaCache[i].Contador.ToString();
                                    indexMenor = i;
                                }
                                else if (MemoriaCache[i].Contador == Convert.ToInt32(menor))
                                {
                                    equalCount.Add(i);
                                }
                            }
                            break;
                        case Algoritmo.FIFO:
                            {
                                if (MemoriaCache[i].HoraCarregada < Convert.ToDateTime(menor))
                                {
                                    menor = MemoriaCache[i].HoraCarregada.ToString();
                                    indexMenor = i;
                                }
                            }
                            break;
                    }
                    linhasCheia++;
                }
                else
                {
                    celulasVazias.Add(i);
                }
            }

            if (linhasCheia < qtdCache)
            {
                //se ainda tiver linha vazia, insere o bloco em uma das linhas vazias
                MemoriaCache[celulasVazias[0]] = bloco;
                linhaSelecionada = celulasVazias[0];
            }
            else
            {
                //se não tiver linha vazia, substitui o bloco com menor indice, caso LFU, substitui em qualquer um que tiver o contador com menor valor
                switch (algoritmo)
                {
                    case Algoritmo.LFU:
                        {
                            int line = equalCount[random.Next(equalCount.Count)];
                            MemoriaCache[line] = bloco;
                            linhaSelecionada = line;
                        }
                        break;
                    default:
                        {
                            MemoriaCache[indexMenor] = bloco;
                            linhaSelecionada = indexMenor;
                        }
                        break;
                }

            }
            //atualiza o grid da memoria cache
            dgv_Cache.DataSource = null;
            dgv_Cache.DataSource = MemoriaCache;
            dgv_Cache.Focus();
            dgv_Cache.Rows[linhaSelecionada].Selected = true;

        }

        #endregion

        #region --- Private Methods ---

        private bool Valida()
        {
            //vericia se possui campo vazio
            if (String.IsNullOrEmpty(txtbox_RAM.Text.ToString()) || String.IsNullOrEmpty(txtbox_Bloco.Text.ToString()) || String.IsNullOrEmpty(txtbox_Cache.Text.ToString()))
            {
                MetroMessageBox.Show(this, "É necessário preencher todos os campos corretamente.", "Valores inválidos!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //pega o valor em bytes da ram e bloco
            int indexRam = cb_RAM.SelectedIndex;
            double ram = indexRam == 0 ? Convert.ToInt32(txtbox_RAM.Text) : Convert.ToInt32(txtbox_RAM.Text) * Math.Pow(2, (indexRam * 10));
            int indexBloco = cb_Bloco.SelectedIndex;
            double bloco = indexBloco == 0 ? Convert.ToInt32(txtbox_Bloco.Text) : Convert.ToInt32(txtbox_Bloco.Text) * Math.Pow(2, (indexBloco * 10));

            //verifica se o bloco é maior que a ram
            if (bloco > ram)
            {
                MetroMessageBox.Show(this, "A memória RAM deve ser maior que o tamanho do bloco.", "Valores inválidos!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void Limpar()
        {
            //limpa grid e listas
            MemoriaCache.Clear();
            MemoriaRAM.Clear();
            Blocos.Clear();

            label_Historico.Text = "";
            txtbox_Acessar.Text = null;

            dgv_Cache.DataSource = null;
            dgv_RAM.DataSource = null;
            dgv_Blocos.DataSource = null;
        }

        private string GetRandom(int tamanho)
        {
            //gera bloco aleatorio
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var result = new string(
                Enumerable.Repeat(chars, tamanho)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }

        private int GetIndexFromDGVValue(int SearchForThis, DataGridView dgv)
        {
            return (dgv.Rows.Cast<DataGridViewRow>()
                                   .Where(r => Convert.ToInt32(r.Cells[0].Value) == SearchForThis)
                                   .Select(r => r.Index)).First();
        }

        private void PropriedadeGrid(string algoritmo = "")
        {
            //seleciona tamanho e colunas a serem apresentadas de acordo com a tecnica e algoritmo
            dgv_RAM.Columns[0].Width = 30;
            dgv_RAM.Columns[1].Width = 180;
            dgv_RAM.Columns[2].Width = 70;

            dgv_Cache.Columns[0].Width = 20;
            dgv_Cache.Columns[1].Width = 80;
            dgv_Cache.Columns[4].Width = 30;
            dgv_Cache.Columns[5].Width = 30;
            dgv_Cache.Columns[6].Width = 30;
            dgv_Cache.Columns[2].Visible = false;
            dgv_Cache.Columns[3].Visible = false;
            dgv_Cache.Columns[4].HeaderText = "Hora Carregada";
            dgv_Cache.Columns[5].HeaderText = "Hora Usada";

            dgv_Cache.Columns[4].Visible = algoritmo == Algoritmo.FIFO;
            dgv_Cache.Columns[5].Visible = algoritmo == Algoritmo.LRU;
            dgv_Cache.Columns[6].Visible = algoritmo == Algoritmo.LFU;
        }

        private bool ExistEqual(Cache cache)
        {
            //verifica a ram ja foi carregada na cache, e caso positivo, altera o contador e hora usada
            var existEqual = MemoriaCache.Where(d => d.Tag == cache.Tag).FirstOrDefault();
            if (existEqual != null)
            {
                existEqual.HoraUsada = DateTime.Now;
                existEqual.Contador++;
                dgv_Cache.DataSource = null;
                dgv_Cache.DataSource = MemoriaCache;
                dgv_Cache.Focus();
                PropriedadeGrid(GetAlgoritmo());
                dgv_Cache.Rows[GetIndexFromDGVValue(Convert.ToInt32(existEqual.Tag), dgv_Cache)].Selected = true;
                return true;
            }

            return false;
        }

        private string GetAlgoritmo()
        {
            //retorna qual o algoritmo de substituição está sendo usado
            string algoritmo = "";
            if (cb_Tecnica.SelectedIndex == 1)
            {
                switch (cb_Algoritmo.SelectedIndex)
                {
                    case 0:
                        {
                            algoritmo = Algoritmo.LRU;
                        }
                        break;
                    case 1:
                        {
                            algoritmo = Algoritmo.LFU;
                        }
                        break;
                    case 2:
                        {
                            algoritmo = Algoritmo.FIFO;
                        }
                        break;
                }
            }
            return algoritmo;
        }

        #endregion

        #region  --- Clique ---

        private void Calcular_Click(object sender, EventArgs e)
        {
            if (!Valida()) return;
            Limpar();

            int bloco = Convert.ToInt32(txtbox_Bloco.Text);
            int ram = Convert.ToInt32(txtbox_RAM.Text);
            int index = cb_RAM.SelectedIndex;

            
            double qtdRAM = index == 0 ? (ram / bloco) : (ram * Math.Pow(2, (index * 10)) / bloco);  //
            int qtdCache = Convert.ToInt32(txtbox_Cache.Text);                                       //
                                                                                                     //
            for (int i = 0; i < qtdRAM; i++)                                                         //
            {                                                                                        //
                MemoriaRAM.Add(new RAM()                                                             //
                {                                                                                    //
                    Bloco = i,                                                                       //
                    Dado = GetRandom(bloco),                                                         // cria o grid
                    Endereço = i * bloco                                                             //
                });                                                                                  //
            }                                                                                        //
                                                                                                     //
            for (int i = 0; i < qtdCache; i++)                                                       //
            {                                                                                        //
                MemoriaCache.Add(new Cache());                                                       //
            }                                                                                        //


            dgv_RAM.DataSource = MemoriaRAM;
            dgv_Cache.DataSource = MemoriaCache;

            PropriedadeGrid(GetAlgoritmo());

            txtbox_Acessar.Focus();


            if (!descer)
            {
                descer = true;
                Y_atual = 85;
                t_slide.Start();
            }
        }

        private void Carregar_Click(object sender, EventArgs e)
        {
            string[] numeros = txtbox_Acessar.Text.Split(',');

            foreach (var numero in numeros)
            {
                if (!String.IsNullOrEmpty(numero) && /*!Blocos.Contains(numero.Trim()) &&*/ Convert.ToInt32(numero) < (MemoriaRAM.Count))
                {
                    Blocos.Add(numero.Trim());
                }
            }

            var wrapped = (from i in Blocos select new { Value = i }).ToArray();

            dgv_Blocos.DataSource = null;
            dgv_Blocos.DataSource = wrapped;
            dgv_Blocos.Focus();

            txtbox_Acessar.Text = null;
        }

        private void Acessar_Click(object sender, EventArgs e)
        {
            // verifica se possui bloco a ser carregado
            if (Blocos.Count < 1)
            {
                MetroMessageBox.Show(this, "Não é possível realizar o acesso a um bloco pois a memória não foi carregada.", "Impossível realizar o acesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbox_RAM.Focus();
                return;
            }

            //var celula = dgv_Blocos.Rows[0].Cells[0].Value.ToString();
            var celula = Blocos[0].ToString();


            Blocos.Remove(celula);

            var wrapped = (from i in Blocos select new { Value = i }).ToArray();
            dgv_Blocos.DataSource = null;
            dgv_Blocos.DataSource = wrapped;

            dgv_RAM.Rows[GetIndexFromDGVValue(Convert.ToInt32(celula), dgv_RAM)].Selected = true;

            var temp = new RAM()
            {
                Bloco = Convert.ToInt32(dgv_RAM.SelectedCells[0].Value),
                Dado = dgv_RAM.SelectedCells[1].Value.ToString(),
                Endereço = Convert.ToInt32(dgv_RAM.SelectedCells[2].Value)
            };

            var cache = new Cache()
            {
                Tag = temp.Bloco,
                Bloco = temp.Dado,
                HoraCarregada = DateTime.Now,
                HoraUsada = DateTime.Now,
                Contador = 1
            };

            // Histórico de acessos
            StringBuilder str = new StringBuilder();
            str.Append($" - {celula}{label_Historico.Text}");
            label_Historico.Text = str.ToString();

            if (ExistEqual(cache))
            {
                Notificar("HIT");
                return;
            }
            else
            {
                Notificar("MISS");
            }

            switch (cb_Tecnica.SelectedIndex)
            {
                case Tecnica.Direta:
                    {
                        int linha = temp.Bloco % Convert.ToInt32(txtbox_Cache.Text);
                        TecnicaDireta(cache, linha);
                        PropriedadeGrid();
                    }
                    break;
                case Tecnica.Associativa:
                    {
                        string algoritmo = GetAlgoritmo();
                        
                        TecnicaAssociativa(cache, algoritmo);
                        PropriedadeGrid(algoritmo);
                    }
                    break;
            }

            dgv_Blocos.Focus();
        }

        private void Tecnica_Select(object sender, EventArgs e)
        {
            if (cb_Tecnica.SelectedIndex == 0)
            {
                cb_Algoritmo.Enabled = false;
            }
            else
            {
                cb_Algoritmo.Enabled = true;
            }

        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            Limpar();

            txtbox_RAM.Focus();

            if (descer)
            {
                descer = false;
                Y_atual = 142;
                t_slide.Start();
            }
        }

        #endregion

        #region --- Animações ---
        bool descer;
        int Y_atual;
        private void t_slide_Tick(object sender, EventArgs e)
        {
            if (descer)
            {
                Y_atual += 2;
                if (Y_atual <= 142)
                    painel_Carregar.Location = new Point(painel_Carregar.Location.X, Y_atual);
                else
                    t_slide.Stop();

                return;
            }

            Y_atual -= 2;
            if (Y_atual >= 70)
                painel_Carregar.Location = new Point(painel_Carregar.Location.X, Y_atual);
            else
                t_slide.Stop();

        }

        private void Notificar(string notify)
        {
            if (t_check.Enabled)
                t_check.Stop();

            label_Check.Text = notify;
            t_check.Start();
        }

        private void t_check_Tick(object sender, EventArgs e)
        {
            label_Check.Text = "";
            t_check.Stop();
        }
        #endregion

    }
}

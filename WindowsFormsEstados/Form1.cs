using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEstados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblEstados.Text = cboEstados.Items.Count.ToString();
        }





        private void btnEstados_Click(object sender, EventArgs e)
        {
            // criou a variável que vai receber
            string est = cboEstados.SelectedItem.ToString();
            if (est == "SP" | est == "RJ" | est == "MG" | est == "ES")
            {
                // adiciona no sudeste
                cboSudeste.Items.Add(cboEstados.SelectedItem.ToString());
                // remover do estado
                cboEstados.Items.Remove(cboEstados.SelectedItem.ToString());
                // colocar o foco para o sudeste
                cboSudeste.Focus();
            }
            else if (est == "AM" | est == "PA" | est == "AC" | est == "RR" | est == "RO" | est == "AP" | est == "TO")
            {
                // adiciona no norte
                cboNorte.Items.Add(cboEstados.SelectedItem.ToString());
                // remover do estado
                cboEstados.Items.Remove(cboEstados.SelectedItem.ToString());
                // colocar o foco para o norte
                cboNorte.Focus();
            }
            else if (est == "AL" | est == "BA" | est == "CE" | est == "MA" | est == "PB" | est == "PE" | est == "PI" | est == "RN" | est == "SE")
            {
                // adiciona no nordeste
                cboNordeste.Items.Add(cboEstados.SelectedItem.ToString());
                // remover do estado
                cboEstados.Items.Remove(cboEstados.SelectedItem.ToString());
                // colocar o foco para o nordeste
                cboNordeste.Focus();
            }
            else if (est == "SC" | est == "RS" | est == "PR")
            {
                // adiciona no sul
                cboSul.Items.Add(cboEstados.SelectedItem.ToString());
                // remover do estado
                cboEstados.Items.Remove(cboEstados.SelectedItem.ToString());
                // colocar o foco para o sul
                cboSul.Focus();
            }
            else if (est == "GO" | est == "MT" | est == "MS" | est == "DF")
            {
                // adiciona no centro-oeste
                cboCentro.Items.Add(cboEstados.SelectedItem.ToString());
                // remover do estado
                cboEstados.Items.Remove(cboEstados.SelectedItem.ToString());
                // colocar o foco para o centro-oeste
                cboCentro.Focus();
            }

            // mostra o número de estados que estam dentro de cada combobox
            lblEstados.Text = cboEstados.Items.Count.ToString();
            lblSudeste.Text = cboSudeste.Items.Count.ToString();
            lblNorte.Text = cboNorte.Items.Count.ToString();
            lblNordeste.Text = cboNordeste.Items.Count.ToString();
            lblSul.Text = cboSul.Items.Count.ToString();
            lblCentro.Text = cboCentro.Items.Count.ToString();
            // deixar em ordem alfabética
            cboEstados.Sorted = true;
            cboSudeste.Sorted = true;
            cboNorte.Sorted = true;
            cboNordeste.Sorted = true;
            cboSul.Sorted = true;
            cboCentro.Sorted = true;
            // faz a sigla sumir só na tela
            cboEstados.ResetText();
            // para não crashar
            btnEstados.Visible = false;
        }

        private void btnNorte_Click(object sender, EventArgs e)
        {
            string est = cboNorte.SelectedItem.ToString();
            if (est == "AM" | est == "PA" | est == "AC" | est == "RR" | est == "RO" | est == "AP" | est == "TO")
            {
                // adiciona no estado, remove do norte, tira o texto só da tela, atualiza o contador, deixa em ordem alfabética e o botão não vai aparecer depois para não dar ruim
                cboEstados.Items.Add(cboNorte.SelectedItem.ToString());
                cboNorte.Items.Remove(cboNorte.SelectedItem.ToString());
                cboNorte.ResetText();
                lblEstados.Text = cboEstados.Items.Count.ToString();
                lblNorte.Text = cboNorte.Items.Count.ToString();
                cboEstados.Sorted = true;
                btnNorte.Visible = false;
            }
        }

        private void btnNordeste_Click(object sender, EventArgs e)
        {

            string est = cboNordeste.SelectedItem.ToString();
            if (est == "AL" | est == "BA" | est == "CE" | est == "MA" | est == "PB" | est == "PE" | est == "PI" | est == "RN" | est == "SE")
            {
                // adiciona no estado, remove do norte, tira o texto só da tela, atualiza o contador, deixa em ordem alfabética e o botão não vai aparecer depois para não dar ruim
                cboEstados.Items.Add(cboNordeste.SelectedItem.ToString());
                cboNordeste.Items.Remove(cboNordeste.SelectedItem.ToString());
                cboNordeste.ResetText();
                lblEstados.Text = cboEstados.Items.Count.ToString();
                lblNordeste.Text = cboNordeste.Items.Count.ToString();
                cboEstados.Sorted = true;
                btnNordeste.Visible = false;
            }

        }

        private void btnCentro_Click(object sender, EventArgs e)
        {
            string est = cboCentro.SelectedItem.ToString();
            if (est == "GO" | est == "MT" | est == "MS" | est == "DF")
            {
                // adiciona no estado, remove do norte, tira o texto só da tela, atualiza o contador, deixa em ordem alfabética e o botão não vai aparecer depois para não dar ruim
                cboEstados.Items.Add(cboCentro.SelectedItem.ToString());
                cboCentro.Items.Remove(cboCentro.SelectedItem.ToString());
                cboCentro.ResetText();
                lblEstados.Text = cboEstados.Items.Count.ToString();
                lblCentro.Text = cboCentro.Items.Count.ToString();
                cboEstados.Sorted = true;
                btnCentro.Visible = false;
            }
        }

        private void btnSudeste_Click(object sender, EventArgs e)
        {
            string est = cboSudeste.SelectedItem.ToString();
            if (est == "SP" | est == "RJ" | est == "MG" | est == "ES")
            {
                // adiciona no estado, remove do norte, tira o texto só da tela, atualiza o contador, deixa em ordem alfabética e o botão não vai aparecer depois para não dar ruim
                cboEstados.Items.Add(cboSudeste.SelectedItem.ToString());
                cboSudeste.Items.Remove(cboSudeste.SelectedItem.ToString());
                cboSudeste.ResetText();
                lblEstados.Text = cboEstados.Items.Count.ToString();
                lblSudeste.Text = cboSudeste.Items.Count.ToString();
                cboEstados.Sorted = true;
                btnSudeste.Visible = false;
            }
        }

        private void btnSul_Click(object sender, EventArgs e)
        {
            string est = cboSul.SelectedItem.ToString();
            if (est == "SC" | est == "RS" | est == "PR")
            {
                // adiciona no estado, remove do norte, tira o texto só da tela, atualiza o contador, deixa em ordem alfabética e o botão não vai aparecer depois para não dar ruim
                cboEstados.Items.Add(cboSul.SelectedItem.ToString());
                cboSul.Items.Remove(cboSul.SelectedItem.ToString());
                cboSul.ResetText();
                lblEstados.Text = cboEstados.Items.Count.ToString();
                lblSul.Text = cboSul.Items.Count.ToString();
                cboEstados.Sorted = true;
                btnSul.Visible = false;
            }
        }

        // deixa sem os botões no começo para não crashar 
        private void Form1_Load(object sender, EventArgs e)
        {
            btnEstados.Visible = false;
            btnSudeste.Visible = false;
            btnNorte.Visible = false;
            btnNordeste.Visible = false;
            btnSul.Visible = false;
            btnCentro.Visible = false;
        }


        
        private void cboEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string est = cboEstados.SelectedItem.ToString();
            btnEstados.Visible = false;
            if (est != "")
            {
                btnEstados.Visible = true;
            }
        }

        private void cboNorte_SelectedIndexChanged(object sender, EventArgs e)
        {
            string est = cboNorte.SelectedItem.ToString();
            btnNorte.Visible = false;
            if (est != "")
            {
                btnNorte.Visible = true;
            }
        }

        private void cboNordeste_SelectedIndexChanged(object sender, EventArgs e)
        {
            string est = cboNordeste.SelectedItem.ToString();
            btnNordeste.Visible = false;
            if (est != "")
            {
                btnNordeste.Visible = true;
            }
        }

        private void cboCentro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string est = cboCentro.SelectedItem.ToString();
            btnCentro.Visible = false;
            if (est != "")
            {
                btnCentro.Visible = true;
            }
        }

        private void cboSudeste_SelectedIndexChanged(object sender, EventArgs e)
        {
            string est = cboSudeste.SelectedItem.ToString();
            btnSudeste.Visible = false;
            if (est != "")
            {
                btnSudeste.Visible = true;
            }
        }

        private void cboSul_SelectedIndexChanged(object sender, EventArgs e)
        {
            string est = cboSul.SelectedItem.ToString();
            btnSul.Visible = false;
            if (est != "")
            {
                btnSul.Visible = true;
            }
        }
    }
}

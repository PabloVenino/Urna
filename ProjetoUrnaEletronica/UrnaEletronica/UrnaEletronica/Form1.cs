using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEletronica
{
    public partial class UrnaEletronica : Form
    {
        public UrnaEletronica()
        {
            InitializeComponent();
        }
        #region BotoesNumericos
        private void btn_num1_Click(object sender, EventArgs e)
        {
            if(txtBox_PrimNum.Text == "")
            {
                txtBox_PrimNum.Text = "1";
                return;
            }
            if (txtBox_PrimNum.Text != "")
            {
                if (txtBox_SecNum.Text == "")
                    txtBox_SecNum.Text = "1";
                return;
            }
        }

        private void btn_num2_Click(object sender, EventArgs e)
        {
            if (txtBox_PrimNum.Text == "")
            {
                txtBox_PrimNum.Text = "2";
                return;
            }
            if (txtBox_PrimNum.Text != "")
            {
                if (txtBox_SecNum.Text == "")
                    txtBox_SecNum.Text = "2";
                return;
            }
        }
        private void btn_num3_Click(object sender, EventArgs e)
        {
            if (txtBox_PrimNum.Text == "")
            {
                txtBox_PrimNum.Text = "3";
                return;
            }
            if (txtBox_PrimNum.Text != "")
            {
                if (txtBox_SecNum.Text == "")
                    txtBox_SecNum.Text = "3";
                return;
            }
        }
        private void btn_num4_Click(object sender, EventArgs e)
        {
            if (txtBox_PrimNum.Text == "")
            {
                txtBox_PrimNum.Text = "4";
                return;
            }
            if (txtBox_PrimNum.Text != "")
            {
                if (txtBox_SecNum.Text == "")
                    txtBox_SecNum.Text = "4";
                return;
            }
        }
        private void btn_num5_Click(object sender, EventArgs e)
        {
            if (txtBox_PrimNum.Text == "")
            {
                txtBox_PrimNum.Text = "5";
                return;
            }
            if (txtBox_PrimNum.Text != "")
            {
                if (txtBox_SecNum.Text == "")
                    txtBox_SecNum.Text = "5";
                return;
            }
        }
        private void btn_num6_Click(object sender, EventArgs e)
        {
            if (txtBox_PrimNum.Text == "")
            {
                txtBox_PrimNum.Text = "6";
                return;
            }
            if (txtBox_PrimNum.Text != "")
            {
                if (txtBox_SecNum.Text == "")
                    txtBox_SecNum.Text = "6";
                return;
            }
        }
        private void btn_num7_Click(object sender, EventArgs e)
        {
            if (txtBox_PrimNum.Text == "")
            {
                txtBox_PrimNum.Text = "7";
                return;
            }
            if (txtBox_PrimNum.Text != "")
            {
                if (txtBox_SecNum.Text == "")
                    txtBox_SecNum.Text = "7";
                return;
            }
        }
        private void btn_num8_Click(object sender, EventArgs e)
        {
            if (txtBox_PrimNum.Text == "")
            {
                txtBox_PrimNum.Text = "8";
                return;
            }
            if (txtBox_PrimNum.Text != "")
            {
                if (txtBox_SecNum.Text == "")
                    txtBox_SecNum.Text = "8";
                return;
            }
        }
        private void btn_num9_Click(object sender, EventArgs e)
        {
            if (txtBox_PrimNum.Text == "")
            {
                txtBox_PrimNum.Text = "9";
                return;
            }
            if (txtBox_PrimNum.Text != "")
            {
                if (txtBox_SecNum.Text == "")
                    txtBox_SecNum.Text = "9";
                return;
            }
        }
        private void btn_num0_Click(object sender, EventArgs e)
        {
            if (txtBox_PrimNum.Text == "")
            {
                txtBox_PrimNum.Text = "0";
                return;
            }
            if (txtBox_PrimNum.Text != "")
            {
                if (txtBox_SecNum.Text == "")
                    txtBox_SecNum.Text = "0";
                return;
            }
        }
        #endregion


        private void btn_corrige_Click(object sender, EventArgs e)
        {
            if (txtBox_PrimNum.Text == "")
                MessageBox.Show("Não há nada a corrigir.");
            if (txtBox_PrimNum.Text != "" && txtBox_SecNum.Text == "")
                txtBox_PrimNum.Clear();
            if (txtBox_SecNum.Text != "")
                txtBox_SecNum.Clear();
        }
        private void NumerosCandidatos()
        {
            if(txtBox_PrimNum.Text != "" && txtBox_SecNum.Text == "")
            {
                CandidatoGru();
            }
        }

        private void CandidatoGru()
        {
            if (txtBox_PrimNum.Text == "2" && txtBox_SecNum.Text == "8")
            {
                txtBox_NomeCandidato.Text = "Felonious Gru";
                txtBox_PartidoCandidato.Text = "MPF - Meu Presidente Favorito";
            }
        }
    }
}
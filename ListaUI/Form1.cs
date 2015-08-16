using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItensLista;
using ListaComprasModel;

namespace ListaUI
{
    public partial class Form1 : Form
    {
        double totalCompras = 0;
        ErrorProvider erro1 = new ErrorProvider();
           
        public Form1()
        {
            InitializeComponent();
          
        }

       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            initializaListBox();
        }

        private void initializaListBox()
        {
            lbListaItens.Items.Clear();
            lbListaItens.Items.AddRange(new Alimento[] {new Banana(),new Laranja(), });
            lbListaItens.Items.AddRange(new Alimento[] { new Queijo(), new Salmao(), new Guarana() });
            lbListaItens.Items.AddRange(new Alimento[] { new Presunto(), new Alface() });
            totalCompras=0;
        }

        private void lbListaItens_SelectdIndexChange(object sender, EventArgs e) 
        {
            erro1.Clear();
            ExibiItem((Alimento)lbListaItens.Items[lbListaItens.SelectedIndex]);
        }

        private void ExibiItem(Alimento _item)
        {
            textCalorias.Text = _item.Calorias.ToString();
            textCustoTotal.Clear();
            textTipo.Text = _item.Tipo;
            textUnidade.Text = _item.Unidade;
            textPreco.Text = _item.Preco.ToString("C");

            if (_item.Custo != 0)
            {
                textCustoTotal.Text = _item.Custo.ToString("C");
            }

        }

        private void ClearDetLista(Control ctrl)
        {
            foreach (var item in ctrl.Controls)
            {
                if (item is TextBox )
                {
                    ((TextBox)item).Text = String.Empty;

                }
            }
        }

        private void bntLimparLista_Click(object sender, EventArgs e)
        {
            ClearDetLista(this);
            initializaListBox();
        }

        private void bntInserir_Click(object sender, EventArgs e)
        {
            erro1.Clear();
            try
            {
                double quantidade = Convert.ToDouble(textQuantidade.Text);
                Alimento item = (Alimento)lbListaItens.Items[lbListaItens.SelectedIndex];
                item.Setcusto(quantidade);
                textCustoTotal.Text = item.Custo.ToString("C");
                textQuantidade.Clear();
                totalCompras += item.GetCustoCompra(quantidade);
                textTotalLista.Text = totalCompras.ToString("C");
            }
            catch (FormatException)
            {
                erro1.SetError(textQuantidade, "Informe a quantidade");
                textQuantidade.Focus();
                textQuantidade.SelectAll(); 
            }

            catch (ArgumentOutOfRangeException)
            {
                erro1.SetError(lbListaItens, "Selecione o Item da Lista!");
            }
        }
    }
}

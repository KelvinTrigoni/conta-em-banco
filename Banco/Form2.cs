using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        objeto dados = new objeto();
        private void button1_Click(object sender, EventArgs e)
        {
            dados.cpf = this.cpf.Text;
            dados.pesqcpf(dataGridView1);
        
            
        }

   

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int real = 0;
            int val = int.Parse(valor.Text);
            int tot = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());

            if (val <= tot && val >= 0)
            {
                real = tot - val;

                dados.cpf = this.cpf.Text;
                dados.valor = real;
                dados.alterar();
                dados.pesqcpf(dataGridView1);

            }
            else
            {
                MessageBox.Show("Valor maior que Saldo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string conta = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            int real = 0;
            int val = int.Parse(valor.Text);
            int tot = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());

            if (conta != "poupança" && val >= 0)
            {
                real = tot + val;

                dados.cpf = this.cpf.Text;
                dados.valor = real;
                dados.alterar();
                dados.pesqcpf(dataGridView1);

            }
            else
            {
                if(conta == "poupança" && val <= 100)
                {
                    real = tot + val;

                    dados.cpf = this.cpf.Text;
                    dados.valor = real;
                    dados.alterar();
                    dados.pesqcpf(dataGridView1);
                }
                else
                {
                    MessageBox.Show("Valor maior que $100!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }
    }
}

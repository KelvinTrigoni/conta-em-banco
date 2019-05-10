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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        objeto dados = new objeto();
        private void button1_Click(object sender, EventArgs e)
        {
            

            if (cpf.Text != "")
            {

                dados.cpf = this.cpf.Text;
                dados.nome = this.nome.Text;
                dados.email = this.email.Text;
                dados.telefone = this.telefone.Text;
                dados.conta = comboBox1.SelectedItem.ToString();
                dados.inserir();

                MessageBox.Show("Conta cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                nome.Focus();
                button1.Enabled = false;
                MessageBox.Show("Adicione um cpf na conta", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            cpf.Clear();
            nome.Clear();
            email.Clear();
            telefone.Clear();
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    class objeto
    {
        public string cpf { get; set; }

        public string nome { get; set; }

        public string email { get; set; }

        public string telefone { get; set; }

        public string conta { get; set; }

        public int valor { get; set; }

        banco dados = new banco();


        public void inserir()
        {
            try
            {
                dados.comandosql("insert into conta (cpf, nome, email, telefone, conta, valor) values ('" + cpf + "','" + nome + "','" + email + "','" + telefone + "','" + conta + "','" + valor + "')");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void alterar()
        {
            try
            {
                dados.comandosql("update conta set valor = '" + valor + "' where cpf = '" + cpf + "'");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void pesqcpf(DataGridView Dgv)
        {
            try
            {
                dados.consultar(Dgv, "select * from conta where cpf = '" + cpf + "'");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
    }


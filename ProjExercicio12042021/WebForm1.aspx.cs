using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjExercicio12042021
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            GVCliente.DataSource = new ClienteDB().GetAll();
            GVCliente.DataBind();
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            //Criação cliente
            Cliente c1 = GetDataCliente();
            
            if (new ClienteDB().Insert(c1))
            {
                Response.Write("<script>alert('Cliente inserido com sucesso!')</script>");
                TxtNome.Text = "";
                TxtEstado.Text = "";
                TxtCidade.Text = "";
                TxtEndereco.Text = "";
                TxtTelefone.Text = "";
                TxtCpf.Text = "";
                TxtEmail.Text = "";
                TxtTipoConta.Text = "";
                LoadGrid();
            }
            else
            {
                Response.Write("<script>alert('Erro ao inserir registro!')</script>");
            }

            //Criação conta cliente de acordo com o tipo da conta inserida no cadastro
            if (c1.TipoConta == 1)
            {
                int id = new ClienteDB().ReturnIDCliente(c1.Nome);
                Corrente conta1 = GetDataContaCorrente(id);
                new ContaDB().Insert(conta1);
                Response.Write("<script>alert('Conta criada com sucesso!')</script>");

            }
            else if(c1.TipoConta == 2)
            {
                int id = new ClienteDB().ReturnIDCliente(c1.Nome);
                Poupanca conta1 = GetDataContaPoupanca(id);
                new ContaDB().Insert(conta1);
                Response.Write("<script>alert('Conta criada com sucesso!')</script>");
            }

        }

        private Cliente GetDataCliente()
        {
            return new Cliente()
            {
                Nome = TxtNome.Text,
                Estado = TxtEstado.Text,
                Cidade = TxtCidade.Text,
                Endereco = TxtEndereco.Text,
                Telefone = TxtTelefone.Text,
                CPF = TxtCpf.Text,
                Email = TxtEmail.Text,
                TipoConta = int.Parse(TxtTipoConta.Text),
            };
        }

        private Corrente GetDataContaCorrente(int idCliente)
        {
            Random randNum = new Random();

            return new Corrente()
            {
                IdTitular = idCliente,
                NumeroConta = randNum.Next(0000, 9999),
                Agencia = randNum.Next(0000, 9999),
                Saldo = 0,
            };
        }

        private Poupanca GetDataContaPoupanca(int idCliente)
        {
            Random randNum = new Random();

            return new Poupanca()
            {
                IdTitular = idCliente,
                NumeroConta = randNum.Next(0000, 9999),
                Agencia = randNum.Next(0000, 9999),
                Saldo = 0,
            };
        }
    }
}
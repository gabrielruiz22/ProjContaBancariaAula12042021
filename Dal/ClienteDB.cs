using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ClienteDB : IClienteDB
    {

        public List<Cliente> GetAll()
        {
            
            List<Cliente> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToList(connection.ExecQueryReturn(Cliente.GETALL));
            }
            return lst;
        }

        private List<Cliente> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var lst = new List<Cliente>();

            while (returnData.Read())
            {
                var pessoa = new Cliente()
                {
                    Id = int.Parse(returnData["id"].ToString()),
                    Nome = returnData["Nome"].ToString(),
                    Estado = returnData["Estado"].ToString(),
                    Cidade = returnData["Cidade"].ToString(),
                    Endereco = returnData["Endereco"].ToString(),
                    Telefone = returnData["Telefone"].ToString(),
                    CPF = returnData["CPF"].ToString(),
                    Email = returnData["Email"].ToString(),
                    TipoConta = int.Parse(returnData["TipoConta"].ToString()),
                };
                lst.Add(pessoa);
            }
            return lst;
        }

        public bool Insert(Cliente cliente)
        {
            bool status = false;
            string sql = string.Format(Cliente.INSERT, cliente.Nome, cliente.Estado, cliente.Cidade, cliente.Endereco, cliente.Telefone, cliente.CPF, cliente.Email, cliente.TipoConta);
     
            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Cliente SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public int ReturnIDCliente(String nome)
        {
            Cliente c2 = new Cliente();
            SqlDataReader returnData;

            using (var connection = new DB())
            {
                returnData = connection.ExecQueryReturn("SELECT * FROM TB_CLIENTE WHERE Nome = '" + nome + "'");
                while (returnData.Read())
                {
                    var pessoa = new Cliente()
                    {

                        Id = int.Parse(returnData["id"].ToString()),
                        Nome = returnData["Nome"].ToString(),
                        Estado = returnData["Estado"].ToString(),
                        Cidade = returnData["Cidade"].ToString(),
                        Endereco = returnData["Endereco"].ToString(),
                        Telefone = returnData["Telefone"].ToString(),
                        CPF = returnData["CPF"].ToString(),
                        Email = returnData["Email"].ToString(),
                        TipoConta = int.Parse(returnData["TipoConta"].ToString()),
                    };
                    c2 = pessoa;
                }
            }

            return c2.Id;
        }
    }
}

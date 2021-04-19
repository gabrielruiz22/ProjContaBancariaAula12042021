using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ContaDB : IContaDB
    {
        public List<Conta> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Conta conta)
        {
            bool status = false;
            string sql;

            if (conta.IdTitular == 1)
            {
                sql = string.Format(Corrente.INSERT, conta.NumeroConta, conta.Agencia, conta.Saldo, conta.IdTitular);
            }
            else
            {
                sql = string.Format(Poupanca.INSERT, conta.NumeroConta, conta.Agencia, conta.Saldo, conta.IdTitular);
            }

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public Conta SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Conta conta)
        {
            throw new NotImplementedException();
        }
    }
}

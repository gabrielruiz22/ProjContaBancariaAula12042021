using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Poupanca : Conta
    {
        public const string INSERT = "INSERT INTO TB_CONTA_POUPANCA (numeroConta, agencia, saldo, id_cliente) VALUES ('{0}', '{1}', '{2}', '{3}')";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Corrente : Conta
    {
        public const string INSERT = "INSERT INTO TB_CONTA_CORRENTE (numeroConta, agencia, saldo, id_cliente) VALUES ('{0}', '{1}', '{2}', '{3}')";
        
    }
}

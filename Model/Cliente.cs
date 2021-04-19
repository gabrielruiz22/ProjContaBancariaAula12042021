using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cliente : Pessoa
    {
        public const string INSERT = "INSERT INTO TB_CLIENTE (Nome, Estado, Cidade, Endereco, Telefone, CPF, Email, TipoConta) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')";
        public const string GETALL = "SELECT id, Nome, Estado, Cidade, Endereco, Telefone, CPF, Email, tipoConta FROM TB_CLIENTE";
    }
}

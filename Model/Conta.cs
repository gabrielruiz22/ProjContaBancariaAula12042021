using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Conta
    {

        #region
        public int Id { get; set; }
        public int IdTitular { get; set; }
        public int NumeroConta { get; set; }
        public int Agencia { get; set; }
        public decimal Saldo { get; set; }
        #endregion
    }
}

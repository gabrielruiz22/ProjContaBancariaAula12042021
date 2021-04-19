using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IContaDB
    {
        bool Insert(Conta conta);
        bool Update(Conta conta);
        bool Delete(int id);
        Conta SelectById(int id);
        List<Conta> GetAll();
    }
}

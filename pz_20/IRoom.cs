using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_20
{
    internal interface IRoom//пользовательский интерфейс
    {
        string ID { get; set; }
        void Register();
        void DeleteAccount();
    }
}

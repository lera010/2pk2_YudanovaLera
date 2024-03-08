using consoleProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_20
{
    internal class Room : HotelRoom, IRoom//класс для пользовательского интерфейса
    {
        public string ID { get; set; }
        public Room(string id)
        {
            ID = id;
        }

        public void Register()
        {
            Console.WriteLine($"{ID} внесен в базу");
        }

        public void DeleteAccount()
        {
            Console.WriteLine($"{ID} удален из базы");
        }
    }
}

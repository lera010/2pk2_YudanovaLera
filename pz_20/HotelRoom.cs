using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace consoleProject
{
    enum State { free, notfree, clean }
    enum Type { standart, econom, lux }
    internal class HotelRoom : IClonable, IComparable<HotelRoom>
    {
        public int number;
        public State state;
        public int bedsCount;
        public Type type;
        public string guest;

        public HotelRoom(int number, int bedsCount)
        {
            this.number = number;
            this.bedsCount = bedsCount;
        }
        public HotelRoom() { }
        public object Clone() => new HotelRoom(this.number, this.bedsCount);
        public int CompareTo(HotelRoom? o)
        {
            if (o is HotelRoom room) return bedsCount.CompareTo(room.number);
            else throw new ArgumentException("Некорректное значение параметра");
        }

        public void CheckIn(string fio)
        {
            if (state == State.free)
            {
                guest = fio;
                type = Type.econom;
                state = State.notfree;//меняет статус на не свободный
                Console.WriteLine("Гость успешно заселен");
            }
            else
            {
                Console.WriteLine("Номер занят");
                Console.WriteLine();
            }
        }

        public void PrintInfo() //вывод информации
        {
            Console.WriteLine($"номер: {number}\n" +
                $"состояние номера: {state}\n" +
                $"количество спальных мест: {bedsCount}\n" +
                $"тип номера: {type}\n" +
                $"гость: {guest}\n");
        }
    }
}
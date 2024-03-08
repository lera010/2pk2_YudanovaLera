using pz_20;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace consoleProject
{
    /*
     * ФИО студента: Юданова В.С. 
     * номер варианта: без варианта
     * условие задачи (скопировать из листа задания): За основу берется класс, разработанный на 17 практике (создание простого класса).
Для этого класса необходимо реализовать следующие интерфейсы
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            HotelRoom room1 = new HotelRoom(100, 3);//создает объект
            room1.CheckIn("ivanov");//метод заселения
            room1.PrintInfo();//выводит информацию о номере
            room1.CheckIn("petrov");
            HotelRoom room2 = new HotelRoom(101, 1);//создает объект
            room2.CheckIn("petrov");
            room2.PrintInfo();
            HotelRoom room3 = new HotelRoom(102, 2);//создает объект
            room3.CheckIn("ivanov1");
            room3.PrintInfo();
            HotelRoom room4 = new HotelRoom(103, 5);//создает объект
            room4.CheckIn("ivanov2");
            room4.PrintInfo();
            HotelRoom room5 = new HotelRoom(104, 4);//создает объект
            room5.CheckIn("ivanov3");
            room5.PrintInfo();
            HotelRoom room6 = new HotelRoom(105, 2);//создает объект
            room6.CheckIn("ivanov4");
            room6.PrintInfo();
            HotelRoom room7 = new HotelRoom(106, 1);//создает объект
            room7.CheckIn("ivanov5");
            room7.PrintInfo();
            HotelRoom room8 = new HotelRoom(107, 7);//создает объект
            room8.CheckIn("ivanov6");
            room8.PrintInfo();
            HotelRoom room9 = new HotelRoom(108, 2);//создает объект
            room9.CheckIn("ivanov7");
            room9.PrintInfo();
            HotelRoom room10 = new HotelRoom(109, 3);//создает объект
            room10.CheckIn("ivanov8");
            room10.PrintInfo();

            var ivanov8 = new HotelRoom(109, 3);// IClonable
            var ivanov82 = (HotelRoom)ivanov8.Clone();
            ivanov82.number = 109;
            Console.WriteLine(ivanov8.number);


            HotelRoom[] rooms = { room1, room2, room3, room4, room5, room6, room7, room8, room9, room10 };//IDisposable
            Array.Sort(rooms);

            foreach (HotelRoom room in rooms)
            {
                Console.WriteLine($"{room.number} - {room.bedsCount}");
            }

            IRoom id1 = new Room("nfvjbdhvfb");// Пользовательский интерфейс
            id1.Register();
            id1.DeleteAccount();
        }
    }
}
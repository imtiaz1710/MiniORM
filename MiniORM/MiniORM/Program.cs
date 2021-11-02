using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace MiniORM
{
    class Program
    {
        static void Main(string[] args)
        {
            var myOrm = new MyORM<House>(DatabaseConnection.GetConnectionString());

            var house = new House()
            {
                Id = 2,
                Rooms = new List<Room>()
                {
                     new Room()
                     {
                         Id=3,
                         Rent=1000,
                         HouseId=2,
                         Roof=new Roof()
                         {
                             Id=3,
                             Length=100,
                             Width=200

                         },
                         Windows=new List<Window>()
                         {
                             new Window()
                             {
                                Id=5,
                                Color="DeepYellow",
                                RoomId=3
                             },
                             new Window()
                             {
                                Id=6,
                                Color="liteBlack",
                                RoomId=3
                             }
                         }
                     },
                     new Room()
                     {
                         Id=4,
                         Rent=2000,
                         HouseId=2,
                         Roof=new Roof()
                         {
                             Id=4,
                             Length=1000,
                             Width=2000

                         },
                         Windows=new List<Window>()
                         {
                             new Window()
                             {
                                Id=7,
                                Color="Yello",
                                RoomId=4
                             },
                             new Window()
                             {
                                Id=8,
                                Color="Black",
                                RoomId=4
                             }
                         }
                     }
                 }
            };

            myOrm.Insert(house);
            //myOrm.Update(house);
            //var AllData = myOrm.GetAll();
            //myOrm.Delete(1);
            //myOrm.Delete(house);
        }
    }
}

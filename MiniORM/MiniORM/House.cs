using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniORM
{
    public class House : IData
    {
        public int Id { get; set; }
        public IList<Room> Rooms { get; set; }
    }
}

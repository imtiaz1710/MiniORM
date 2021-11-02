using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniORM
{
    public class Room : IData
    {
        public int Id { get; set; }
        public int? Rent { get; set; }
        public int? HouseId { get; set; }
        public IList<Window> Windows { get; set; }
        public Roof Roof { get; set; }
    }
}

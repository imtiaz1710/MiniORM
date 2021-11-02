using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniORM
{
    public class Roof : IData
    {
        public int Id { get; set; }
        public int? Length { get; set; }
        public int? Width { get; set; }
    }
}

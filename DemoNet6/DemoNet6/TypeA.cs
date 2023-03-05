using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNet6
{
    internal class TypeA
    {
        public int x{ get; set; }
        public int y{ get; set; }
        
        public TypeA() {
            x= 0;
            y= 0;
        }
        public TypeA(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"x={x},y={y}";
        }
    }
}

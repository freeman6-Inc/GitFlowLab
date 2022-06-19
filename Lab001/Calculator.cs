using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab001
{
    public class Calculator
    {
        public int Addition(int x, int y) => x + y;
        public int Subtract(int x, int y) => x - y;
        public int Multiply(int x, int y) => x * y;
        public int Divide(int x, int y) => (y==0)? 0: x / y;
        public float Divide(float x, float y) => (y == 0) ? 0 : x / y;
        public float Multiply(float x, float y) => x * y;
    }
}

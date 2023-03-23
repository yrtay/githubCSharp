using System;

namespace calculator
{
    class Calculate
    {
        public double z;
        public void add(double x, double y)
        {
            z = x + y;
            Console.WriteLine("相加為:" + z);
        }
        public void sub(double x, double y)
        {
            z = x - y;
            Console.WriteLine("相減為:" + z);
        }
        public void mul(double x, double y)
        {
            z = x * y;
            Console.WriteLine("相乘為:" + z);
        }
        public void div(double x, double y)
        {
            z = x / y;
            Console.WriteLine("相除為:" + z);
        }
    }
}

using System;

namespace MyDictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<string, int> Emergency = new MyDictonary<string, int>();
            Emergency.Add("Ambulance", 112);
            Emergency.Add("Fire", 110);
            Emergency.Add("Police", 155);
            Emergency.Add("Gendarme", 156);
            Emergency.List();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Kompleks
{

    public int reel, sanal;
    public Kompleks(int reel, int sanal)
    {
        this.reel = reel;
        this.reel = sanal;
    }
    public static Kompleks operator +(Kompleks c1, Kompleks c2)
    {
        return new Kompleks(c1.reel + c2.reel, c1.sanal + c2.sanal);
    }
}

namespace overloading_
{
    class Program
    {
        static void Main(string[] args)
        {
            Kompleks num1 = new Kompleks(2, 3);
            Kompleks num2 = new Kompleks(3, 4);

            Kompleks toplam = num1 + num2;

            Console.WriteLine("num1 reel{0}, num1 sanal{1}", num1.reel, num1.sanal);
            Console.WriteLine("num2 reel{0}, num2 sanal{1}", num2.reel, num2.sanal);
            Console.WriteLine("toplam reel{0}, toplam sanal{1}", toplam.reel, toplam.sanal);
        }
    }
}

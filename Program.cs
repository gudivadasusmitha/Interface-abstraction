using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{/*
    interface Ianimal
    {
        void animalsound();
    }
    class dog : Ianimal
    {
        public void animalsound()
        {
            Console.WriteLine("the dog says : bow bow");
            Console.ReadLine();
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            dog mydog = new dog();
            mydog.animalsound();
        }
    }
    */
    //***********abstraction*************
    abstract class animal
    {
        public abstract void animalsound();
        public void sleep()
        {
            Console.WriteLine("zzz");
        }
    }
    class dog :animal
    {
        public override void animalsound()
        {
            Console.WriteLine("the dog says : bow bow");
            Console.ReadLine();
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            dog mydog = new dog();
            mydog.animalsound();
            mydog.sleep();
        }
    }
    
}

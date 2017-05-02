using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyInitialization
{
    class SampleClass
    {
        private int mID;
        private int mAge;
        private string mName;

        public SampleClass(int id, int age, string name)
        {
            mID = id;
            mAge = age;
            mName = name;
        }

        public void ShowDetail()
        {
            Console.WriteLine("ID:" + mID + " Age:" + mAge + " Name:" + mName);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lazy<SampleClass> objSampleClass = new Lazy<SampleClass>(() => new SampleClass(1, 28, "Ashish Kalra"));

            Console.WriteLine("Lazy Initialization of Sample Class");

            objSampleClass.Value.ShowDetail();            
                        
            Console.ReadKey();
        }
    }
}

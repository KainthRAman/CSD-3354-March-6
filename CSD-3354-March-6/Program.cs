using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD_3354_March_6
{
    public class DelegateExercises
    {
        public delegate void MyDelegate();
        void method1()
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(method1);
            myDelegate();
        }
    }

    public class Raman
    {
        public static void Main()
        {
            var de = new DelegateExercises();
            de.Method2();
      
        }

    }
}
    
        
           
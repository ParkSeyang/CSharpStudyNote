using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNote
{
    internal class Delegate
    {
        /* Delegate란?
         * 대리자라고하며 함수를 타입화 한것이라고합니다.
         */

        public delegate void Carlum();

        public class DelegateClass
        {
            public int Sum(int a, int b)
            {
                return a + b; 
            }
            public int Minus(int a, int b)
            {
                return a - b;
            }



        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class A
    {
        protected int i = 9;
        private void method1()
        {

        }
    }
    public class B : A
    {
        private void method1()
        {
            int j = base.i;
        }
    }
    public class C : B
    {
        public void method1()
        {
            int k = i;
        }
    }
}

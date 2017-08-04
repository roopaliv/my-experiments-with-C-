using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PartialInheritance1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            PartialInheritance1.def2 objDef2 = new PartialInheritance1.def2();
            PartialInheritance2.def objDef = new PartialInheritance2.def();


            PartialInheritance1.def2 objDef2WithParams = new PartialInheritance1.def2(8);
            PartialInheritance2.def objDefWithParams = new PartialInheritance2.def(8);


            PartialInheritance1.def2 objDef2WithBase = new PartialInheritance1.def2(9, 0);
            PartialInheritance2.def objDefWithBase = new PartialInheritance2.def(9, 0);

            DelegatesTestNamespace.DelegateTestClass objDelegateTestClass = new DelegatesTestNamespace.DelegateTestClass();
            int resultSingleDelegate;
            resultSingleDelegate = objDelegateTestClass.DelegateTestMethod(objDelegateTestClass.objAddDelegate, 5, 2);

            int resultMultipleDelegate;
            resultMultipleDelegate = objDelegateTestClass.testMultiCastDelegate(5, 2);


        }
    }

    public partial class abc
    {
        protected internal abc()
        {
            a = 1;
        }
        protected internal int a;
    }
    public partial class abc
    {

        //abc() //Error	Type 'Test.abc' already defines a member called 'abc' with the same parameter types	29	9	Test

        //{
        //    b = 1;
        //}

        protected internal abc(int a)
        {
            this.a = a;
        }
        protected int b;
    }
    public partial class abc
    {
        int c;// int a gives error
    }
    public partial class abc
    {
        delegate void MyDelegate();
    }

    public partial interface iabc
    {
        //delegate void MyDelegate(); //gives error interfaces cant declare types
        // string a; //gives error	Interfaces cannot contain fields	

        void meth1();// public void meth1(); //gives error 		The modifier 'public' is not valid for this item	

        string a
        {
            get;
            set;
        }
    }
    public partial interface iabc
    {
        void meth2();//void meth1(); gives error
    }
    public partial interface iabc
    {
    }

    public class def2 : abc
    {
        public def2()
        {
            d = 5;
        }
        public def2(int d)
        {
            this.d = d;
        }
        public def2(int d, int noUse)
            : base(5)
        {
            this.d = d;
        }
        public int d;
    }

    //public class jkl2 : iabc // Error'Test.jkl2' does not implement interface member 'Test.iabc.meth2()', 'Test.iabc.a','Test.iabc.meth1()'
    //{
    //}


    public class jkl2 : iabc // Error
    {
        public string a
        {
            get;
            set;
        }

        public void meth1()
        {
        }

        public void meth2()
        {
        }
    }
}


namespace PartialInheritance2
{
    public partial class abc
    {
        protected int o;
    }
    public partial class abc
    {
    }
    public partial interface iabc
    {
    }

    public class def : abc
    {
        public def()
        {
            d = 5;
        }
        public def(int d)
        {
            this.d = d;
        }
        public def(int d, int noUse) //: base(5)// error abc constructor is not accessible 
        {
            this.d = d;
        }
        public int d;
    }

    public class jkl : iabc // No Error
    {
    }
}

namespace DelegatesTestNamespace
{
    public delegate int TestDelegate(int del1, int del2);

    public class DelegateTestClass
    {
        public static int Add(int a, int b) // essential to make it static since A field initializer cannot reference the non-static field, method, or property 
        {
            return a + b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public TestDelegate objAddDelegate = new TestDelegate(Add);
        public TestDelegate objMultiplyDelegate = new TestDelegate(Multiply);
        public TestDelegate objDivideDelegate = new TestDelegate(Divide);
        public TestDelegate objSubtractDelegate = new TestDelegate(Subtract);

        // TestDelegate objMulticastDelegate = null;
        // objMulticastDelegate += new TestDelegate(Add);//Error 'objMulticastDelegate' is a 'field' but is used like a 'type'	

        public int testMultiCastDelegate(int a, int b)
        {
            TestDelegate objMulticastDelegate = null;
            objMulticastDelegate += new TestDelegate(Add);
            objMulticastDelegate += new TestDelegate(Multiply);
            objMulticastDelegate += new TestDelegate(Divide);
            objMulticastDelegate += new TestDelegate(Subtract);

            return objMulticastDelegate(a, b);
        }
        
        public int DelegateTestMethod(TestDelegate methodToBeCalled, int a, int b)
        {
            return methodToBeCalled(a, b);
        }


    }
}

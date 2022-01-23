using OOPExamples.Entities.Shopping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples.Entities.Extra
{
    public class TestClass
    {

        public void F1()
        {
            //VIPCustomer vip = new Customer("aaaa", "443543543");

            VIPCustomer vip = (VIPCustomer)new Customer("aaaa", "443543543");


            // Customer c = new VIPCustomer("", "", EnMembershipCard.Silver);

            //B b = new B();
            //b.B1();
            //b.A1();
            //b.A1(12345);


            // A a1 = new B();

            // B b = (B)new A();


            // B : A 

            A a1 = new A();

            B b1 = new B();

            if ( a1 is B )
            {
                B b2 = (a1 as B);
            }

            if (b1 is A)
            {
                A a2 = (b1 as A);
            }
        }
    }



    //Circular base type dependency involving 'B' and 'A'	


    // Base    = Parent  = SuperClass
    // Derived = Child   = SubClass


    public class A //: B
    {

        public A()
        {

        }

        public void A1()
        {
            System.Diagnostics.Debug.WriteLine("A _ A1");
        }
    }


    //Class 'B' cannot have multiple base classes: 'A' and 'C'	

    public class B : A //, C
    {

        public B()
        {

        }


        public void B1()
        {
            System.Diagnostics.Debug.WriteLine("B _ B1 _ B4");
            this.A1();
            System.Diagnostics.Debug.WriteLine("B _ B1 _ After");

        }

        public void A1(int number)
        {
            System.Diagnostics.Debug.WriteLine("B _ A1 _ " + number );

        }

        public new void A1()
        {
            System.Diagnostics.Debug.WriteLine("B _ A1");

        }

    }

    class C
    {

    }

    // Child ch = new Parent()
    // Parent p = new Child()


    class X
    {
        public int P1 = 1;
        private int P2 = 2;
        protected int P3 = 3;

        public virtual void X1() { }
    }

    class Y : X
    {
        public override void X1()
        {
            P1++;
            //P2++;
            P3++;

            base.X1();
        }
    }

    class Z : Y
    {
        public sealed override void X1()
        {
            P1++;
            //P2++;
            P3++;
            base.X1();
        }
    }

    class Z1 : Z
    {
        //public override void X1()
        //{
        //    base.X1();
        //}
    }
}

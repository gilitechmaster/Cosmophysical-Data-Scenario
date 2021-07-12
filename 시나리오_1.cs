using System;

class A
{
    public void A1()
    {
        Console.WriteLine("A-A1");
    }
}

class B : A
{
    public void B1()
    {
        Console.WriteLine("B-B1");
    }
    public void B2()
    {
        Console.WriteLine("B-B2");
    }
    public void B3()
    {
        Console.WriteLine("B-B3");
    }
}

class C : A
{
    public void C1()
    {
        Console.WriteLine("C-C1");
    }
}

class D : B
{
    public void D1()
    {
        Console.WriteLine("D-D1");
    }
}

class Program
{
    static void Main(string[] args)
    {
        A 개체 = new A();
        B 개체2 = new B();
        C 개체3 = new C();
        D 개체4 = new D();

        //주석처리는 접근불가능한 개체들

        개체.A1();
        //개체.B1();
        //개체.B2();
        //개체.B3();
        //개체.C1();
        //개체.D1();
        
        개체2.A1();
        개체2.B1();
        개체2.B2();
        개체2.B3();
        //개체2.C1();
        //개체2.D1();

        개체3.A1();
        //개체3.B1();
        //개체3.B2();
        //개체3.B3();
        개체3.C1();
        //개체3.D1();

        개체4.A1();
        개체4.B1();
        개체4.B2();
        개체4.B3();
        //개체4.C1();
        개체4.D1();

    }
}






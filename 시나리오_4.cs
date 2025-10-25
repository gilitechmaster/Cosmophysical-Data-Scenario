using System;
public class A // 구역 1
{
  public int b = 1;
}
public class B : A // 구역 2
{
  public int B1()
  {
    return this.b;
  }
}
public class C : A // 구역 3
{
  private int c = 3;
  public int C1()
  {
    return this.c;
  }
}
public class Program // 구역 4
{
  public static void Main(string[] args)
  {
    var a = new A();
    var a2 = new B();
    var a3 =  new C();
    Console.WriteLine(a2.B1());
    Console.WriteLine(a3.C1());
  }
}

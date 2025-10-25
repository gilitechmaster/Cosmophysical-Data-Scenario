using System;
public class A
{
  private int b = 1;
  public class B : A // B는 A에서 파생된다.
  {
    public int B1()
    {
      return this.b;
    }
  }
}
public class Program
{
  public static void Main(string[] args)
  {
    var a = new A.B(); // A에서 파생된 중첩클래스
    Console.WriteLine(a.B1());
  }
}

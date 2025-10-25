using System;
public class A
{
  private int b = 1; // b는 private이므로 다른 클래스에서 사용할 수 없다.
  //public int b = 1; // 위의 private 대신에 public 으로 쓰면 아래 this.b 에서 쓸 수 있다.
  public class B : A // B는 A에서 파생된다.
  {
    public int B1()
    {
      return this.b;
    }
  }
}
public class C : A
{
  public int C1()
  {
  return this.b; // 위의 private는 여기서 쓸 수 없다는 말이다.
  }
}
public class Program
{
  public static void Main(string[] args)
  {
    var a = new A.B();
    var a2 = new C();
    Console.WriteLine(a.B1());
    Console.WriteLine(a2.c1());
  }
}

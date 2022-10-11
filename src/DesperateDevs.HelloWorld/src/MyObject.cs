namespace DesperateDevs.HelloWorld;

public class MyObject
{
    public int MyInt => 42;
    public string MyString => "42";

    public bool IsMyInt(int i)
    {
        if (i == MyInt)
            return true;
        else
            return false;
    }

    public void SayHi(int i)
    {
        Console.WriteLine("Hello");
    }
}

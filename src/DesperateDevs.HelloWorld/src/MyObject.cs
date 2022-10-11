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

    public string Say(string message) => message;

    public string Greet(string message) => message;
}

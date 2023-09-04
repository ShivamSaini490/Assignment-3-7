using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MyClass
{
    private string privateProperty;

    public MyClass(string initialValue)
    {
        privateProperty = initialValue;
    }

    public void SetPrivateProperty(string newValue)
    {
        privateProperty = newValue;
    }

    public string GetPrivateProperty()
    {
        return privateProperty;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass myObject = new MyClass("Initial Value");

        Console.WriteLine("Initial Private Property Value: " + myObject.GetPrivateProperty());

        myObject.SetPrivateProperty("Modified Value");

        Console.WriteLine("Modified Private Property Value: " + myObject.GetPrivateProperty());
    }
}

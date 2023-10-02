#region Activator Sınıfı İle Nesne Oluşturma
using System.Dynamic;
using System.Net.Http.Headers;

//Type type = typeof(MyClass);
//MyClass m = (MyClass)Activator.CreateInstance(typeof(MyClass));
#endregion
#region DynamicObject Sınıfı İle Nesne Oluşturma
//dynamic my = new MyClass();
//my.DynamicProperty1 = 123;
//my.DynamicProperty2 = "123";

//Console.WriteLine(my.DynamicProperty1);
//Console.WriteLine(my.DynamicProperty2);
#endregion
#region dynamic Keyword'u İle Nesne Oluşturma
dynamic obj = new ExpandoObject();
obj.P1 = 123;
obj.P2 = "321";

Console.WriteLine(obj.P1);
#endregion

class MyClass : DynamicObject
{
    public MyClass()
    {
        Console.WriteLine($"{nameof(MyClass)} instance created..");
    }
    private readonly Dictionary<string, object> properties = new();
    public override bool TrySetMember(SetMemberBinder binder, object? value)
    {
        properties.Add(binder.Name, value);
        return true;
    }
    public override bool TryGetMember(GetMemberBinder binder, out object? result)
    {
        return properties.TryGetValue(binder.Name, out result);
    }
}
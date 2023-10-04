#region Giriş
//int i = 3;
//string s = "asd";
//char c = 'a';

////Polimorfizm
//A a = new B();

////Covariance
//object[] isimler = new string[5] { "Arda", "Bihter", "Berna", "Ada", "Falan" };

////Covariance
//A[] aArrays = new B[3];

////Covariance
//IEnumerable<object> arabalar = new List<string>() { "Opel", "Toyota", "Mercedes" };

////Covariance
//IEnumerable<A> asd = new List<B> { new(), new() };

////Covariance
//Func<A> funcA = GetB;
//B GetB() => new();

////Contravariance
//Action<string> xDelegate = XMethod;
//void XMethod(object o) { }

////Contravariance
//Action<B> bDelegate = AMethod;
//void AMethod(A a) { }
#endregion
#region Covarianca
#region Array Types
//object[] x = new string[5];
//x[0] = "asdasdasd";
//x[1] = true;
//x[2] = 123;
#endregion
#region Return Type

#endregion
#region Generic Types
//IAnimal<object> objectAnimal = new Animal<string>();
//IAnimal<A> aAnimal = new Animal<B>();
//IAnimal<A> aAnimal2 = new Animal<A>();
////out keywordü sade ve sadece interface veya delegatelerde kullanabiliyoruz !!!
//interface IAnimal<out T> // out keywordünü kullanmak şartıyla
//{

//}
//class Animal<T> : IAnimal<T>
//{

//}
#endregion
#endregion
#region Contravariance
#region Delegate Types
//Action<A> a = a => { };
//Action<B> b = a;
#endregion
#region Generic Types
IAnimal<string> s = new Animal<object>();
IAnimal<B> a = new Animal<A>();
IAnimal<B> b = new Animal<B>();
IAnimal<B> o = new Animal<object>();
interface IAnimal<in T>{}
class Animal<T> : IAnimal<T>{}
#endregion
#endregion

class A
{
    public virtual A X() => new();
}
class B : A
{
    public override B X() => new();
}
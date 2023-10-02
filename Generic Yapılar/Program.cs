////Generic Yapılar Nedir? Ne Amaca Hizmet Eder ?
///C#'ta generic yapılar, veri tipi bağımsız yapılar(class,interface,struct,metot ve delegate) oluşturmamızı sağlayan dilin yeteneği olan özel bir niteliktir.
///Genel olarak, aynı mantığı farklı veri tiplerinde çalıştıracağımız durumları tasarlamak için generic yapılardan istifade edebiliriz.
///Böylece her bir tip için aynı işi tekrar tekrar yapmaktansa tek seferde yapıp, tüm türler için genelleyebilmekteyiz.
///Buna örnek vermemiz gerekirse eğer; misal olarak meype sepeti uygulaması geliştirdiğimizi varsayalım.Sepette farklı tipte meyveleri saklamak istiyorsunuz.İşte bu durumda her bir meyve için ayrı ayrı çalışma yapmaktansa generic yapılar eşliğinde tek bir sepet çalışması yapabilir ve bunu tüm meyvelere genelleyebiliriz.


//MyClass<int,string,bool,char> m = new();

//class MyClass<T1, T2, T3, T4>
//{
//    T1 field;
//    public T2 Property { get; set; }
//    public T3 Method1()
//    {
//        //....
//    }
//    public T3 Method2(T4 param) 
//    { 
//        //....
//    }
//}

//Metotlarda generic tanımlama
X<int>(3);
X("asdasd");
void X<A>(A a)
{

}
//Value Type Constraints
Y<MyStruct>(new());
Y<int>(new());
Y<char>(new());
Y<long>(new());
void Y<T>(T a) where T : struct
{

}
//Reference Type Constraints
Z<MyClass>(new());
void Z<T>(T b) where T : class
{

}
//New Constraint
M<MyClass>(new());
M<MyStruct>(new());
M<MyRecord>(new());
void M<T>(T n) where T : new()
{
    T t = new T();
}
N<B>(new()); //A clasından türediği için B classınıda verebiliriz.
void N<T>(T n) where T : A
{
    
}
class MyClass{}
abstract class MyAbstractClass{}
interface IMyInterface{}
record MyRecord { }
struct MyStruct { }
class A
{
    public virtual void K<T>()
    {

    }
}
interface IExample
{
    void G<T>();
}
class B : A, IExample
{
    public override void K<T>() where T : default //Default constraint
    {
        
    }

    void IExample.G<T>() where T : default //Explicit implementation
    {
        throw new NotImplementedException();
    }
}
class C 
{ 

}
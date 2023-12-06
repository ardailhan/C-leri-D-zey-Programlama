//Çoklu Temsilciler
XHandler xdelegate = () => Console.WriteLine("Metot 1");
xdelegate += () => Console.WriteLine("Metot 2");
xdelegate += Metot3;
xdelegate += () => Console.WriteLine("Metot 4");
xdelegate += () => Console.WriteLine("Metot 5");
//tüm metotlar çalıştırılacaktır.
xdelegate();
//Metot 3 devre dışı bırakmak istersek..
xdelegate -= Metot3;
Console.WriteLine("***********");
xdelegate();

//Bu şekilde de delegate'in temsil ettiği tüm fonksiyonlara erişim sağlayabiliriz
var methods = xdelegate.GetInvocationList();
foreach (var method in methods)
{
    Console.WriteLine(method.Method.Name);
}

void Metot3()
{
    Console.WriteLine("Metot 3");
}

public delegate void XHandler();




//XHandler xdelegete = new(X);
////Anonymous type
//XHandler x2delegate = delegate () { };
////xdelegate'i tetikleme
//xdelegete();
////delegatelerle new operatörü olmadanda instance oluşturabiliyoruz.
//YHandler ydelegate = Y;
////veya..
//YHandler y2delegate = (a, p) => (3, 'a');
////veya
////YHandler y2delegate = (a, p) =>
////{
////    return (3, 'a');
////};
//YHandler y3delegate = delegate (A a, (string, int) p) { return (3, '1'); };
////ydelegate tetiklemek istersek..
//(int, char) r = y3delegate(new(), ("asdasd", 123));

//void X()
//{
//    Console.WriteLine("X metodu");
//}

//(int, char) Y(A a, (string, int) p)
//{
//    return (3, 'a');
//}

//public delegate void XHandler();
//public delegate (int, char) YHandler(A a, (string, int) p);

//public class A
//{

//}
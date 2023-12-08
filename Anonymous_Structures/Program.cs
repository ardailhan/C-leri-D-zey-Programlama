#region Anonymous Objects

//Read-only olarak oluşturulacaktır
//var anonymousObject1 = new
//{
//    A = "asdasd",
//    B = 3.14
//};
#endregion
#region Anonymous Methods

//Topla topla1 = new Topla((sayi1, sayi2) => sayi1 + sayi2);
//Topla topla2 = ((sayi1, sayi2) => sayi1 + sayi2);
//Topla topla3 = delegate (int sayi1, int sayi2)
//{
//    return sayi1 + sayi2;
//};

//var function1 = () => { };
//var function2 = (char x) => { };
//var function3 = () => { return true; };
//var function4 = (int a, string b) => { return true; };

//int topla(int sayi1, int sayi2)
//{
//    return sayi1 + sayi2;
//}

//delegate int Topla(int sayi1, int sayi2);
#endregion
#region Anonymous Collection

//Array

using Microsoft.VisualBasic;

var x = new[] { 3, 5 };

//List
var y = new Collection()
{
    new {A = 1},
    new {B = 2},
    new {C = 3}
};

#endregion
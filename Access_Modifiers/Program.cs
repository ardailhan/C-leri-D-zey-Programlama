using ClassLibrary1;

Class1 c = new();
//X metodunun erişim belirleyicisi artık private oldugu için erişim kısıtlanmıstır.
//c.X();
c.Y();
//Z metodu protected olarak olusturuldugu için instance üzerinden erişim sağlanamaz.
//c.Z();

class MyClass : Class1
{
    public MyClass()
    {
        //Internal olarak belirlenen bir metod ya da sınıf ne oluşturulduğu sınıfın instance'ı üzerinden ne de kalıtım yoluyla erişilemez durumdadır.
        //W();
        //Protected internal internal olmasına rağmen aynı zamanda Protected özelliği barındırdıgı için kalıtım alınan bir sınıf içinde oluşturulduysa bir başka proje üzerinden erişim sağlanabilir.
        Q();
    }
}
namespace ClassLibrary1
{
    public class Class1
    {
        private void X()
        {

        }
        //Aynı sınıf içerisinde private olmasına ragmen X metoduna erişim sağlanabilir.
        public void Y()
        {
            //Aynı class içinde tanımlandıkları için hem private hem protected olarak tanımlanmıs metodlara erişim sağlanabilmektedir.
            X();
            Z();
        }
        protected void Z()
        {

        }
        internal void W()
        {

        }
        protected internal void Q()
        {

        }
        private protected void A()
        {

        }
    }
    public class Class2 : Class1
    {
        public Class2()
        {
            Class1 c = new();
            //class2 sınıfı class1 sınıfından kalıtım aldıgından dolayı Z metodunun erişim belirteci Protected olmasına rağmen erişim sağlanabilmektedir.
            Z();
            //Aynı proje içerinden internal olarak oluşturulmus bir metoda erişim sağlayabilmekteyiz.
            c.W();
            //Q metodu protected internal belirtecinin internal özelliğinden dolayı instance üzerinden erişim sağlayabilmekteyiz
            c.Q();
            //Private protected olarak işaretlenmiş bir metoda Instance üzerinden erişim sağlayamayız ancak protected oldugu ve kalıtım söz konusu oldugu için A metoduna erişebiliyoruz.
            A();
        }
    }
    //Classlar default olarak internal halindedir.
    class MyClass2
    {

    }
}

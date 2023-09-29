////İstisnai Durum Nedir ?
//İstisnai durumlar, bir programın çalışma sırasında normal akışını bozan, beklenmeyen olay veya durumları ifade eder.
//İstisnai durumlar, genellikle programın doğru çalışmasını engelleyen veya istenmeyen sonuçlar doğuran hatalı durumlar olarak düşünülebilir.
//Bizler istisnai durumlar adı altında ifade edilen tanımlar/sınıflar/çalışmalar sayesinde, programın akışını olumsuz etkileyen anlarda, normalden farklı bir şekilde yönlendirmede bulunabilir, kullanıcıya uygun bir hata mesajı gösterebilir veya hatayı düzgün bir şekilde işleyebiliriz.
//Böylece programın çökmesini veya istenmeyen sonuçlar doğurmasını engelleyebiliriz.
//C# da istisnai durumlar, bir dizi sınıf tarafından ele alınmaktadır ve her hatayı tarif edecek bir sınıf tanımı söz konusudur.Hata durumlarında, bu hataların işlenmesi için dilin getirisi olan try-catch yapısı kullanılarak bu sınıflardan istifade edilmektedir.

//try
//{
//    int a = 1, b = 0;
//    Console.WriteLine(a / b);
//}
//catch (Exception ex)
//{

//}

try
{
    while (true)
    {
        var key = Console.ReadKey();
        if (key.Key == ConsoleKey.R)
        {
            throw new CustomException();
        }
        else
        {
            Console.WriteLine(key.Key);
        }
    }
}
catch (Exception ex)
{

}

class CustomException : Exception
{
    public CustomException() : base("R ye basmayacaktın hatası..")
    {
        
    }
    public CustomException(string message) : base(message)
    {
        
    }
    //public int MyProperty { get; set; }
}
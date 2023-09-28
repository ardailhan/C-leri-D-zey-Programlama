////Operator Overloading Ne Demektir ?
//////C# programlama dilinde operator overloading belirli(mevcut olan) operatörlerin davranışlarını kendi türlerinize özel bir şekilde biçimlendirmek için kullanılan bir özelliktir.


//Student student = new()
//{
//    Name = "Arda"
//};
//Book book = new()
//{
//    Name = "Empati",
//    Author = "Adam Fewer"
//};

////student.Books.Add(book);
////var result = book + student; //Bu şekilde kullanmak için operator overloadinglerini de simetrik olarak ayarlamalıyız.
//var result = student + book;

////Server.Download(5);
////Server.Upload(5);

//Server server = new();
//if (server >> 5)
//{

//}
//if (server << 3)
//{

//}

//class Server
//{
//    public static void Download(int fileCount)
//    {
//        for (int i = 0; i < fileCount; i++)
//            Console.WriteLine($"{i + 1}. file downloaded.");
//    }
//    public static void Upload(int fileCount)
//    {
//        for (int i = 0; i < fileCount; i++)
//            Console.WriteLine($"{i + 1}. file uploaded.");
//    }
//    public static bool operator >>(Server server, int fileCount)
//    {
//        Upload(fileCount);
//        return true;
//    }
//    public static bool operator <<(Server server, int fileCount)
//    {
//        Download(fileCount);
//        return true;
//    }
//}


//class Student
//{
//    public string Name { get; set; }
//    public List<Book> Books { get; set; } = new();
//}
//class Book
//{
//    public string Name { get; set; }
//    public string Author { get; set; }

//    public static Student operator +(Student s, Book b)
//    {
//        s.Books.Add(b);
//        return s;
//    }
//}

//Bazı istisna durumlar
//MyClass m = new();
//++m;
//var m2 = m++;
//Console.WriteLine(m.Count);
//class MyClass
//    {

//        public int Count { get; set; }
//        public static int operator +(MyClass s, Book b)
//        {
//            return 3;
//        }
//        public static int operator <(MyClass s, Book b)
//        {
//            return 3;
//        }
//        public static int operator >(MyClass s, Book b)
//        {
//            return 3;
//        }
//        //++ veya -- operatörleri overloading işlemine tabi tutulurken tekil bir parametreyle tanımlanmak zorundadır!
//        //Bu tekil parametrede overloadingin yapıldığı sınıfın türünden olmak zorundadır!
//        //Ve yine ++, -- operatörleri geriye tanımlandıkları sınıfın türünden değer döndürmelidir!
//        public static MyClass operator ++(MyClass m)
//        {
//            m.Count++;
//            return m;
//        }
//        public static MyClass operator --(MyClass m)
//        {
//            m.Count--;
//            return m;
//        }
//        //true ve false operatörlerinde overloading uyguluyorsak eğer bu operatörlerin geri dönüş değeri boolean olmak zorundadır!
//        //Parametreleri tekil olacak şekilde tanımlandıkları sınıf referansından olmalıdır!
//        public static bool operator true(MyClass m)
//        {
//            return true;
//        }
//        public static bool operator false(MyClass m)
//        {
//            return false;
//        }
//    }
Database db = new();
bool connectionState=  db + DatabaseType.SqlServer;
Console.WriteLine(connectionState);
class Database
{
    static string _connectionString;
    public static bool operator +(Database database,DatabaseType databaseType)
    {
        _connectionString = databaseType switch
        {
            DatabaseType.SqlServer => "Server.....",
            DatabaseType.Oracle => "Server...."
        };
        //Open connection
        return true;
    }
}
enum DatabaseType
{
    SqlServer, Oracle
}

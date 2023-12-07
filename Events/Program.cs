string path = @"C:\Users\ardai\Desktop\eventsExample";
PathControl pathControl = new();
pathControl.PathControlEvent += (sizeMB) =>
{
    Console.WriteLine($"Boyut 50Mb'ı aştı. Mevcut boyut : {sizeMB}");
};
await pathControl.Control(path);

class PathControl
{
    public delegate void PathHandler(float sizeMB);
    public event PathHandler PathControlEvent;

    public async Task Control(string path)
    {
        while (true)
        {
            await Task.Delay(1000);
            DirectoryInfo directoryInfo = new(path);
            var files = directoryInfo.GetFiles();
            float size = await Task.Run(() => directoryInfo.EnumerateFiles("*", SearchOption.AllDirectories).Sum(file => file.Length));
            float sizeMB = (size / 1024) / 1024;

            if (sizeMB > 50)
                PathControlEvent(sizeMB);
        }
    }
}





//MyEventPublisher m = new();
////Delegate'ler her ne kadar public olarak tanımlanmış olsalar da, tanımlandıkları sınıfların instance'ları üzerinden erişilememektedirler.
////Sadece sınıf referansı üzerinden erişim sağlanabilir.
//MyEventPublisher.XHandler xDelegate = new MyEventPublisher.XHandler(X);
////Eventler sayesinde instance üzerinden erişimi sağlayabiliyoruz !
//m.MyEvent += X;

//m.RaiseEvent();
//m.MyEvent -= X;
//void X()
//{
//    Console.WriteLine("Event Triggered..");
//}


//class MyEventPublisher
//{
//    public delegate void XHandler();
//    XHandler xdelegate;
//    public event XHandler MyEvent
//    {
//        add
//        {
//            Console.WriteLine("Method added to an event..");
//            xdelegate += value;
//        }
//        remove
//        {
//            Console.WriteLine("Method disconnected from event..");
//            xdelegate -= value;
//        }
//    }

//    public void RaiseEvent()
//    {
//        xdelegate();
//    }
//}
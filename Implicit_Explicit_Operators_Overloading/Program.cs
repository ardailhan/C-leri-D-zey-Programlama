//Imlplicit ve Explicit Nedir ?
//Atama sürecinde sağdaki değerin türüne soldaki referansın ya da değişkenin türü uyumlu olmalıdır!
//Bu ne kadar temel bir kural da olsa polimorfizm kuralları gereği esnetilebildiğini ve daha geniş türler tarafından alt türlerin referans edilebildiğini biliyoruz.
//Yani kalıtımsal ilişki olduğu sürece sağ sol kuralı geçerliliğini koruyabilmektedir.
//Polimorfizm kuralları olmaksızın atama sürecinde farklı türleri birbirlerine atayabilmek istiyorsak, bu durumda yapabileceğimiz tek şey gizli ya da açık bir tür dönüşümü gerçekleştirmek olacaktır.
//Implicit ve Explicit nedir sorusunda cevap vermeye çalışırsak eğer; bir verinin, kendi türünden olmayan farklı bir referansa yahut değişkene atanabilmesi için, atanma sürecinde yapılan tür dönüştürme işlemlerini açıklamak için kullanılan kavramlardır.
//Bu kavramlar tür dönüşümüyle alakalı oldukları için genellikle 'Explicit Conversion' ve 'Implicit Conversion' olarak nitelendirilirler.

A a = new B();
A a2 = (A)new B();

B b = (B)new A();

class A
{
    public static explicit operator B(A i)
    {
        return new B();
    }
}
class B
{
    public static implicit operator A(B i)
    {
        return new A() { };
    }
}
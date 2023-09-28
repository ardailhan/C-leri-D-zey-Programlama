//RefLocals
char o = 'a';
ref char p = ref o;


//RefReturn
int b = 5;
int c = X(ref b);
Console.WriteLine(b);
Console.WriteLine(c);
c = 123123123;
Console.WriteLine(b);
b = 123123;
Console.WriteLine(c);

ref int X(ref int a)
{
    a = 124;
    return ref a;
}
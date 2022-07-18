//1
void metod1 ()
{
    Console.WriteLine("Автор...");
} 
metod1();

//2
void metod2 (string msg)
{
    Console.WriteLine(msg);
}
metod2("Текст сообщения");

void metod21 (string msg, int count)
{
    int i = 0;
    while(i < count)
    {
    Console.WriteLine(msg);
    i++;
    }
}
//metod21("Текст сообщения", 3);
metod21(count: 3, msg: "Текст сообщения");

//3
int metod3()
{
    return DateTime.Now.Year;
}
int year = metod3();
Console.WriteLine(year);

//4
string metod4(int count1, string c)
{
    int j = 0;
    string result =String.Empty;
    while(j < count1 )
    {
        result = result + c;
        j++;
    }
    return result;
}
string res = metod4(10, "ZXC");
Console.WriteLine(res);
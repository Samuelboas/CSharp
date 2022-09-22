int fibNum1 = 0;
int fibNum2 = 1;
int fibNum3,i;
int maksfib = 41;

Console.WriteLine("hello now i will show you some magic");
Console.WriteLine("are you ready?");
Console.ReadLine();
Console.WriteLine("it did not matter what you said");
Console.WriteLine("we have to numbers in the start");
Thread.Sleep(2000);
Console.WriteLine("0:" + fibNum1);
Console.WriteLine("1:" + fibNum2);
Thread.Sleep(2000);

for(i=2;i<maksfib;++i)
{
Console.Write(i + ":");
fibNum3 = fibNum1 + fibNum2;
Console.WriteLine( + fibNum3);
fibNum1 = fibNum2;
fibNum2 = fibNum3;
Thread.Sleep(500);
}
Console.WriteLine("now that was a total of 40 numbers of fibonacci");
Console.ReadKey();

using Task;

int[] arr = { 1, 2, 3 };
byte[] arr2 = { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0 };
var a = new ByteStreamReverse();
//Console.WriteLine(a.GetIndiciesOfNumsThatSumToTarget(arr, 4));
foreach (var item in a.ReverseArrayByte(arr2))
{
    Console.Write($"{item},");
}
Console.ReadLine();

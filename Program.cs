class Program
{
static List<string> FilterStrings(string[] array)
{
List<string> filteredArray = new List<string>();
foreach (string str in array)
{
if (str.Length <= 3)
{
filteredArray.Add(str);
}
}
return filteredArray;
}
static void Main()
{
Console.WriteLine("Введите элементы массива, разделенные пробелами:");
string input = Console.ReadLine()!;
string[] array = input.Split();

List<string> filteredArray = FilterStrings(array);
Console.WriteLine("Результат:");
foreach (string str in filteredArray)
{
Console.WriteLine(str);
}
}
}
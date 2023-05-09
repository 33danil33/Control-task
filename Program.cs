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
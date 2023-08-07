// See https://aka.ms/new-console-template for more information
using Task3_2;

var list = new List<Employee>();

while (true)
{
    Console.WriteLine("Enter Employee info (name,age,salary) or -1 to end");
   
    string input = Console.ReadLine();

    string[] words = input.Split();

    if (words[0] == "-1")
    {
        break;
    }else if (words.Count() != 3)
    {
        Console.WriteLine("Error, Enter three values");
    }
    else if (int.Parse(words[1]) < 0 ||  double.Parse(words[2]) <0)
    {
        Console.WriteLine("Error, Enter a valid value");

    }
    else
    {
        list.Add(new Employee(words[0],  int.Parse(words[1]), double.Parse(words[2])));
    }
}

for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i].toString());
}
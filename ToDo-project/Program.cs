using System;
using System.Collections.Generic;

List<string> todoList = new List<string>();
string userInput = "";

while (userInput != "quit")
{
    Console.Write("Add meg a teendőd (vagy írja be a 'quit' parancsot a kilépéshez): ");
    userInput = Console.ReadLine();
    if (userInput != "quit")
    {
        todoList.Add(userInput);
    }
}

Console.WriteLine("\nA teendőid:");
for (int i = 0; i < todoList.Count; i++)
{
    Console.WriteLine($"{i + 1}. {todoList[i]}");
}

while (true)
{
    Console.Write("\nAdd meg a törlendő teendő sorszámát (vagy írja be a 'quit' parancsot a kilépéshez): ");
    userInput = Console.ReadLine();
    if (userInput == "quit")
    {
        break;
    }
    int index;
    if (int.TryParse(userInput, out index) && index > 0 && index <= todoList.Count)
    {
        todoList.RemoveAt(index - 1);
        Console.WriteLine("A teendő sikeresen törölve lett.");
        Console.WriteLine("\nA maradék teendőid:");
        for (int i = 0; i < todoList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {todoList[i]}");
        }
    }
    else
    {
        Console.WriteLine("Hibás bemenet, kérjük adjon meg egy érvényes sorszámot!");
    }
}


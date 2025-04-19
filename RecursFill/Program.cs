using System;
using System.Collections.Generic;

public static class Program
{
    public static void Main()
    {
        Dictionary<string, List<string>> someData = new Dictionary<string, List<string>>();
        someData["Петр Иванович"] = new List<string>();
        someData["Петр Иванович"].Add("Анна Петровна");
        someData["Петр Иванович"].Add("Максим Петровна");
        someData["Максим Иванович"] = new List<string>();
        someData["Максим Иванович"].Add("Андрей Максимович");
        someData["Максим Иванович"].Add("Миша Максимович");
        someData["Максим Иванович"].Add("Николай Максимович");
        someData["Анна Ивановна"] = new List<string>();
        someData["Анна Ивановна"].Add("Артем");
        someData["Анна Ивановна"].Add("Саша");
        someData["Николай Максимович"] = new List<string>();
        someData["Николай Максимович"].Add("Катя");
        someData["Николай Максимович"].Add("Маша");
        

        List<string> lastChilds = new List<string>();
        FillLastChildsIterative("Максим Иванович", someData, lastChilds);
        foreach (var child in lastChilds)
        {
            Console.WriteLine(child);
        }
    }

    private static void FillLastChildsIterative(string root, Dictionary<string, List<string>> someData, List<string> lastChilds)
    {
        var stack = new Stack<(string Name, int ChildIndex)>();
        stack.Push((root, 0));

        while (stack.Count > 0)
        {
            var current = stack.Pop();
            string currentName = current.Name;
            int childIndex = current.ChildIndex;

            if (!someData.ContainsKey(currentName))
            {
                lastChilds.Add(currentName);
                continue;
            }

            var children = someData[currentName];
            if (childIndex < children.Count)
            {
                // Push the current node back with incremented child index
                stack.Push((currentName, childIndex + 1));
                // Push the child to process next
                stack.Push((children[childIndex], 0));
            }
        }
    }
}
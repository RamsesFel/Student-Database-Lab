using System.Threading.Channels;

bool runProgram = true;
do
{
    string[] names = {
            "Justin", "Ethan", "Victoria", "Ethan", "Ben",
            "Kyra", "Jack", "Ramses", "Clare", "Ramsey",
            "Ali", "Pedro"
        };
    string[] favoriteFoods = {
            "Baja Blast", "Ethan", "Pho", "Hot Wings", "Crab legs",
            "Sushi", "Hot Wings", "Lasagna", "Cheesy Potatoes", "Dim Sum",
            "Indian", "Italian"
        };
    string[] hometowns = {
            "Westerville", "Ethan", "Blacksburg", "Bolivar", "Birmingham",
            "Hazel Park", "Trenton", "Wyoming", "Lake Orion", "Brooklyn",
            "Dearborn Heights", "Chicago"
        };

    Console.WriteLine($"Enter a number between 1-{names.Length} or name for a student, or enter list to see all students.");
    string input = Console.ReadLine().ToLower();
    int nameindex = 0;
    string singlename = "";
    if (input.All(char.IsDigit))
    {
        nameindex = int.Parse(input);
        if (nameindex >= 0 && nameindex < names.Length - 1)
        {
            Console.WriteLine(names[nameindex]);
        }
        else
        {
            Console.WriteLine("Invalid input. Try another number");
            continue;
        }
    }
    else if (input.ToLower().Contains("list"))
    {
        foreach (string n in names)
        {
            Console.WriteLine(n);
        }
        continue;
    }
    else
    {
        for (int i = 0; i < names.Length - 1; i++)
        {
            if (input == names[i].ToLower())
            {
                singlename = names[i];
                nameindex = i;
            }
        }
        if (singlename == "")
        {
            Console.WriteLine("Invalid input. Try another number");
            continue;
        }
        Console.WriteLine(singlename);
    }

    while (true)
    {
        Console.WriteLine("Would you like to know their hometown or favorite food?");
        string input2 = Console.ReadLine();
        if (input2.ToLower().Contains("town"))
        {
            Console.WriteLine(hometowns[nameindex]);
            break;
        }
        else if (input2.ToLower().Contains("food"))
        {
            Console.WriteLine(favoriteFoods[nameindex]);
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Please try again.");
        }
    }

    bool choice = true;
    while (choice)
    {
        Console.WriteLine("Would you like to learn about another student? y/n");
        string input3 = Console.ReadLine();
        if (input3 == "y")
        {
            break;
        }
        else if (input3 == "n")
        {
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("Please answer y/n");
            continue;
        }
    }
    


} while (runProgram);
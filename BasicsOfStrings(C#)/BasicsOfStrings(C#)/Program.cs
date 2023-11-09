string name = "Mam Makara";
string school = "RUPP University";
Console.WriteLine($"My friend name's {name} and we study at {school}");

// String properties Length

Console.WriteLine($"My numbers of my name is {name.Length} and my school's numbers is {school.Length}\n");

// String with trim methods [ stringVariable.Trim() // stringVariable.TrimStart() && // stringVariable.TrimEnd() ]
string vihecles = "    BMW    ";
Console.WriteLine($"{vihecles.Trim()} \nIf i trim end \n{vihecles.TrimEnd()} and If i trim start\n{vihecles.TrimStart()}\n");

// String parameters

string hello = "Hello my name is Mam Makara";
Console.WriteLine($"This is before use parameter Replace() method\n{hello}\n");

hello = hello.Replace("Mam Makara", "La La");
Console.WriteLine($"this is after use parameter Replace method\n{hello}\n");

// String ToLover() and ToUpper

string dogs = "Dogs are smart and funny";
Console.WriteLine($"{dogs.ToUpper()}");
Console.WriteLine($"{vihecles.ToLower()}");


string greeting = "      Hello World!       ";
Console.WriteLine($"[{greeting}]");              // [      Hello World!       ]

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");       //[Hello World!       ]

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");     // [      Hello World!]

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");       // [Hello World!]

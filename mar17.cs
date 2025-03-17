// Mod. 4 - Unit 5+
// We learned how to use those special characters and the bracket and backslashes.
// I got all of the questions correct.
string projectName = "ACME";
string english = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English Output:\n\t\t{english}\n");
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russian = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russian}\n");

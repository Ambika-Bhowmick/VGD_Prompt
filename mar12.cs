// Mod. 4 - Unit 3 & 4
// We reviewed how to combine literal strings together. Also, we learned how to use string interpolation.
string firstName = "Bob";
string message = $"Hello {firstName}!";
Console.WriteLine(message);
int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

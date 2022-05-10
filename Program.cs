// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// List of cities we need to join.
List<string> users = new List<string>();
users.Add("Paulo");
users.Add("Chico");
users.Add("Pele");
users.Add("Marcus");

    // Join strings into one CSV line.
string line = string.Join(",", users.ToArray());
Console.WriteLine(line);
   

Console.Write("введитеимя пользователя");
string username = Console.ReadLine();
 if(username.ToLower() == "саша")                               
{
    Console.WriteLine("УРА саша привет");
}
else
{
    Console.Write("привет, ");
    Console.WriteLine(username);
}

// то ловер означает нижний регистр ввода 

Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "даша")
{
    Console.WriteLine("Привет, лучший человек на планете");
}
else 
{
    Console.Write("Привет, тварь, ");
    Console.Write(username);
}

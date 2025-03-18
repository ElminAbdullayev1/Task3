using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

class Human
{
    public string Name;
    public string Surname; 
    private byte Age { get; set; }

    public Human(string name, string surname, byte age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }
     public void ShowFullData()
    {
        Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}");
    }
    public string GetFullName()
    {
        return $"{Name} {Surname}";
    }
}
class User: Human
{
    public string UserName;
    public string password;
    
    public User(string name, string surname, string UserName, string password): base(name,surname,20)
    {
        if (UserName.Length < 6 && UserName.Length > 25)
        {
            this.UserName = UserName;
        }
        else
        {
            Console.WriteLine("UserName minimum 6 Maksimum 25 karakter olamlidi");
        }
        if (password.Length > 7 && password.Length < 26) 
        {
            this.password = password;
        }
        else
        {
            Console.WriteLine("Password minimum 7 Maksimum 26 karakter olmalidi");
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ad daxil edin");
        string name=Console.ReadLine();
        Console.WriteLine("Soyad daxil edin");
        string surname = Console.ReadLine();
        Console.WriteLine("UserName daxil edin");
        string  UserName = Console.ReadLine();
        Console.WriteLine("Password daxil edin");
        string password = Console.ReadLine();

        User user = new User(name, surname, UserName, password);
    }

}
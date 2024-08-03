class Program
{
    static void Main()
    {
        //Default Constructor..
        Baby baby1 = new()
        {
            Name = "Emre",
            LastName = "TERKAN"
        };
        Console.WriteLine($"Baby name: {baby1.Name}, baby lastname : {baby1.LastName}"); 
        //Params Constructor..
        Baby baby2 = new("Burak", "KIRICI");
        Console.WriteLine($"Baby name: {baby2.Name}, baby lastname : {baby2.LastName}");

    }
}



public class Baby
{
    //Properties
    public string Name { get; set; }
    public string LastName { get; set; }
    public int BirthDay { get; set; }
    //Default Constructor..
    public Baby()
    {
        Console.WriteLine("Ingaaaa. Baby BirthDay :"+ DateTime.Now);
    }
    //Parametres Constructor.. 
    public Baby(string name, string lastname) : this() //i used "this" keyword because even when the parameterized constructor is triggered, the default constructor is triggered and prints text to the screen.
    {
        LastName = lastname;
        Name = name; 
    }
}


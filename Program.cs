using System

class Program
{
    static void Main(string[] args)
    {
        Person p = new Person("Olle", "90091212345", "Göteborg")
        p.ConsolePrint();
    }
}


class Person //en person
{
   public string Namn{get; set;}
   public string PersonNummer{get; set;}
   public string Adress{get; set;}
}

public Person(string Namn, string PersonNummer, string Adress)
{
        public List<Person> personList = new List<Person>();

        Namn = namn
        PersonNummer = personNummer
        Adress = adress

}
public void ConsolePrint()
{
    System.Console.WriteLine("Namn: " + Namn);
    System.Console.WriteLine("Personnummer: " + PersonNummer);
    System.Console.WriteLine("Adress: " + Adress);
    
}
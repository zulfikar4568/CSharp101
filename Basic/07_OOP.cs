namespace LearnCSharp.Basic
{
  // Simple Class
  class Person1
  {
    public required string FirstName;
    public required string LastName;
    public required string Address;
  }

  // With Constructors
  class Person2
  {
    private string _firstName;
    private string _lastName;
    private string _address;
    public Person2(string firstName, string lastName, string address)
    {
      _firstName = firstName;
      _lastName = lastName;
      _address = address;
    }
  }

  // Make more clearners
  class Person3(string firstName, string lastName, string address)
  {
    public string FirstName 
    {
      get {
        return firstName.ToUpper();
      }
    }
    
    public string LastName { get; } = lastName;
    public string Address { get; set; } = address;

    public List<Pet> MyPetList = [];
  }

  abstract class Pet(string name)
  {
    public string Name { get; } = name;
    public abstract void MakeNoise();
    public void WhoAmI() {
      Console.WriteLine($"    My name {Name} and I'm {GetType().Name}");
    }
  }

  class Dog(string name) : Pet(name)
  {
    public override void MakeNoise()
    {
      Console.WriteLine("Bark!!!");
    }
  }

  class Cat(string name) : Pet(name)
  {
    public override void MakeNoise()
    {
      Console.WriteLine("Meow!!!");
    }
  }
}

// Program.cs

// using LearnCSharp.Basic;

// var personSimple = new Person1() {
//   FirstName = "Zulfikar",
//   LastName = "Isnaen",
//   Address = "123 Main St",
// };

// Person3 person1 = new("Zulfikar", "Isnaen", "St Main Street");
// Dog dog1 = new("Chiko");
// Cat cat1 = new("Cilot");
// person1.MyPetList.Add(dog1);
// person1.MyPetList.Add(cat1);

// var person2 = new Person3("Sakip", "Hidayat", "St Main Street");
// // person1.FirstName = "Zul"; // readonly

// List<Person3> listOfPerson = [person1, person2];

// var queryPerson = from person in listOfPerson
//   where person.FirstName.Contains('Z')
//   select person;


// foreach (var person in queryPerson)
// {
//   Console.WriteLine($"Hi {person.FirstName} {person.LastName} and my address {person.Address}");

//   foreach (var pet in person.MyPetList)
//   {
//     pet.WhoAmI();
//   }
// }
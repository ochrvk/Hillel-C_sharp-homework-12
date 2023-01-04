class Animal
{
    public Animal()
    {
        name = "";
        family = "";
        id = Guid.NewGuid();
    }

    public string name;
    private string family;
    private int age;
    private Guid id;

    public string Family
    {
        get { return family; }
        set
        {
            if (value == "Dogs" || value == "Cats")
            {
                family = value;
            }
            else
            {
                throw new Exception("Impossible weight");
            }
        }
    }

    public virtual int Age
    {
        get { return age; }
        set
        {
            if (value < 18 && value > 0)
            {
                age = value;
            }
            else
            {
                throw new Exception("impossible height");
            }
        }
    }

    public override string ToString()
    {
        return $"ID: {id}\nFamily: {family}\nAge: {age}\nName: {name}";
    }
}

class Cat : Animal
{
    public Cat()
    {
        ownerName = "";
        base.Family = "Cats";
    }

    private int height;
    private int weight;
    public string ownerName;

    public int Height
    {
        get { return height; }
        set
        {
            if (value < 25 && value > 0)
            {
                height = value;
            }
            else
            {
                throw new Exception("impossible height");
            }
        }



    }

    public int Weight
    {
        get { return weight; }
        set
        {
            if (value < 5 && value > 0)
            {
                weight = value;
            }
            else
            {
                throw new Exception("Impossible weight");
            }
        }
    }

    bool IsHealth
    {
        get
        {
            return (weight >= 4 && weight <= 5) && (height >= 23 && height <= 25);
        }
    }

    public override string ToString()
    {
        return base.ToString() + $"\nHeight: {height}\nWeight: {weight}\nOwner name:" +
            $" {ownerName}\nIs cat health?:{IsHealth}";
    }
}

class Dog : Animal
{
    public Dog()
    {
        ownerName = "";
        base.Family = "Dogs";
    }

    private int height;
    private int weight;
    public string ownerName;

    public int Height
    {
        get { return height; }
        set
        {
            if (value < 25 && value > 0)
            {
                height = value;
            }
            else
            {
                throw new Exception("impossible height");
            }
        }



    }

    public int Weight
    {
        get { return weight; }
        set
        {
            if (value < 82 && value > 0)
            {
                weight = value;
            }
            else
            {
                throw new Exception("Impossible weight");
            }
        }
    }

    public bool IsHealth
    {
        get
        {
            return (weight >= 5 && weight <= 82) && (height >= 15 && height <= 110);
        }
    }

    public override int Age
    {
        set
        {
            if (value < 13 && value > 0)
            {
                base.Age = value;
            }
            else
            {
                throw new Exception("impossible height");
            }
        }
    }

    public override string ToString()
    {
        return base.ToString() + $"\nHeight: {height}\nWeight: {weight}\nOwner name:" +
            $" {ownerName}\nIs dog health?:{IsHealth}";
    }
}



class Technics
{
    public Technics()
    {
        id = Guid.NewGuid();
        name = "";
        type = "default type";
    }

    private Guid id;
    public string name;
    private string type;
    private int price;

    public string Type
    {
        get { return type; }
        set
        {
            if (value == "laptop" || value == "headphones")
            {
                type = value;
            }
            else
            {
                throw new Exception("wrong type!");
            }
        }
    }

    public int Price
    {
        get { return price; }
        set
        {
            if (value > 0 && value < 2000)
            {
                price = value;
            }
            else
            {
                throw new Exception("wrong value!");
            }
        }
    }

    public override string ToString()
    {
        return $"ID: {id}\nName: {name}\nType: {type}\nPrice: {price}";
    }
}

class Laptop : Technics
{
    public Laptop()
    {
        base.Type = "laptop";
    }

    private int ramAmount;

    private int year;

    public string Windows
    {
        get
        {
            if (year > 2017)
            {
                return "win11";
            }
            else
            {
                return "win7/8/10";
            }
        }
    }

    public int Year
    {
        get { return year; }
        set
        {
            if (value > 2004 && value < 2022)
            {
                year = value;
            }
            else
            {
                throw new Exception("Incorrect value");
            }
        }
    }

    public int RamAmount
    {
        get { return ramAmount; }
        set
        {
            //there no laptops with RAM less than 4 and higher than 128 in my imaginary store
            if (value > 4 && value < 128)
            {
                ramAmount = value;
            }
            else
            {
                throw new Exception("Incorrect value");
            }
        }
    }

    public override string ToString()
    {
        return base.ToString() + $"\nRAM: {ramAmount}\nYear: {year}\nWindows: {Windows}";
    }
}

class Headphones : Technics
{
    public Headphones()
    {
        base.Type = "headphones";
        connectionType = "";
    }

    private string connectionType;
    private int cableLengh;

    public bool BuiltInSoundCard
    {
        get
        {
            if (connectionType == "usb")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public string ConnectionType
    {
        get { return connectionType; }
        set
        {
            if (value == "usb" || value == "mini jack")
            {
                connectionType = value;
            }
            else
            {
                throw new Exception("Incorrect type!");
            }
        }
    }

    public int CableLengh
    {
        get { return cableLengh; }
        set
        {
            if (value > 0 && value < 3)
            {
                cableLengh = 3;
            }
            else
            {
                throw new Exception("Incorrect length");
            }
        }

    }

    public override string ToString()
    {
        return base.ToString() + $"\nConnection type: {connectionType}\n" +
            $"Cable lengh: {cableLengh}\nBuilt in sound card: {BuiltInSoundCard}";
    }
}



class Furniture
{
    public Furniture()
    {
        id = Guid.NewGuid();
        name = "";
        type = "";
    }

    private Guid id;
    public string name;
    private string type;
    private int price;

    public virtual string Type
    {
        get { return type; }
        set
        {
            if (value == "chair" || value == "sofa")
            {
                type = value;
            }
            else
            {
                throw new Exception("wrong value!");
            }
        }
    }

    public int Price
    {
        get { return price; }
        set
        {
            if (value > 500 && value < 2000)
            {
                price = value;
            }
            else
            {
                throw new Exception("wrong price!");
            }
        }
    }

    public override string ToString()
    {
        return $"ID: {id}\nName: {name}\nType: {type}\nPrice: {price}";
    }
}

class Chair : Furniture
{
    public Chair()
    {
        base.Type = "chair";
        material = "";
    }

    private int weight;
    private string material;
    private int chair_leg;

    public override string Type
    {
        get { return base.Type; }
    }


    public int Weight
    {
        get { return weight; }
        set
        {
            if (value > 10 && value < 100)
            {
                weight = value;
            }
            else
            {
                throw new Exception("wrong weight");
            }
        }
    }

    public string Material
    {
        get { return material; }
        set
        {
            if (value == "wood" || value == "iron")
            {
                material = value;
            }
            else
            {
                throw new Exception("Wrong material!");
            }
        }
    }

    public int Chair_leg
    {
        get { return chair_leg; }
        set
        {
            if (value >= 2 && value <= 6)
            {
                chair_leg = value;
            }
            else
            {
                throw new Exception("Worng value");
            }
        }
    }

    public override string ToString()
    {
        return base.ToString() + $"\nWeight: {weight}\nMaterial: {material}\n" +
            $"Table leg: {chair_leg}";
    }

}

class Sofa : Furniture
{
    public Sofa()
    {
        base.Type = "sofa";
        material = "";
    }

    private int sofa_legs;
    private string material;
    private int varanty;

    public override string Type
    {
        get { return base.Type; }
    }

    public int Sofa_legs
    {
        get { return sofa_legs; }
        set
        {
            if (value >= 4 && value <= 6)
            {
                sofa_legs = value;
            }
            else
            {
                throw new Exception("wrong value!");
            }
        }
    }

    public string Material
    {
        get { return material; }
        set
        {
            if (value == "leather" || value == "leatherette")
            {
                material = value;
            }
            else
            {
                throw new Exception("wrong material!");
            }
        }
    }

    public int Varanty
    {
        get { return varanty; }
        set
        {
            if (value > 1 && value < 18)
            {
                varanty = value;
            }
            else
            {
                throw new Exception("Wrong value!");
            }
        }
    }

    public override string ToString()
    {
        return base.ToString() + $"\nLegs count: {sofa_legs}\nMaterial: {material}" +
            $"\nVaranty: {varanty}";
    }
}



class Program
{
    static void FillCat(Cat cat)
    {
        Console.Write("Please type cat name: ");
        cat.name = Console.ReadLine();

        Console.Write("Please type cat age: ");
        while (true)
        {
            try
            {
                cat.Age = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.Write("Please type cat height: ");
        while (true)
        {
            try
            {
                cat.Height = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.Write("Please type cat weight: ");
        while (true)
        {
            try
            {
                cat.Weight = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.Write("Please type cat owner name: ");
        cat.ownerName = Console.ReadLine();
    }

    static void FillDog(Dog dog)
    {
        Console.Write("Please type dog name: ");
        dog.name = Console.ReadLine();

        Console.Write("Please type dog age: ");
        while (true)
        {
            try
            {
                dog.Age = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.Write("Please type dog height: ");
        while (true)
        {
            try
            {
                dog.Height = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.Write("Please type dog weight: ");
        while (true)
        {
            try
            {
                dog.Weight = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.Write("Please type dog owner name: ");
        dog.ownerName = Console.ReadLine();
    }

    static void FillLaptop(Laptop laptop)
    {
        Console.Write("Please type model name: ");
        laptop.name = Console.ReadLine();

        Console.Write("Please type price: ");
        while (true)
        {
            try
            {
                laptop.Price = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.Write("Please type RAM amount: ");
        while (true)
        {
            try
            {
                laptop.RamAmount = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.Write("Please type year of production: ");
        while (true)
        {
            try
            {
                laptop.Year = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }
    }

    static void FillHeadphones(Headphones headphones)
    {
        Console.Write("Please type model name: ");
        headphones.name = Console.ReadLine();

        Console.Write("Please type price: ");
        while (true)
        {
            try
            {
                headphones.Price = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.Write("Please type connection type: ");
        while (true)
        {
            try
            {
                headphones.ConnectionType = Console.ReadLine();
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.Write("Please type cable lenght: ");
        while (true)
        {
            try
            {
                headphones.CableLengh = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

    }

    static void FillChair(Chair chair)
    {
        Console.Write("Please type chair model name: ");
        chair.name = Console.ReadLine();

        Console.Write("Please enter material type: ");
        while (true)
        {
            try
            {
                chair.Material = Console.ReadLine();
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.Write("Please type price: ");
        while (true)
        {
            try
            {
                chair.Price = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.Write("Please type weight: ");
        while (true)
        {
            try
            {
                chair.Weight = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.Write("Please type chair-legs count: ");
        while (true)
        {
            try
            {
                chair.Chair_leg = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }
    }

    static void FillSofa(Sofa sofa)
    {
        Console.Write("Please type sofa model name: ");
        sofa.name = Console.ReadLine();

        Console.Write("Please enter material type: ");
        while (true)
        {
            try
            {
                sofa.Material = Console.ReadLine();
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.Write("Please type price: ");
        while (true)
        {
            try
            {
                sofa.Price = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.Write("Please type varanty: ");
        while (true)
        {
            try
            {
                sofa.Varanty = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }

        Console.Write("Please type sofa-legs count: ");
        while (true)
        {
            try
            {
                sofa.Sofa_legs = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, please try again: ");
            }
        }
    }


    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Cat cat = new Cat();
        FillCat(cat);
        Console.Clear();
        Console.WriteLine(cat.ToString());

        Dog dog = new Dog();
        FillDog(dog);
        Console.Clear();
        Console.WriteLine(dog.ToString());

        Laptop laptop = new Laptop();
        FillLaptop(laptop);
        Console.Clear();
        Console.WriteLine(laptop.ToString());

        Headphones headphones = new Headphones();
        FillHeadphones(headphones);
        Console.Clear();
        Console.WriteLine(headphones.ToString());


        Chair chair = new Chair();
        FillChair(chair);
        Console.Clear();
        Console.WriteLine(chair.ToString());


        Sofa sofa = new Sofa();
        FillSofa(sofa);
        Console.Clear();
        Console.WriteLine(sofa.ToString());
    }
}

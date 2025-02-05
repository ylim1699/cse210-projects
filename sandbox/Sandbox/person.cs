public class Person
{
    private string _name;
    private int _age;

    public Person()
    {
        _name = "unknown";
        _age = 0;
    }

    // public Person(string name, int age)
    // {
    //     _name = name;
    //     _age = age;
    // }

    // method allows you to update private variables
    public void SetAge(int age)
    {
        if (age >=0 && age <= 125) 
        {
            _age = age;
        }
        else
        {
            _age = 0;
        }
    }
    

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    
    public void Display()
    {
        Console.WriteLine($"{_name} - {_age}");
    }
}
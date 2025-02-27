public class Teacher : Staff 
{
    private int _roomNumber;

    public Teacher(string firstName, string lastName, string gender, int roomNumber) : base(firstName, lastName, gender)
    {
        _roomNumber = roomNumber;
    }
}


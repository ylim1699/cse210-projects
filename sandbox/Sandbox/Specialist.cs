public class Specialist : Staff
{
    private string _specialty;

    public Specialist(string firstName, string lastName, string gender, string specialty) : base(firstName, lastName, gender)
    {
        _specialty = specialty;
    }
}
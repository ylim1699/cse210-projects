public class ReceptionEvent : Event {
    private string _email;

     public ReceptionEvent(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

     public void DisplayFull()
    {
        DisplayStandard();
        Console.WriteLine($"Email: {_email}");
    }
}
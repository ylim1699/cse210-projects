public class LectureEvent : Event {
    private string _speaker;
    private int _capacity;

    public LectureEvent(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public void DisplayFull()
    {
        DisplayStandard();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
    }
}
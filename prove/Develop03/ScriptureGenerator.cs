public class ScriptureGenerator
{
    public List<Reference> _scripture = new List<Reference>();
    private string _filename = "scripture.txt";

    public void LoadFromFile()
    {
        string[] savedVerses = System.IO.File.ReadAllLines(_filename);

        foreach (string verse in savedVerses)
        {
            string[] parts = verse.Split('|');
            if (parts.Count() == 4)
            {
            Reference reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), parts[3]);
            _scripture.Add(reference);
            }
            else if (parts.Count() == 5)
            {
            Reference reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]), parts[4]);
            _scripture.Add(reference);
            }
        }
    }
    
    public Random random = new Random();
    
    public Reference GetRandomPrompt()
    {
        int index = random.Next(_scripture.Count);
        return _scripture[index];
    }
}
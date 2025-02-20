public class Scripture
{
    // store list of word objects
    private List<Word> _words = new List<Word>();
    private Reference _reference = new Reference();
    private Random _random = new Random();
    private string _verseText;

    public Scripture(Reference reference)
    {
        _reference = reference;
        _verseText = _reference.GetVerseText(); //important that this comes after we make an instance of Reference class right above, or else _verseText in the Reference class will be empty
        string[] split = _verseText.Split();
        foreach (string word in split)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

      public void HideWord(int count = 1)
    {
        var visibleWords = _words.Where(w => w.IsHidden() == false).ToList(); //makes a variable visibleWords and finds in _words list where _isHidden is false and puts it back into a list
        for (int i = 0; i < Math.Min(count, visibleWords.Count); i++) //makes the for loop go once at a time until there's nothing left in visiblewords list, hence why you use .Count
        {
            int index = _random.Next(visibleWords.Count);
            var wordToHide = visibleWords[index];
            wordToHide.Hide();

            var wordInOriginalList = _words.First(w => w == wordToHide);
            wordInOriginalList.Hide(); // question
            
            visibleWords.RemoveAt(index);
        }
    }

    public string Display()
    {
        List<string> renderedWords = new List<string>();
        foreach (Word word in _words)
        {
            renderedWords.Add(word.GetRenderedText());
        }
        string newVerse = string.Join(" ", renderedWords);
        return _reference.GetReference() + " - " + newVerse;
    }

    public bool IsCompletelyHidden()
    {   
        return _words.All(w => w.IsHidden() == true); //goes thorugh _words list and returns true if all the varialbe w._isHidden in each instances are true
    }

    // public bool IsCompletelyHidden()
    // {
    // foreach (Word word in _words)
    // {
    //     if (word._isHidden == true)
    //     {
    //         return true;
    //     }
    // }
    // }

//================================================================================================================================//

    // test to see if the verse is split and stored properly
     public List<Word> GetWord()
    {
       return _words;
    }

// Random _random;
// ConverToWord()
// HideWord()
// Display()
}






































































































































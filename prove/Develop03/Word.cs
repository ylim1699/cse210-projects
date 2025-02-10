public class Word
{
    private string _text;
    private bool _isHidden; 

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }

     public string GetRenderedText()
    {
        if (_isHidden == true)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }

//================================================================================================================================//

    //    public string GetText()
    // {
    //     return _text;
    // }


// Bool _isHidden;
// String _text;

// Display()
// IsHidden()
// Hide()
// GetRenderedText()

}
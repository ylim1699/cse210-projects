public class Movie
{
    public string _title;
    public int _year;
    public int _runTime;
    public string _rating;

    public void DisplayTitle()
    {
        Console.WriteLine($"The name of the movie is: {_title}.");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"This movie was made in the yearm {_year}, and is {_runTime} minutes long. \nHere is the rating for this movie: '{_rating}.'");
    }

}
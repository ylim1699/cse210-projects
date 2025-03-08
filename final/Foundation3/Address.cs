public class Address {
    private string _streetName;
    private string _cityName;
    private string _stateName;
    private string _countryName;
    public Address (string streetName, string cityName, string stateName, string countryName)
    {
        _streetName = streetName;
        _cityName = cityName;
        _stateName = stateName;
        _countryName = countryName;
    }

    public string GetAdress()
    {
        return $"{_streetName}, {_cityName}, {_stateName}, {_countryName}";
    }
}
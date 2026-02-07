using System;

namespace OnlineOrdering
{
    public class Address
    {
        private string _street;
        private string _city;
        private string _country;

        public Address(string street, string city, string country)
        {
            _street = street;
            _city = city;
            _country = country;
        }

        public bool IsInUSA()
        {
            return _country.ToLower() == "usa";
        }

        public string GetDisplayAddress()
        {
            return $"{_street}\n{_city}\n{_country}";
        }
    }
}
// An Account class that contains private instance variables
// first name, last name, year of birth, and current year
// and public methods to Set and Get their values.

using System;

class HeartRates
{
    private string _firstName;
    private string _lastName;
    private int _yearOfbirth;

    public HeartRates(string firstName, string lastName, int yearOfBirth)
    {
        // obtain current year
        CurrentYear = DateTime.Today.Year;
        // assign values passed into constructor
        FirstName = firstName;
        LastName = lastName;
        YearOfBirth = yearOfBirth;
    }

    // assign first name
    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value == "" ? "n/a" : value; }
    }

    // assign first name
    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value == "" ? "n/a" : value; }
    }

    // assign year of birth
    // if not provided, default to zero
    public int YearOfBirth
    {
        get { return _yearOfbirth; }
        set { _yearOfbirth = value < 1 ? 0 : value; }
    }

    // current year is set in constructor only
    // cannot be set by user
    public readonly int CurrentYear;

    // calculate person's age
    public int PersonsAge
    {
        get { return Convert.ToInt32(CurrentYear - YearOfBirth); }
    }

    // calculate maximum heart rate
    public int  MaxHeartRate
    {
        get { return 220 - PersonsAge; }
    }

    // calculate minimum target heart rate
    public int MinTargetRate
    {
        get { return Convert.ToInt32(MaxHeartRate * 0.5); }
    }

    // calculate maximum target heart rate
    public int MaxTargetRate
    {
        get { return Convert.ToInt32(MaxHeartRate * 0.85); }
    }

}


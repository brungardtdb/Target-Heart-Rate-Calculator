// Program:     Target Heart Rate Calculator
// Author:      David Brungardt
// Date:        1/13/2018
// Description: This program calculates a person's target heart rate and maximum
//              heart rate based on their age. The user inputs their first name
//              last name, and year of birth into the program, the program then 
//              calculates their max heart rate based on 220 - the person's age
//              and also calculates their min and max target heart rate (min = 50%
//              of max heart rate, max = 85% of max heart rate) 
//              (Note: these values are estimates provided by the AHA, Maximum and 
//              Target heart rates vary based on factors like health and age, consult
//              A physician or qualified health proffesional before beggining or modifying
//              an exercise program.)


using System;

class Program
{
    static void Main ()
    {
        // prompt user to enter name and year of birth

        Console.WriteLine($"Please enter the user's first name: "); 
        var firstName = Console.ReadLine();

        Console.WriteLine($"Please enter the user's last name:");
        var lastName = Console.ReadLine();

        Console.WriteLine($"Please enter the user's year of birth: ");
        var yearOfBirth = Convert.ToInt32(Console.ReadLine());

        var heartRate = new HeartRates(firstName, lastName, yearOfBirth);

        Console.WriteLine("Name of user: {0} {1}", heartRate.FirstName, heartRate.LastName);
        Console.WriteLine("Age of user: {0}", heartRate.PersonsAge);
        Console.WriteLine("User's maximum safe heart rate: {0} bpm", heartRate.MaxHeartRate);
        Console.WriteLine("User's target heart rate range: {0} bpm - {1} bpm", heartRate.MinTargetRate, heartRate.MaxTargetRate);
    }

}



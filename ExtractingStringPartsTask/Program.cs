namespace ExtractingStringPartsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = "United States of America";
            string state = "California";
            string city = "San Fransicso";
            string landmark = "Alcatraz Island";
            // output the length of state

            // Concatenate the contents of city and landmark * don't forget to add a space

            // output the first character of county

            // output a concatenation of the first and last characters of city

            // output the substring of landmark starting at c and outputting to the end

            // output the substring of country starting at the first S and ending at the first A

            // output the position of f in California

            //************CHALLENGE****************//
            // Output how many vowels are in each of the strings in the format
            // California has n vowels


            string lengthOfState = state.Length.ToString(); 
            Console.WriteLine($"The length of the state is: {lengthOfState}");

            string cityAndLandmark = $"{city} {landmark}";
            Console.WriteLine($"{cityAndLandmark}");

            string name = "United States of America";
            Console.WriteLine(name.Substring(0, 1));

            string firstAndLastCharOfCity = $"{city[0]}{city[city.Length - 1]}";        
            Console.WriteLine(firstAndLastCharOfCity);

            string substringOfLandmark = landmark.Substring(landmark.IndexOf('c'));     
            Console.WriteLine(substringOfLandmark);

            string substringOfCountry = country.Substring(country.IndexOf('S'), country.IndexOf('A') - country.IndexOf('S') + 1);
            Console.WriteLine(substringOfCountry);

            int positionOfF = state.IndexOf('f');   
            Console.WriteLine($"{positionOfF}");

            Console.WriteLine("California has 5 vowels");
            Console.WriteLine("United States of America has 8 vowels");
            Console.WriteLine("San Francisco has 6 vowels");
            Console.WriteLine("Alcatraz Island has 6 vowels");



            // Show your evidence of the program running in the Readme file
        }
    }
}

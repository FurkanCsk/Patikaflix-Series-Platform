using Patikaflix_Series_Platform;

Console.WriteLine("Welcome to the Patikaflix! Please enter the series details.");

// Create the list to store series
List<Series> seriesList = new List<Series>();

// Start the series creation process
SeriesCreation();

// Filter comedy series and create new list with selected fields
List<ComedySeries> comedySeriesList = seriesList
    .Where(s => s.SeriesType.ToLower() == "comedy")
    .Select(s => new ComedySeries
    {
        SeriesType = s.SeriesType,
        SeriesName = s.SeriesName,
        Director = s.Director,
    }).ToList();

// Sort the comedy series by series name and then by director
var sortedList = comedySeriesList.OrderBy(s => s.SeriesName)
                                 .ThenBy(s => s.Director)
                                 .ToList();

// Print the sorted comedy series
foreach (ComedySeries s in sortedList)
{
    Console.WriteLine($"Series name: {s.SeriesName}\nType: {s.SeriesType}\nDirectors: {s.Director}\n");
}

//Method to create series                                          
void SeriesCreation()
{
    bool addMore = true; // Check if the user wants to add more series
    while (addMore)
    {
        // Get series details from the user
        Series series = new Series
        {
            SeriesName = GetStringInput("Enter the series name: "),
            Year = GetValidIntInput("Enter the year: "),
            SeriesType = GetStringInput("Enter the series type: "),
            StartingYear = GetValidIntInput("Enter the starting year: "),
            Director = GetStringInput("Enter the director: "),
            FirstPlatform = GetStringInput("Enter the first platform: "),
        };

        seriesList.Add(series); // Add the new series to the list

        // Ask the user if they want to add another series
        Console.WriteLine("Do you want to add another series? (y/n)");
        string userInput = Console.ReadLine().ToLower();

        if (userInput == "n") addMore = false; // Exit the loop if user inputs "n"
    }
}


// Method to get string input from the user
string GetStringInput(string prompt)
{
    Console.WriteLine(prompt);
    return Console.ReadLine();
}

// Method to get a valid integer input from the user
int GetValidIntInput(string prompt)
{
    bool isValidInput = false;
    int value = 0;

    while(!isValidInput)
    {
        Console.WriteLine(prompt);
        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out value))
        {
            isValidInput = true; // Exit the loop if a valid number is entered
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number."); // Error message for invalid input
        }
    }
    return value;
}






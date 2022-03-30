using NamesGoat;

bool userDone = false;
NameReader reader = new NameReader();

Console.WriteLine("Please enter the range of years you would like to search.");
int[] yearRange = new int[] { Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()) };
reader.ReadYears(yearRange[0], yearRange[1]);

while (!userDone)
{
    Console.WriteLine("Please select an option below");
    Console.WriteLine($"(1) Display Most Popular\n" +
        $"(2) Display Least Popular\n" +
        $"(3) Display Longest Name\n" +
        $"(4) Display Shortest Name\n" +
        $"(5) Display Specific Name\n" +
        $"(0) Quit");

    int userChoice = Convert.ToInt32(Console.ReadLine());
    switch (userChoice)
    {
        case 1: reader.MostPopular();
            break;
        case 2: reader.LeastPopular();
            break;
        case 3: reader.LongestName();
            break;
        case 4: reader.ShortestName();
            break;
        case 5: reader.QueryTest();
            break;
        case 0: userDone = true;
            break;
        default: Console.WriteLine("Invalid Entry.");
            break;
    }
}
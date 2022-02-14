int[] numbers1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
int[] things = new int[] { 1, 2, 3, 4, 5, 6, 7 };

//design the query
var numQuery =
    from num in numbers1
    where (num % 2) == 0
    select num;

//what iterating over that query looks like
foreach (var thing in things)
{
    //so something with thing
}

string[] names = new string[] { "Caleb", "Bobby", "Isaac", "Bri" };
List<int> numbers = new List<int>() { 4, 6, 3, 7, 9, 2, 1, 212 };
numbers.Add(234);
numbers.Add(84);

var ordered =
    from name in names
    where name[0] == 'B'
    where name.Length <= 3
    orderby name descending
    select name;

var orderedNumbers =
    from num in numbers
    where (num % 3) == 0
    orderby num
    select num;

foreach (var name in ordered)
{
    Console.WriteLine(name);
}

foreach (var num in orderedNumbers)
{
    Console.WriteLine(num);
}
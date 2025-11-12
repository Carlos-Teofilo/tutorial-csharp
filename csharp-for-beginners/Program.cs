// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/reference-types


// strings
string greeting = "Hello, Word";

Console.WriteLine(greeting.Contains("Word"));
Console.WriteLine(greeting.Replace("Word", "Carlos"));

string name = "Carlos";

Console.WriteLine(name.ToUpper());
Console.WriteLine(name.ToLower());
Console.WriteLine(name.Length);

Console.WriteLine(greeting.StartsWith("World"));
Console.WriteLine(name.StartsWith("Car"));
Console.WriteLine(name.EndsWith("Car"));


// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/

string jsonString = """
{
  "Date": "2019-08-01T00:00:00-07:00",
  "TemperatureCelsius": 25,
  "Summary": "Hot",
  "DatesAvailable": [
    "2019-08-01T00:00:00-07:00",
    "2019-08-02T00:00:00-07:00"
  ],
  "TemperatureRanges": {
    "Cold": {
      "High": 20,
      "Low": -10
    },
    "Hot": {
      "High": 60,
      "Low": 20
    }
            },
  "SummaryWords": [
    "Cool",
    "Windy",
    "Humid"
  ]
}
""";

Console.WriteLine(jsonString);

var jh = (firstName: "Jupiter", lastName: "Hammon", born: 1711, published: 1761);
Console.WriteLine($"{jh.firstName} {jh.lastName} was an African American poet born in {jh.born}.");
Console.WriteLine($"He was first published in {jh.published} at the age of {jh.published - jh.born}.");
Console.WriteLine($"He'd be over {Math.Round((2018d - jh.born) / 100d) * 100d} years old today.");

//numbers, integers and math
float a = 2.3F;
float b = 2.2F;
int c = (int)(a + b);
float d = 2.9F;

Console.WriteLine(c);
Console.WriteLine((short)d);
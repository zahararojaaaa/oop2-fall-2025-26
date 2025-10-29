Console.Write("Enter temperature in Celsius: ");
string input = Console.ReadLine();
double celsius = Convert.ToDouble(input);

double fahrenheit = (celsius * 9 / 5) + 32;
Console.WriteLine($"{celsius}°C is {fahrenheit}°F");



Console.Clear();

Console.WriteLine("Vad är din Vikt?");
double vikt = double.Parse(Console.ReadLine());
Console.WriteLine("Vad är din längd?");
double längd = double.Parse(Console.ReadLine());

double BMI = vikt / (längd *längd);

Console.WriteLine($"Din BMI är {BMI}");
Console.WriteLine(" Enter the number of large carpets ");
int large = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Enter the number of small carpets  ");
int small = Convert.ToInt32(Console.ReadLine());
double sum = (large * 35 )+ (small * 25);
double tax = sum / 100;
double total = tax * 6 + sum;
Console.WriteLine( total);
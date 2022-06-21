using PartTwo;
Console.WriteLine("Enter the amount of the change without decimal");
int change=Convert.ToInt32(Console.ReadLine());
int i = 0;                          //index for array
Calculate.chang(change, i);         //calling  static function
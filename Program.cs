using PartTwo;
Console.WriteLine("Welcome to the day from date program");
Console.WriteLine("Enter day of the month dd");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the month mm");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the year yyyy");
int y = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[] { 31,28,31,30,31,30,31,31,30,31,30,31};
if(y%400==0||(y%100!=0&&y%4==0))                        //If year is 1600 or the year is 1500 for leap year
{
    arr[1] = 29;
}
if (m >= 1 && m <=12 || y > 0 || d > 0 && d <= arr[m-1])
{
    Util.date(d,m,y);
}
else
{
    Console.WriteLine("Wrong input");

}
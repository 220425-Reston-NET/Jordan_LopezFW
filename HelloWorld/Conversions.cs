public class Conversions
{
    public static void ConversionMain()
    {
  Console.WriteLine("=== Conversion Demo ===");
 int number =10;
 double numberDecimal = 76.3;
 string word = "Hello";

//Explicit Converions
  Console.WriteLine("=Implicit=");
 numberDecimal = number;
  Console.WriteLine(numberDecimal);

Console.WriteLine("=Explicit=");
 
 
 ///Double datatype
 numberDecimal = 76.3;
 number = (int)numberDecimal;
 Console.WriteLine(number);

////More Explicit Conv.
string numberString = number.ToString();
Console.WriteLine(numberString);

/////Converting string into numerical values
string doubleString = "438.1239";
double double2 = Convert.ToDouble(doubleString);
Console.WriteLine(double2/2);







    }
}
using static System.Console;
class FishLengths

{
    static void Main()
    {
        int fishLength1 = 2;
        int fishLength2 = 44;
        int fishLength3 = 27;
        int fishLength4 = 18;
        int fishLength5 = 25;

        double avgFishLength = (fishLength1 + fishLength2 + fishLength3 + fishLength4 + fishLength5) / (double)5;
        string fishLengthString = avgFishLength.ToString("F1");

        WriteLine("The average length of the five fish measured is {0} cm.", fishLengthString);
       
    }
}
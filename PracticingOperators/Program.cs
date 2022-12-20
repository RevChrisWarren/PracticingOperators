﻿class Operators
{
    static void Main()
    {
        double radius = 13;
        double areaOfCircle = (3.14 * radius * radius);
        System.Console.WriteLine(areaOfCircle);

        double feet = 5;
        double inches = 7;
        double EnglishToMetric = (feet * 12 + inches) * 2.54;

        System.Console.WriteLine(EnglishToMetric);

        int num = 15000;
        string nearestThousand = (num > 0 && num <= 100) ? "1000" : (num > 1000 && num <= 2000) ? "2000" : (num > 2000 && num <=3000)? "3000" : "Number out of range";
        System.Console.WriteLine(nearestThousand);

        int seconds = 350000;

        int minutes = seconds / 60;

        int sec = seconds % 60;

        int hours = minutes / 60;
        int min = minutes % 60;

        int days = hours / 24;
        int hr = hours % 24;

        System.Console.WriteLine("Days = " + days + ", hours = " + hr + ", minutes = " + min + ", seconds = " + sec +".");

        System.Console.ReadKey();
    }
}


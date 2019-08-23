using System;

public static class Triangle
{
    public static bool IsScalene(double side1, double side2, double side3)
    {
        if (IsInequalityViolation(side1, side2, side3))
        {
            return side1 != side2 && side1 != side3 && side2 != side3; 
        }

        return false;
    }

    public static bool IsIsosceles(double side1, double side2, double side3) 
    {
        if (IsInequalityViolation(side1, side2, side3))
        {
            return side1 == side2 || side1 == side3 || side2 == side3;
        }

        return false;
    }

    public static bool IsEquilateral(double side1, double side2, double side3)  => side1 == side2 && side1 == side3 && side1 != 0;

    public static bool IsDegenerateTriangle(double side1, double side2, double side3) 
    {
        if (IsInequalityViolation(side1, side2, side3))
        {
           return side1 + side2 == side3 || side1 + side3 == side2 || side2 + side3 == side1;
        }

        return false;
    }
    private static bool IsInequalityViolation(double side1, double side2, double side3) => side1 + side2 >= side3 && side1 + side3 >= side2 && side2 + side3 >= side1;
}
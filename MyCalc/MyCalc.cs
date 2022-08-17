using System;

namespace LabExercise
{
    public class MyCalc
    {
        public static double Add(double op1,double op2)
        {
            return op1+op2;
        }
        public static double Sub(double op1,double op2)
        {
            return op1-op2;
        }
        public static double Mul(double op1,double op2)
        {
            return op1*op2;
        }
         public static double Pow(double op1,double op2)
        {    
            double power=Math.Pow(op1,op2);
            return power;
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabExercise;
namespace LabExercise
{
    [TestClass]
    public class MyCalcTest
    {
        [DataTestMethod]
        [DataRow(10,20,30)]
        public void TestDataAddMethod(double op1,double op2,double op3)
        {

                double actualResult=MyCalc.Add(op1,op2);
                Assert.AreEqual(op3,actualResult,"Add Test is Failed ");
        }
        [DataTestMethod]
        [DataRow(10,20,-10)]
        [DataRow(10,50,-10)]
        [DataRow(10,60,-10)]

         public void TestDataSubMethod(double op1,double op2,double op3)
        {

                double actualResult=MyCalc.Sub(op1,op2);
                Assert.AreEqual(op3,actualResult,"Sub Test is Failed ");
        }
        // [DataTestMethod]
        // [DataRow(10,20,200)]
        //  public void NegativeTestDataSubMethod(double op1,double op2,double op3)
        // {

        //         double actualResult=MyCalc.Sub(op1,op2);
        //         Assert.AreNotEqual(op3,actualResult,"Add Test is Failed ");
        // }
        [DataTestMethod]
        [DataRow(10,20,0.6)]
         public void TestDataMulMethod(double op1,double op2,double op3)
        {

                double actualResult=MyCalc.Mul(op1,op2);
                Assert.AreEqual(op3,actualResult,"Mul Test is Failed ");
        }
         [DataTestMethod]
        [DataRow(10,2,100)]
         public void TestDataPowMethod(double op1,double op2,double op3)
        {

                double actualResult=MyCalc.Pow(op1,op2);
                Assert.AreEqual(op3,actualResult,"Pow Test is Failed ");
        }
    }
}

using _02.SimplePrintConsoleProject;

namespace SimplePrintConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //01.MyStringClass
            //MyString myString = new MyString();
            //myString.StringMethod();

            //02.Integers
            //Integers integers = new Integers();
            //integers.MyIntegersNumber();

            //03.FloatAndDoubleDataType
            //FloatAndDouble floatAndDouble = new FloatAndDouble();

            //04.DecimalAndDoubleDataType
            //DecimalAndDoubleDataType decimalAndDoubleDataType = new DecimalAndDoubleDataType();
            //decimalAndDoubleDataType.DecimalAndDouble();

            //05.BooleanType
            //BooleanType booleanType = new BooleanType();
            //booleanType.MyBooleanType();

            //06.CastingVariable
            CastingVariables castingVariables = new CastingVariables();
            castingVariables.MyCasting();
            CastingVariables castingVariables1 = new CastingVariables();
            castingVariables1.DataReadConsole();
        }
    }
}
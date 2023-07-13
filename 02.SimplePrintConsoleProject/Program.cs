using _02.SimplePrintConsoleProject;
using _02.SimplePrintConsoleProject.Classes;
using System;

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
            //CastingVariables castingVariables = new CastingVariables();
            //castingVariables.MyCasting();
            //CastingVariables castingVariables1 = new CastingVariables();
            //castingVariables1.DataReadConsole();

            //07.Feature
            //FirstFeature firstFeature = new FirstFeature();
            //Console.Write("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //firstFeature.Feature(age);

            //08.CharType
            //CharType charType = new CharType();
            //charType.MyChar();

            //ifStatements ifStatements = new ifStatements();
            //ifStatements.MyIfMethods();

            //ArrayClass myClass = new ArrayClass();
            //myClass.MyArrayMethod();

            
            Animal bird = new Bird(name:"sam",age:3);
            Animal cat = new Pets(name:"kescha", age:2);

          
            Console.WriteLine(bird.Name);
            Console.WriteLine(cat.Name);
        }
    }
}
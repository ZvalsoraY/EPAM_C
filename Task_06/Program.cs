using System;

namespace Task_06
{
    interface IConvertible
    {
        string ConvertToVB(string input);
        string ConvertToCSharp(string input);
    }

    interface ICodeChecker
    {
        bool CheckCodeSyntax(string input, string language);
    }

    class Program
    {
        static void Main()
        {
            ProgramConverter test1 = new ProgramConverter();
            //ProgramConverter test2 = new ProgramConverter();
            ProgramHelper test2 = new ProgramHelper();
            IConvertible test1pc = test1;
            IConvertible test2pc = test2;
            var rezTest1ConvertToCSharp = test1pc.ConvertToCSharp("test1 ConvertToCSharp");
            var rezTest1ConvertToVB = test1pc.ConvertToVB("test1 ConvertToVB");
            //var rezTest2 = test1pc.
            Console.WriteLine(rezTest1ConvertToCSharp);
            Console.WriteLine(rezTest1ConvertToVB);
            //Console.WriteLine(test2pc.);


        }
    }
}

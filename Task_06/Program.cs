using System;
using System.Collections.Generic;

namespace Task_06
{
    //interface IConvertible
    //{
    //    string ConvertToVB(string input);
    //    string ConvertToCSharp(string input);
    //}

    //interface ICodeChecker
    //{
    //    bool CheckCodeSyntax(string input, string language);
    //}
    class Program
    {
        static void Main()
        {
            var test1 = new ProgramConverter();
            var test2 = new ProgramHelper();

            var objArray = new List<ProgramConverter>()
            {
                new ProgramConverter(),
                new ProgramConverter(),
                new ProgramHelper(),
                new ProgramHelper()
            }.ToArray();

            foreach (var obj in objArray)
            {
                if (obj is ICodeChecker cc)
                {
                    var gg = cc.CheckCodeSyntax("", "");
                    Console.WriteLine(gg);
                }
                if (obj is IConvertible hh)
                {
                    var ctCs = hh.ConvertToCSharp("CtCS");
                    var ctVb = hh.ConvertToVB("CtVB");
                    Console.WriteLine(ctCs);
                    Console.WriteLine(ctVb);
                }
            }
        }
    }
    //class Program
    //{
    //    static void Main()
    //    {
    //        ProgramConverter test1 = new ProgramConverter();
    //        //ProgramConverter test2 = new ProgramConverter();
    //        ProgramConverter test2 = new ProgramHelper();
    //        IConvertible test1pc = test1;
    //        ICodeChecker test1cc = test1;
    //        ICodeChecker test2cc = test2;
    //        //IConvertible test2pc = test2;
    //        var rezTest1ConvertToCSharp = test1pc.ConvertToCSharp("test1 ConvertToCSharp");
    //        var rezTest1ConvertToVB = test1pc.ConvertToVB("test1 ConvertToVB");
    //        var rezTest2 = test2cc.CheckCodeSyntax("test2","C#");

    //        Console.WriteLine(rezTest1ConvertToCSharp);
    //        Console.WriteLine(rezTest1ConvertToVB);
    //        Console.WriteLine(rezTest2);


    //    }
    //}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Task_06
{

    class ProgramHelper : ProgramConverter, ICodeChecker
    {
        //string IConvertible.ConvertToCSharp(string input)
        //{
        //    return input + "ConvertToCSharp";
        //}
        //string IConvertible.ConvertToVB(string input)
        //{
        //    return input + "ConvertToVB";
        //}
        bool ICodeChecker.CheckCodeSyntax(string input, string language)
        {
            return true;
        }
    }
}

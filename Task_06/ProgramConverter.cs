using System;
using System.Collections.Generic;
using System.Text;

namespace Task_06
{
    class ProgramConverter : IConvertible
    {
        string IConvertible.ConvertToCSharp(string input)
        {
            return input + "ConvertToCSharp";
        }
        string IConvertible.ConvertToVB(string input)
        {
            return input + "ConvertToVB";
        }
    }
}

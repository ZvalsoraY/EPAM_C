using System;
using System.Collections.Generic;
using System.Text;

namespace Task_06
{
    interface ICodeChecker
    {
        bool CheckCodeSyntax(string input, string language);
    }
}

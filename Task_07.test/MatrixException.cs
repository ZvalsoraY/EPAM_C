using System;
using System.Collections.Generic;
using System.Text;

namespace Task_07.test
{
    [Serializable]
    public class MatrixException : Exception
    public string UserNotFoundName
    {
    get
    {
        return _userNotFoundName;
    }
    set
    {
        _userNotFoundName = value;
    }
    }
    {
        public MatrixExceptionNotFoundException()
        {
        }

        //public MatrixExceptionNotFoundException(string message)
        //    : base(message)
        //{
        //}

        public MatrixExceptionNotFoundException(long RowsCount, Exception inner)
            : base(String.Format("Invalid Student Name: {0}", RowsCount)
        {
            //return null;
        }
        //public InvalidStudentNameException()
        //{

        //}

        //public InvalidStudentNameException(string name)
        //    : base(String.Format("Invalid Student Name: {0}", name))
        //{

        //}

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Task_07
{
    //class MatrixException
    //{
    //}
//    •	Объявить и применить свой тип исключения:
//o В сообщении исключения должна быть информация о размерах матриц.
//o   Также размеры матриц должны быть в полях исключения.
//o Нужно создать разные виды конструкторов по примеру базового исключения System.Exception


  [Serializable]
    public class MatrixException : ArgumentException
    {
        public long RowInfoMatrix1 { get; }
        public long ColumnInfoMatrix1 { get; }
        public long RowInfoMatrix2 { get; }
        public long ColumnInfoMatrix2 { get; }
        //public int Value { get; }
        public MatrixException(string message, long rowInfoMatrix1, long columnInfoMatrix1, long rowInfoMatrix2, long columnInfoMatrix2)
            : base(message)
        {
            RowInfoMatrix1 = rowInfoMatrix1;
            ColumnInfoMatrix1 = columnInfoMatrix1;
            RowInfoMatrix2 = rowInfoMatrix2;
            ColumnInfoMatrix2 = columnInfoMatrix2;
        }

        //private string _userNotFoundName;
        //public string MatrixInfo
        //{
        //    get
        //    {
        //        return _userNotFoundName;
        //    }
        //    set
        //    {
        //        _userNotFoundName = value;
        //    }
        //}

        //public MatrixException() { }

        //public MatrixException(string message) : base(message) { }

        //public MatrixException(string message, Exception inner) : base(message, inner) { }

        //protected MatrixException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}

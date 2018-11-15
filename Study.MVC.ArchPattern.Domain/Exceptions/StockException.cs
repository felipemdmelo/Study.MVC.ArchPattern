using System;
using System.Collections.Generic;

namespace Study.MVC.ArchPattern.Domain.Exceptions
{
    public abstract class StockException : Exception
    {
        public StockException(string msg) : base(msg) { }

        public class InsertException : StockException
        {
            public List<string> Errors { get; set; }
            public InsertException(string msg, List<string> errors) : base(msg)
            {
                Errors = errors;
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace Study.MVC.ArchPattern.Domain.Exceptions
{
    public abstract class ProductException : Exception
    {
        public ProductException(string msg) : base(msg) { }

        public class InsertException : ProductException
        {
            public List<string> Errors { get; set; }
            public InsertException(string msg, List<string> errors) : base(msg)
            {
                Errors = errors;
            }
        }
    }
}

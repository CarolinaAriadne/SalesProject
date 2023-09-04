

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesProject.Models;




namespace SalesProject.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {

        public IntegrityException(string message) : base(message)
        {

        }

    }
}

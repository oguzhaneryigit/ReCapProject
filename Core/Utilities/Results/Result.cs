using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success,string message):this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
        //sadece get buluınduran bir Property read onlydir (sadece okunur değer atanamaz)
        //fakat constructor içinde değer atanabilir
        public bool Success { get; }

        public string Message { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Concrete
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message)
        {
        }
        public SuccessResult() : base(true)
        {

        }
    }

    //Mesaj varsa üsteki ve alttaki , sadece success gönderilecekse sadece alttaki base çalışır.
}

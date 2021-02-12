using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Concrete
{
    public class Result : IResult
    {

        public Result(bool success,string message): this(success) //this success diyerek alttaki constructor da tetikleniyor.
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }

        public string Message { get; }
    }
    //Constructor vasıtası ile Success ve Message set edildi.
    //Read only sadece okuma modunda olan alanlar bile constructor ile set edilebilir
    //Mesaj göndermek istersen , 2 parametre gönderdiğinde 2 constructor da çalışır.
    //Eğer sadece success gönderirsen sadece success olan constructor çalışır.
}

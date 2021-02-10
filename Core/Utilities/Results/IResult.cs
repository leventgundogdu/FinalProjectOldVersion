using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel void'ler icin baslangic
    //Islem sonucu ve bilgilendirme mesaji olacak.
    public interface IResult
    {
        bool Success { get; }  //get okumak icin kullanilir.
        string Message { get; } //Property, bilgi mesaji icin kullanilacak.

    }
}

using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //static olunca sabit yani new'lenmeye gerek duymayan bir forma burunur.
        public static string ProductAdded = "Urun eklendi";
        public static string ProductNameInvalid = "Urun ismi gecersiz";
        internal static string MaintenanceTime = "Sistem bakimda";
        internal static string ProductsListed = "Urunler listelendi";
        //private olan degiskenler kucuk yazilir, public olanlar Pascal Case yazilir.

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Constants
{
    public static class Messages
    {

        //Static olmasının sebebi sürekli yeni nesne olarak çalıştırmanın boşa zahmet olacağından dolaylı. 
        public static string Added = "Eklendi";
        public static string Deleted = "Silindi";
        public static string Updated = "Güncellendi";
        public static string Listed = "Listelendi";
        public static string toMuchPhoto = "5 Adetten fazla fotoğraf ekleyemezsiniz.";
        public static string eror = "Hata";
    }
}

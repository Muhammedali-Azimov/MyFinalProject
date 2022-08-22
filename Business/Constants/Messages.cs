using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Urun Eklendi";
        public static string ProductNameInvalid = "Urun Ismi gecersiz";
        public static string MaintenanceTime = "Yanlis zaman";
        public static string ProductsListed = "Listelendi";
        public static string CategoryLimitError = "Bu kategoruyada 10 dan cox mehsul ola bilmez";
        public static string ProductNameExist = "Bu adda mehsul movcuddur";
        public static string CategoryLimitPassed = "Kateqoriya Limiti Asildi";
        public static string AuthorizationDenied = "Icaze Yoxdur";
    }
}

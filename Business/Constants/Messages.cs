using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "*product name is invalid.*";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";

        public static string ProductCountOfCategoryError = "10'dan fazla ürün eklenemez";
        public static string ProductNameAlreadyExists= "aynı isimde ürün eklenemez";
        public static string CategoryLimitExceded = " mevcur kategori sayısı 15'i geçtiy sisteme yeni ürün eklenemez";
        public static string AuthorizationDenied="yetkiniz yok!";
        public static string NameInvalid="name is not invalid";
    }
}

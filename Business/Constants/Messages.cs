using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "+Product Added.+";
        public static string ProductNameInvalid = "*product name is invalid.*";
        public static string MaintenanceTime = "system is under maintenance";
        public static string ProductsListed = "products listed";

        public static string ProductCountOfCategoryError = "10'dan fazla ürün eklenemez";
        public static string ProductNameAlreadyExists= "aynı isimde ürün eklenemez";
        public static string CategoryLimitExceded = " mevcur kategori sayısı 15'i geçtiy sisteme yeni ürün eklenemez";
    }
}

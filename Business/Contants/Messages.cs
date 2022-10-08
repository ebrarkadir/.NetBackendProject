using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Contants
{
    public class Messages
    {
        public static string MaintenanceTime = "Sistem bakımda";

        public static string BrandAdded = "Marka eklendi.";
        public static string BrandsListed = "Markalar listelendi.";
        public static string BrandUpdated = "Marka güncellendi.";
        public static string BrandDeleted = "Marka silindi.";
        public static string BrandNameInvalid = "Marka adı en az 2 karakter olmalı.";

        public static string CarAdded = "Araba eklendi.";
        public static string CarsListed = "Arabalar listelendi.";
        public static string CarUpdated = "Araba güncellendi.";
        public static string CarDeleted = "Araba silindi.";
        public static string CarNameOrDailyPriceInvalid = "Araba adı 2 karakterden fazla ve günlük fiyat 0'dan büyük olmalı.";

        public static string ColorAdded = "Renk eklendi.";
        public static string ColorsListed = "Renkler listelendi.";
        public static string ColorUpdated = "Renk güncellendi.";
        public static string ColorDeleted = "Renk silindi.";

        public static string UserNameInvalid = "Kullanıcı ismi geçersiz";
        public static string UserAdded = "Kullanıcı başarıyla eklendi";
        public static string CustomerAdded = "Müşteri başarıyla eklendi";
        public static string RentalAdded = "Kiralama kaydı başarıyla eklendi";
        public static string InvalidRental = " Kiralanacak araba müsait değil";
        public static string RentalDeleted = "Araç silindi";
        public static string RentalUpdated = "Araç güncellendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
    }
}

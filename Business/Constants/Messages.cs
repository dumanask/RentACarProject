using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        
        public static string CarsListed = "Arabalar listelendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";

        public static string UserAdded = "User eklendi";
        public static string UserDeleted = "User silindi";
        public static string UserUpdated = "User güncellendi";

        public static string CustomerAdded = "Customer eklendi";
        public static string CustomerDeleted = "Customer silindi";
        public static string CustomerUpdated = "Customer güncellendi";

        public static string BrandAdded = "Brand eklendi";
        public static string BrandDeleted = "Brand silindi";
        public static string BrandUpdated = "Brand güncellendi";

        public static string ColorAdded = "Color eklendi";
        public static string ColorDeleted = "Color silindi";
        public static string ColorUpdated = "Color güncellendi";

        public static string RentAdded = "Kiralama eklendi";
        public static string RentDeleted = "Kiralama silindi";
        public static string RentUpdated = "Kiralama güncellendi";
        public static string RentListed = "Kiralanan Araçlar Listelendi";
        public static string RentSuccess = "Kiralama Başarılı";
        public static string RentInvalid = "Kiralama Geçersiz";

        public static string MaintenanceTime = "Sistem bakımda";

        public static string CarImageAdded = "Araba resmi eklendi";
        public static string CarImageDeleted = "Araba resmi silindi";
        public static string CarImageUpdated = "Araba resmi güncellendi";
        public static string ImageCountForCarPassed = "Araba sayısı 5 i geçmemeli";

        public static string AuthorizationDenied = "Erişim Reddedildi";

        public static string UserRegistered = "Kayıt olundu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola Hatalı";
        public static string SuccessfulLogin = "Başarıyla Giriş Yapıldı";
        public static string AccessTokenCreated = "Giriş izni verildi";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
    }
}

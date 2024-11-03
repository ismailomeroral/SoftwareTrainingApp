using SoftwareTrainingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTrainingApplication.ViewModels
{
    internal class SubjectController
    {
        private static List<Subject> subjects = new List<Subject>
        {
            new Subject{name ="Programlama",type = "info"},
            new Subject{name ="Algoritma",type = "info"},
            new Subject{name ="C#",type = "info"},
            new Subject{name ="IDE",type = "info"},
            new Subject{name ="Nasıl Kod yazabilirim",type = "info"},
            new Subject{name ="Kod yapısı",type = "info"},

            new Subject{name ="Değişkenler",type = "code"},
            new Subject{name ="Değişkenler - int",type = "code"},
            new Subject{name ="Değişkenler - string",type = "code"},
            new Subject{name ="Değişkenler - bool",type = "code"},
            new Subject{name ="Değişkenler - char",type = "code"},
            new Subject{name ="Değişkenler - float",type = "code"},
            new Subject{name ="Değişkenler - double",type = "code"},
            new Subject{name ="Değişkenler - decimal",type = "code"},
            new Subject{name ="Değişkenler - var",type = "code"},

            new Subject{name ="Diziler",type = "code"},

            new Subject{name ="Operatörler",type = "code"},
            new Subject{name ="Operatörler - Aritmatik",type = "code"},
            new Subject{name ="Operatörler - Karşılaştırma",type = "code"},
            new Subject{name ="Operatörler - Mantıksal",type = "code"},
            new Subject{name ="Operatörler - Atama",type = "code"},
            new Subject{name ="Operatörler - Artırım/Azaltım",type = "code"},

            new Subject{name ="Koşul Yapıları",type = "code"},
            new Subject{name ="if, else, else if",type = "code"},
            new Subject{name ="switch case",type = "code"},

            new Subject{name ="Döngüler",type = "code"},
            new Subject{name ="For",type = "code"},
            new Subject{name ="While",type = "code"},
            new Subject{name ="do...while",type = "code"},
            new Subject{name ="foreach",type = "code"},

            new Subject{name ="Console Girdi/Çıktı",type = "code"},

            new Subject{name ="Hata Ayıklama",type = "code"},
            new Subject{name ="try catch",type = "code"},

            new Subject{name ="Sınıflar ve Nesneler",type = "code"},
            new Subject{name ="Metotlar",type = "code"},
            new Subject{name ="(OOP) Nesne Yönelimli Programlama",type = "code"},
            new Subject{name ="(OOP) Inheritance",type = "code"},
            new Subject{name ="(OOP) Polymorphism",type = "code"},
            new Subject{name ="(OOP) Encapsulation",type = "code"},
            new Subject{name ="(OOP) Abstraction",type = "code"},

            new Subject{name ="Koleksiyonlar",type = "code"},
            new Subject{name ="Listeler",type = "code"},
            new Subject{name ="Dictionary",type = "code"},
            new Subject{name ="HashSet",type = "code"},
            new Subject{name ="Stack",type = "code"},
            new Subject{name ="ArrayList",type = "code"},
            new Subject{name ="Queue",type = "code"},

            new Subject{name ="Kütüphaneler",type = "code"},

        };

        public static List<Subject> ToList()
        {
            return subjects;
        }
        public static List<Subject> ToListByType(string _type)
        {
            return subjects.Where(b => b.type == _type).ToList();
        }


    }
}

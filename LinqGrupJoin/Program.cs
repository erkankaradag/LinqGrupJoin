using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqGrupJoin
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Öğrenciler Listesi
            List<Student> students = new List<Student>()
            {
                new Student {StudentId = 1, StudentName = "Ali", ClassId = 1},
                new Student {StudentId = 2, StudentName = "Ayşe", ClassId = 2},
                new Student {StudentId = 3, StudentName = "Mehmet", ClassId = 1},
                new Student {StudentId = 4, StudentName = "Fatma", ClassId = 3},
                new Student {StudentId = 5, StudentName = "Ahmet", ClassId = 2},
            };


            // Sınıflar Listesi
            List<Class> classes = new List<Class>()
            {
                new Class {ClassId = 1, ClassName = "Matematik"},
                new Class {ClassId = 2, ClassName = "Türkçe"},
                new Class {ClassId = 3, ClassName = "Kimya"}
            };

            // GroupJoin ile sınıflara ait öğrencileri listeleme
            var result = classes.GroupJoin(
                students,
                cls => cls.ClassId,        // Sınıfların eşleşme anahtarı
                stu => stu.ClassId,        // Öğrencilerin eşleşme anahtarı
                (cls, studentGroup) => new // Sonuç olarak bir anonim nesne döndür
                {
                    ClassName = cls.ClassName,
                    Students = studentGroup.Select(s => s.StudentName)
                });

            // Sonuçları ekrana yazdırma
            foreach (var item in result)
            {
                Console.WriteLine($"{item.ClassName}: {string.Join(", ", item.Students)}");
            }

        }
    }
}

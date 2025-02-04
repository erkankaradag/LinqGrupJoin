# LINQ GroupJoin Kullanımı

Bu proje, **C# ve LINQ** kullanarak **GroupJoin** işlemi ile **sınıflar ve öğrenciler arasındaki ilişkiyi** göstermektedir.

## 📌 Proje Açıklaması
Bu uygulama:
- **Sınıflar (Class)** ve **Öğrenciler (Student)** listelerini oluşturur.
- **GroupJoin** kullanarak her sınıfa ait öğrencileri gruplayarak ilişkilendirir.
- Sonuçları konsola yazdırır.

---

## 🛠 Kullanılan Teknolojiler
- **C# (.NET Framework/.NET Core)**
- **LINQ (Language Integrated Query)**
- **Konsol Uygulaması**

---

## 📜 Kod Açıklaması

### **1️⃣ Öğrenci ve Sınıf Modelleri**
```csharp
// Öğrenci Sınıfı
class Student
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public int ClassId { get; set; }
}

// Sınıf Sınıfı
class Class
{
    public int ClassId { get; set; }
    public string ClassName { get; set; }
}
```

### **2️⃣ LINQ GroupJoin Kullanımı**
```csharp
var result = classes.GroupJoin(
    students,
    cls => cls.ClassId,        // Sınıf Id'sine göre eşleştirme
    stu => stu.ClassId,        // Öğrenci Id'sine göre eşleştirme
    (cls, studentGroup) => new // Sonuç nesnesi oluşturma
    {
        ClassName = cls.ClassName,
        Students = studentGroup.Select(s => s.StudentName)
    });
```

### **3️⃣ Sonuçların Konsola Yazdırılması**
```csharp
foreach (var item in result)
{
    Console.WriteLine($"{item.ClassName}: {string.Join(", ", item.Students)}");
}
```

---

## ✅ Beklenen Çıktı
```
Matematik: Ali, Mehmet
Türkçe: Ayşe, Ahmet
Kimya: Fatma
```
Bu çıktı, her sınıfa ait öğrencilerin **gruplandığını** ve doğru şekilde eşleştirildiğini gösterir. 🏆

---

## 🚀 Nasıl Kullanılır?
1. Projeyi **Visual Studio** veya herhangi bir **C# IDE**'sinde açın.
2. `Program.cs` dosyasını çalıştırın.
3. Konsolda **sınıfların ve öğrencilerin eşleştirildiğini** görün!

---

## 📄 Lisans
Bu proje **MIT Lisansı** ile lisanslanmıştır.


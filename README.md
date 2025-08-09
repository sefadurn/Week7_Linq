# Rastgele Sayılar ve LINQ Uygulaması

Bu proje, C# dilinde **LINQ** kullanarak bir sayı listesi üzerinde çeşitli sorgular yapmayı gösterir.

## 📌 Proje Amacı
- Rastgele sayılar içeren bir liste oluşturmak
- Bu liste üzerinde **filtreleme (`Where`)** ve **dönüştürme (`Select`)** işlemleri yapmak
- Sonuçları konsola yazdırmak

## 🔹 Kullanılan Teknolojiler
- **C#**
- **.NET Console Application**
- **LINQ (Language Integrated Query)**

## 📜 Adım Adım Açıklama

### 1. Rastgele Sayı Listesi Oluşturma
```csharp
Random random = new Random();
List<int> numbers = new List<int>();

for (int i = 0; i < 10; i++)
{
    int rastgeleSayi = random.Next(-30, 50);
    numbers.Add(rastgeleSayi);
}

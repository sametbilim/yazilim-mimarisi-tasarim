# yazilim-mimarisi-ve-tasarim
Yazılım Mimarisi ve Tasarımı Proje Ödevi
## Factory Tasarım Deseni
Factory Method tasarım kalıbı , kalıtımsal ilişkileri olan asıl nesnelerin üretilmesi amacıyla kullanılan patternlerden birisidir. Burada asıl olan bir metottur. Bu metodun üstlendiği iş ise istemcinin ihtiyacı olan asıl ürünlerin üretilmesini sağlamak.
![Image of Class](https://github.com/sametbilim/yazilim-mimarisi-tasarim/blob/master/facade.png)
Banka classı:
```.cs
 class Banka
 {
   public bool KrediyiKullan(Musteri m, decimal talepEdilenMiktar)
   {
     return true;
   }
 }
```
Kredi classı : Kredi Kullanma Durumu sorgular
```.cs
class Kredi
  {
    public bool KrediKullanmaDurumu(Musteri m)
    {
     return true;
    }
 }
```

# Kutuphane Otomasyonu Raporu




### Projenin amacı 

Halk kutuphnelerı ve universite kütüphanelerinin kullanıcılarının günlük hayatlarında kitap aramak istediklerinde veya kitaplar arasında tercih yapmak istediklerinde bilgi alabilecekleri bir uygulamanın olmadığını fark ettim. Bır mobıl uygulama yada web sitesinin bu ihtiyacı karşılayacağını düşündüm. Mobıl ve web için bilgi birikim yoktu bundan dolayı masaüstü bilgilerimi geliştirmek ve bildiklerimi pratik yapmak için bu projeyi yapmaya karar verdim.

Projenin web ve mobilini gelistirmem durumunda daha kullanılabilir ve daha taşınabilir bi proje olur.

Projem üniversitedeki öğrencileri hedef aldı.

### Projenin kazandırdıkları

Projeyi yaparken vısual studıo form elemanlarını kullandım. Mssql veri işlemlerini kullandım. Veri çekme,veri kaydetme,veri güncelleme işlemlerini yaptım. Veri tabanına resimin yolunu kaydettim. Webden veri çektim ve bu verinin anlamlı bir hale gelmesini sağladım. Visual studio setting dosyasını kullandım.

Proje esnasında webden çektiğim verileri nasıl anlamdırıcağım konusunda zorlandım. Htmlagility pack hakkında ayrıntılı araştırma yapmak işimi kolaylaştırdı. Bir programlama dili içinde başka dile ait kodların filtrrelene bileceğini anladım. 

Veri tabanını tam tasarlamadığım için  veri tabanını 2 defa düzenlemem gerekti bu benim zamanımı aldı tasarım kısmının ne kadar anlamlı ne kadar gerekliolduğunu tecrübe ederek öğrendim.

Projenin mobil ve web kısmını da  yazmak isterim.

### Proje tanıtımı 

Projeyi çalıştırdığımızda kullanıcılar ,yöneticiler ve henüz üyeliği olmayanlar için seçim yapılabilecek  bir fom gelir buradan kullanıcı kendi için uygun girişi seçer

### Kullanıcı Giriş Formu 

Kullanıcı girişinde ilk olarak kullanıcı idsını (TC) ve şifresini girer eğer kullanıcı adı doğru değilse kullanıcı idinizi kontrol ediniz uyarısı gelir eğer kullanıcı idisi var kullanıcı şifresi doğru değilse şifrenizi kontrol ediniz uyarısı ekrana gelir.

Aynı zamanda bu formda kullanıcılardan kitap getirme süresini (15 gün )geçenlere otomatik olarak her 5 günde bir mail atılır .

### Kullanıcı Formu 
![Kullanıcı_Formu](Kullanıcı_Formu.png)

Kullanıcı şifre ve id girişini sağladıktan sonra kullanıcı formuna gidilir.Bu formda kullanıcı çıkışı tıkladığında şifre ve ıd kontrol formuna gider. Ana sayfayı tıkladığında yöbetici,kullanıcı ve üye ekleme seçiinin yapıldığı forma gider. Eğer kullanıcı çarpıya basıp çıkarsa kullanıcının uygulmayı kapatıp açtığında tekrar şifre ve id girmesine gerek yoktur. Kullanıcı ıdsı setting dosyasında tutulur.

Kullanıcı formundaki Eser türü ve kategoriler menu strip itemın elemanlarıdır. Bu öğelerin dropdown elemanları mssqlden dinamik olarak gelir. Dropdown elemanları tıklandığında o tür veya kategoriye ait kitaplar datagridwievda gösterilir. Gelen kitaplardan kullanıcı seçtiği kitapları favorilere ve okunacak listesine ekleyebilir. 

Yazarlar kısmında kullanıcı arastırmak istediği yazarın adını textboxsa yazıp aratabilir. Burada textboxsa yazılan veri Vikipediada aratılır ve gelen veriler düzenlenip text halıne geldikten sonra kullanıcının görebileceği forma dönüştürülür. Eğer aratılan yazarın kitapları varsa yazarın kitap sayısını görebiliriz. Eğer aratılan yazarın kitapları varsa yazarın kitap sayısının altındaki buton yardımıyla o yazara ait kitapların hangileri olduğunu datagridwievda görebiliriz.Eğer aranan yazar vikipedyada yoksa kullanıcı bole bir yazar bulunamadı uyarısı alır.

Çantamdakiler bölümünden eser türü ve kategoriler kısmında okunacak kitaplar ve favori kitaplar kısmına eklediğimiz kıtapları görebiliriz.

Eser arama bölümünde eserin yayınevi, eserin yazarı, eser ismi kriterlerine göre aratabiliriz.Aratma işlemi mssql ile yapılır.

Ayarlar kısmında uygulamaya aıt arka plan rengi ve yazı tipini değiştirebiliriz ve bu değişiklik uygulama kapanıp açılsada devam eder. Bunu setting dosyası kullanarak yaptım.ayarlarda bilgilerimi güncelle kısmında kişi kendi bilgilerini databaseden güncelleye bilir. Bu güncellemelr yapılırken kullanıcıın girdiği telefon ve mail adresi kontrol edilir ve mail tipine uygun mu telefon tipine uygun mu diye eğer değilse kullanıcıya uyarı mesajı iletilir ve doğru değerler girmesi istenir.

### Yönetici Giriş Formu
Yönetici girişinde ilk olarak kullanıcı idsını (TC) ve şifresini girer eğer yönetici adı doğru değilse yönetici idinizi kontrol ediniz uyarısı gelir eğer yönetici idisi var yönetici şifresi doğru değilse şifrenizi kontrol ediniz uyarısı ekrana gelir.

### Yönetici Formu 
![Yönetici_Formu](Yönetici_Formu.png)

Eser kaydetmede kullancıların görebileceği kitapları database eklenir. Burda kitabın yazarı, kitabın ismi,kitabın yayınevi, kitabın yayın yılı , kitabın kategorisi , kitabın türünü yöneticinin girmesini bekleriz. Yöbetici eğer isterse kitaba resim de ekleye bilir. Bu ğzellikler kitapların tutulduğu tabloda kayıt edilir ve kitaba bir ıd verilir bu ıd kayıt islenminin sonunda yöneticiye gösterilir ve yöneticinin bu idyi kitabın üstüne yazması beklernir.

Kitap verme ve alma bölümünde yönetici kullanıcılara kitap alıp verme işlemini yapar. Kullanıcı idsi yazılan yere(TC) girilmesi beklernir eğer girilen sayı databese kayıtlı bir kullanıcı değilse butonlar ve kullanıcı idsini girmesi mümkün olmaz. Kitap ıdsı de girilince eğer kitap ekleme kısmında kitabın fotoğrafı eklendiyse kitabın fotoğrafı gösterilir, eklenmediyse kitabın ismi çıkar, bu ıd bu kitaba ait mi diye kontrol etmemiz için. Şuan yöneticinin kitabı alma vea verme işlemi yapması beklenir bu durumda eğer kitap kullanıcılara verilmiş şuan yoksa kütüphanede yöneticiye uyarı mesajı verir. Kitap verildiğinde kütüpanedeki o ıdıdeki kitap sayısı 1 azalır. Kitap alma durumunda ise kitap sayısı 1 artar.

Kullanıcı bilgileri bölümünde kullanıcı idsi girildiğinde kulanıcının telefon ve mail bilgilerini güncelleye biliriz. Burda da telefon numarası ve mail adresi kontrol edilir.

Kitabı zamanında getirmeyenler kısmında kullanıcılardan 15 günü geçtiği halde kitabı getirmeyenlerin bilgileri kırmızı şekilde ekrana gelir daha 15 günü dolmamış kullanıcıların bilgileri mavidir.

Yeni yönetici ekleme bölümünde çalışmaya yeni başlamış bir yönetici eklememiz sağlar. Bu sırada girilen ıd(TC ) ile önceden kayıt yapıllmış mı diye kontrol eder eğer kayıt işlemi yapıldıysa bu yöneticinin kaydının yapıldığı uyarısı ekraa gelir. Eğer böle bir yönetici yoksa eklenen yöneticinin mail ve telefon bilgileri kontrol edilir ve şifreler arasındaki tutarlılık kontrol edilir eğer sşfre bölümü ve şifre tekrarı bölümüne girilen şifreler aynı değilse ekrana uyarı mesajı gelir.

### Üye Formu  
![Uye_Ol_Formu](Uye_Ol_Formu.png)

Bu formda kullanıcılar eğer üye değilse burdan üye olurlar. Id (TC) kontrolu yapılır TC formatını sağlamayn ifadeler uyarı verir. Mail adresi mail formatında mı dşye kontroledilir mail formatında olmayan ifadeler uyarı mesajı verir. Telefon numarası telefon numarası mı dşye kontrol edilir formatı sağlamayan ifadeler uyarı mesajı verirler. Şifre ile şifre tekrarı uyuşmassa uyarı mesajı verir.

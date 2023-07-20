### Selamlar:wave:, bu proje Siliconmade Academy'nin "Full-Stack Development" aşamasının bitirme projesidir. Proje bir "İlan Sistemi" projesidir ve 7 kişilik bir ekip ile Siliconmade'in verdiği taskler doğrultusunda geliştirilmiştir.

Projemizde içerisinde iki farklı kullanıcı tipi bulunmakta ve kullanıcı tiplerine göre belli özellikler barındırmakta

### 1-Admin/Yönetici Rolü :briefcase:
* :eyes: **Kategori ile ilgili işlemler :** Yönetici **İlan Sistemi** aracılığı ile kategori ekleyebilir, silebilir, düzenleyebilir.
* :man: **Kullanıcı ile ilgili işlemler :** Yönetici **İlan Sistemi** aracılığı ile kullanıcının hesabını silebilir, detaylarını görebilir, kullanıcıyı kalıcı olarak banlayabilir veya dilerse istediği süre boyunca kullanıcının hesabını askıya alabilir. Bu hesapları admin panelinde filtreleyerek (ör: Askıda, banlanmış, aktif) görebilir.
* :page_with_curl: **İlanlar ile ilgili işlemler :** Yönetici **İlan Sistemi** aracılığı ile uygunsuz bulduğu ilanları silebilir, belirli bir kullanıcıya ait ilanları veya belirli bir kategorideki ilanları listeleyebilir.
* :newspaper: **Sayfalar ile ilgili işlemler :**  Yönetici **İlan Sistemi** aracılığı ile **Hakkımızda**, **Hedefimiz** gibi sayfaların içeriğini düzenleyebilir, silebilir veya yeni bir sayfa ekleyebilir.
* :speech_balloon: **Yorum ile ilgili işlemler :** Yönetici **İlan Sistemi** aracılığı ile kullanıcılar tarafından yapılan yorumları görüntüleyebilir, detaylarına erişebilir, silebilir.

  
### 2- Kullanıcı Rolü :bust_in_silhouette:
* :clipboard: **İlan işlemleri :** Kullanıcı **İlan Sistemi** aracılığı ile ürün ilanı verebilir, ilanı düzenleyebilir ve silebilir. Başkalarının ilanlarına yorum yapabilir ve istediği özelliklere göre filtreleyerek aradığı ürüne ulaşabilir.
* :man: **Profil işlemleri :** Kullanıcı **İlan Sistemi** aracılığı ile profil bilgilerini düzenleyebilir, şifresini güncelleyebilir.

## :computer: Projenin Kurulumu
Proje’yi çalıştırmak için Microsoft Sql Server’ın bilgisayarınızda yüklü olması gerekmektedir. Bu kurulumu tamamladıktan sonra veritabanlarımızın yerel sunucumuzda oluşmasını sağlamak için projemizi açıyoruz. Başlangıç projemizi **IlanSistemi.UI** olarak belirledikten sonra package manager console’umuzda varsayılan projemizi **IlanSistemi.DataAccess** olarak belirliyor ve **update-database** komutunu giriyoruz.Bu işlemden sonra veritabanımız yerel sunucumuz içerisinde oluşuyor. Son olarak projeyi çalıştırmak için solution ayarlarından **Startup Project**  olarak **IlanSistemi.UI** seçiyoruz.

#### Admin olarak giriş yapmak için gerekli olan bilgiler:

**Email :** demoadmin@gmail.com
**Şifre :** demoadmin123

![rdeg](https://github.com/furkansenol/p011-ilan-sistemi/assets/129130103/bfdbf969-2e68-4549-9319-1a3819c1f547)

![dvafw](https://github.com/furkansenol/p011-ilan-sistemi/assets/129130103/539a0657-a4f5-4fa8-8a0f-20d37ef351cc)

![assdfa](https://github.com/furkansenol/p011-ilan-sistemi/assets/129130103/7672b012-098a-47d2-8c2c-b6c9f4b55742)

![sdvadfg](https://github.com/furkansenol/p011-ilan-sistemi/assets/129130103/c1a3e082-a3d5-4f6a-8702-efb560539953)

![Ekran_goruntusu_2023-07-19_141855](https://github.com/furkansenol/p011-ilan-sistemi/assets/129130103/30c5fc8b-ed78-45d8-86c1-2abadbe7fa64)

<h2> 🛠 &nbsp;Kullanılan Teknolojiler</h2>


![giphy](https://github.com/furkansenol/p011-ilan-sistemi/assets/129130103/261f4a3f-f6e2-4382-be64-482b12747464)

<table style"float:right;">
  <tr>
    <td><img src="https://img.shields.io/badge/-JavaScript-black?style=flat&logo=javascript"/></td>
    <td><img src="https://img.shields.io/badge/-HTML5-E34F26?style=flat&logo=html5&logoColor=white"></td>
    <td><img src="https://img.shields.io/badge/-Identity-5C2D91?style=flat&logo=.net&logoColor=white"/></td>
  </tr>
  <tr>
    <td><img src="https://img.shields.io/badge/-AutoMapper-5C2D91?style=flat&logo=.net&logoColor=white"/</td>
    <td><img src="https://img.shields.io/badge/-EntityFramework-5C2D91?style=flat&logo=.net&logoColor=white"/></td>
    <td><img src="https://img.shields.io/badge/-ASP.NET-5C2D91?style=flat&logo=.net&logoColor=white"/></td>
  </tr>
  <tr>
    <td><img src="https://img.shields.io/badge/-Github-black?style=flat&logo=github"/></td>
    <td> <img src="https://img.shields.io/badge/-Git-black?style=flat&logo=git"/></td>
  </tr>
  <tr>
    <td><img src="https://img.shields.io/badge/-Bootstrap-563D7C?style=flat&logo=bootstrap"/></td>
 		<td><img src="https://img.shields.io/badge/-CSS3-1572B6?style=flat&logo=css3"/></td>
    <td><img src="https://img.shields.io/badge/-Sql%20Server-CC2927?style=flat-square&logo=microsoft-sql-server&logoColor=ffffff"/></td>
  </tr>
</table>

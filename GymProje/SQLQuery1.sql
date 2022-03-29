create table YeniUye

(UID int not null IDENTITY(1,1) primary key,
isim varchar(150) Not null,
soyisim varchar(150) Not null,
cinsiyet varchar(20) Not null,
DT varchar(100) Not null,
TelefonNo bigint Not null,
Email varchar(150) Not null,
UyelikTarihi varchar(100)Not null,
SporZamanı varchar(120)Not null,
Adres varchar(250)Not null,
Aboneliksuresi varchar(120)Not null,
);

use dbGYM
create table YeniPersonel

(SID int not null IDENTITY(1,1) primary key,
isim varchar(150) Not null,
soyisim varchar(150) Not null,
cinsiyet varchar(20) Not null,
DT varchar(100) Not null,
TelefonNo bigint Not null,
Email varchar(150) Not null,
UyelikTarihi varchar(100)Not null,
Durum varchar(100)Not null,
Sehir varchar(100)Not null,
);

--isim,soyisim,cinsiyet,DogumTarihi,telefon,Email,ÜyelikTarihi,Durum,Sehir

select *from YeniPersonel

select *from YeniUye

create table Ekipman
(EID int not null IDENTITY(1,1) primary key,
EkipmanAdı varchar(250) Not null,
Açıklama varchar(450) Not null,
KullanılanKaslar varchar(250) Not null,
TeslimatTarihi varchar(150) Not null,
Maliyet bigint Not null,
);

--EkipmanAdı,Açıklama,KullanılanKaslar,TeslimatTarihi,Maliyet

select *from Ekipman

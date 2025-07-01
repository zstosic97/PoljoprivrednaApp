

use master;
go
drop database if exists poljoprivrednaaplikacija;
go
create database poljoprivrednaaplikacija collate Croatian_CI_AS;
go

use poljoprivrednaaplikacija

Create table prodavatelji(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
adresasjedista varchar(50) not null,
email varchar(50) not null
);


create table kategorijeproizvoda(
sifra int not null primary key identity(1,1),
nazivkategorije varchar (20)
);

create table proizvodi(
sifra int not null primary key identity(1,1),
nazivproizvoda varchar (30) not null,
kolicina decimal (18,3) not null,
prodavatelj int not null references prodavatelji(sifra),
kategorija int not null references kategorijeproizvoda(sifra)
);


create table kupci(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
adresasjedista varchar(50) not null,
email varchar (50) not null
);

create table narudzbe(
sifra int not null primary key identity(1,1),
datum datetime not null,
kupac int not null references kupci(sifra)
);

create table stavkanarudzbe (
sifra int not null primary key identity(1,1),
kolicina decimal (18,3) not null,
narudzba int not null references narudzbe(sifra),
proizvod int not null references proizvodi(sifra)
);

insert into prodavatelji(naziv, adresasjedista, email)
values 
('OPG Horvat', 'Glavna 12, Osijek', 'horvat@opg.hr'),
('OPG Kovač', 'Poljska 8, Varaždin', 'kovac@opg.hr'),
('OPG Marić', 'Vinogradska 14, Vinkovci', 'maric@opg.hr'),
('OPG Petrović', 'Zagrebačka 20, Slavonski Brod', 'petrovic@opg.hr'),
('OPG Novak', 'Trg Mladosti 3, Karlovac', 'novak@opg.hr'),
('OPG Radić', 'Put Žita 9, Osijek', 'radic@opg.hr'),
('OPG Šarić', 'Lipa 22, Đakovo', 'saric@opg.hr'),
('OPG Grgić', 'Selska 5, Požega', 'grgic@opg.hr'),
('OPG Bašić', 'Poljoprivredna 4, Sisak', 'basic@opg.hr'),
('OPG Vuković', 'Voćarska 11, Bjelovar', 'vukovic@opg.hr');

insert into kategorijeproizvoda(nazivkategorije)
values
('Žitarice'),('uljarice');

insert into proizvodi(nazivproizvoda, kolicina, prodavatelj, kategorija)
values 
('Pšenica', 1500.000, 1, 1),
('Kukuruz', 1200.000, 2, 1),
('Suncokret', 800.000, 3, 2),
('Ječam', 900.000, 4, 1),
('Soja', 700.000, 5, 2),
('Zob', 500.000, 7, 1),
('Uljana repica', 450.000, 8, 2);

INSERT INTO kupci(naziv, adresasjedista, email)
VALUES 
('Podravka d.d.', 'Danica 1, Koprivnica', 'info@podravka.hr'),
('Konzum d.d.', 'Vukovarska 269a, Zagreb', 'narudzbe@konzum.hr'),
('Plodine d.d.', 'Kukuljanovo bb, Rijeka', 'kupovina@plodine.hr'),
('Studenac d.o.o.', 'Zadarska 45, Split', 'prodaja@studenac.hr'),
('Žito d.d.', 'Đakovština 3, Osijek', 'nabava@zito.hr');

INSERT INTO narudzbe(datum, kupac)
VALUES 
('2025-05-27', 1), 
('2025-05-28', 3);

INSERT INTO stavkanarudzbe (kolicina, narudzba, proizvod)
VALUES 
(500.000, 1, 1),
(300.000, 1, 2),
(200.000, 2, 3), 
(150.000, 2, 1);




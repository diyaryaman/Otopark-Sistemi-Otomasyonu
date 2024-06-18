create table Araclar
(
	AracID int identity(1,1) primary key,
	Plaka nvarchar(10) not null,
	MarkaModel nvarchar(50) not null,
	GirisTarihi datetime not null,
	Cikistarihi datetime null, --Baþlangýçta null çünkü araç otoparktan çýkana kadar veri olmaz.
	Durum nvarchar(10) check (Durum in ('Ýçerde', 'Dýþarýda')) not null
)
-- Ýlk kayýt
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34ABC123', 'Toyota Corolla', '2024-05-01 08:00:00', NULL, 'Ýçerde');

-- Ýkinci kayýt
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34DEF456', 'Honda Civic', '2024-05-02 09:00:00', '2024-05-02 17:00:00', 'Dýþarýda');

-- Üçüncü kayýt
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34GHI789', 'Ford Focus', '2024-05-03 10:00:00', NULL, 'Ýçerde');

-- Dördüncü kayýt
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34JKL012', 'Chevrolet Cruze', '2024-05-04 11:00:00', '2024-05-04 18:00:00', 'Dýþarýda');

-- Beþinci kayýt
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34MNO345', 'Volkswagen Golf', '2024-05-05 12:00:00', NULL, 'Ýçerde');

-- Altýncý kayýt
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34PQR678', 'Hyundai Elantra', '2024-05-06 13:00:00', '2024-05-06 19:00:00', 'Dýþarýda');

-- Yedinci kayýt
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34STU901', 'Nissan Sentra', '2024-05-07 14:00:00', NULL, 'Ýçerde');

-- Sekizinci kayýt
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34VWX234', 'Kia Forte', '2024-05-08 15:00:00', '2024-05-08 20:00:00', 'Dýþarýda');

-- Dokuzuncu kayýt
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34YZA567', 'Mazda 3', '2024-05-09 16:00:00', NULL, 'Ýçerde');

-- Onuncu kayýt
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34BCD890', 'Subaru Impreza', '2024-05-10 17:00:00', '2024-05-10 21:00:00', 'Dýþarýda');
select*from Araclar
-- 6. kayýt
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34PQR678', 'Hyundai Elantra', '2024-05-06 13:00:00', '2024-05-06 19:00:00', 'Dýþarýda');

-- 7. kayýt
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34STU901', 'Nissan Sentra', '2024-05-07 14:00:00', NULL, 'Ýçerde');

-- 8. kayýt
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34VWX234', 'Kia Forte', '2024-05-08 15:00:00', '2024-05-08 20:00:00', 'Dýþarýda');

-- 9. kayýt
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34YZA567', 'Mazda 3', '2024-05-09 16:00:00', NULL, 'Ýçerde');

-- 10. kayýt
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34BCD890', 'Subaru Impreza', '2024-05-10 17:00:00', '2024-05-10 21:00:00', 'Dýþarýda');

-- 11. kayýt
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34KLM123', 'Audi A3', '2024-05-11 08:00:00', NULL, 'Ýçerde');

-- 12. kayýt
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34NOP456', 'BMW 320i', '2024-05-12 09:00:00', '2024-05-12 17:00:00', 'Dýþarýda');

-- 13. kayýt
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34QRS789', 'Mercedes C200', '2024-05-13 10:00:00', NULL, 'Ýçerde');

-- 14. kayýt
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34TUV012', 'Peugeot 308', '2024-05-14 11:00:00', '2024-05-14 18:00:00', 'Dýþarýda');

-- 15. kayýt
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34XYZ345', 'Renault Megane', '2024-05-15 12:00:00', NULL, 'Ýçerde');

-- 16. kayýt
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34ABC678', 'Citroen C4', '2024-05-16 13:00:00', '2024-05-16 19:00:00', 'Dýþarýda');

-- 17. kayýt
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34DEF901', 'Volkswagen Passat', '2024-05-17 14:00:00', NULL, 'Ýçerde');

-- 18. kayýt
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34GHI234', 'Skoda Octavia', '2024-05-18 15:00:00', '2024-05-18 20:00:00', 'Dýþarýda');

-- 19. kayýt
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34JKL567', 'Fiat Egea', '2024-05-19 16:00:00', NULL, 'Ýçerde');

-- 20. kayýt
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34MNO890', 'Alfa Romeo Giulia', '2024-05-20 17:00:00', '2024-05-20 21:00:00', 'Dýþarýda');
select *from Araclar
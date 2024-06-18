create table Araclar
(
	AracID int identity(1,1) primary key,
	Plaka nvarchar(10) not null,
	MarkaModel nvarchar(50) not null,
	GirisTarihi datetime not null,
	Cikistarihi datetime null, --Ba�lang��ta null ��nk� ara� otoparktan ��kana kadar veri olmaz.
	Durum nvarchar(10) check (Durum in ('��erde', 'D��ar�da')) not null
)
-- �lk kay�t
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34ABC123', 'Toyota Corolla', '2024-05-01 08:00:00', NULL, '��erde');

-- �kinci kay�t
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34DEF456', 'Honda Civic', '2024-05-02 09:00:00', '2024-05-02 17:00:00', 'D��ar�da');

-- ���nc� kay�t
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34GHI789', 'Ford Focus', '2024-05-03 10:00:00', NULL, '��erde');

-- D�rd�nc� kay�t
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34JKL012', 'Chevrolet Cruze', '2024-05-04 11:00:00', '2024-05-04 18:00:00', 'D��ar�da');

-- Be�inci kay�t
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34MNO345', 'Volkswagen Golf', '2024-05-05 12:00:00', NULL, '��erde');

-- Alt�nc� kay�t
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34PQR678', 'Hyundai Elantra', '2024-05-06 13:00:00', '2024-05-06 19:00:00', 'D��ar�da');

-- Yedinci kay�t
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34STU901', 'Nissan Sentra', '2024-05-07 14:00:00', NULL, '��erde');

-- Sekizinci kay�t
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34VWX234', 'Kia Forte', '2024-05-08 15:00:00', '2024-05-08 20:00:00', 'D��ar�da');

-- Dokuzuncu kay�t
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34YZA567', 'Mazda 3', '2024-05-09 16:00:00', NULL, '��erde');

-- Onuncu kay�t
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34BCD890', 'Subaru Impreza', '2024-05-10 17:00:00', '2024-05-10 21:00:00', 'D��ar�da');
select*from Araclar
-- 6. kay�t
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34PQR678', 'Hyundai Elantra', '2024-05-06 13:00:00', '2024-05-06 19:00:00', 'D��ar�da');

-- 7. kay�t
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34STU901', 'Nissan Sentra', '2024-05-07 14:00:00', NULL, '��erde');

-- 8. kay�t
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34VWX234', 'Kia Forte', '2024-05-08 15:00:00', '2024-05-08 20:00:00', 'D��ar�da');

-- 9. kay�t
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34YZA567', 'Mazda 3', '2024-05-09 16:00:00', NULL, '��erde');

-- 10. kay�t
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34BCD890', 'Subaru Impreza', '2024-05-10 17:00:00', '2024-05-10 21:00:00', 'D��ar�da');

-- 11. kay�t
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34KLM123', 'Audi A3', '2024-05-11 08:00:00', NULL, '��erde');

-- 12. kay�t
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34NOP456', 'BMW 320i', '2024-05-12 09:00:00', '2024-05-12 17:00:00', 'D��ar�da');

-- 13. kay�t
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34QRS789', 'Mercedes C200', '2024-05-13 10:00:00', NULL, '��erde');

-- 14. kay�t
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34TUV012', 'Peugeot 308', '2024-05-14 11:00:00', '2024-05-14 18:00:00', 'D��ar�da');

-- 15. kay�t
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34XYZ345', 'Renault Megane', '2024-05-15 12:00:00', NULL, '��erde');

-- 16. kay�t
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34ABC678', 'Citroen C4', '2024-05-16 13:00:00', '2024-05-16 19:00:00', 'D��ar�da');

-- 17. kay�t
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34DEF901', 'Volkswagen Passat', '2024-05-17 14:00:00', NULL, '��erde');

-- 18. kay�t
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34GHI234', 'Skoda Octavia', '2024-05-18 15:00:00', '2024-05-18 20:00:00', 'D��ar�da');

-- 19. kay�t
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34JKL567', 'Fiat Egea', '2024-05-19 16:00:00', NULL, '��erde');

-- 20. kay�t
INSERT INTO Araclar (Plaka, MarkaModel, GirisTarihi, CikisTarihi, Durum)
VALUES ('34MNO890', 'Alfa Romeo Giulia', '2024-05-20 17:00:00', '2024-05-20 21:00:00', 'D��ar�da');
select *from Araclar
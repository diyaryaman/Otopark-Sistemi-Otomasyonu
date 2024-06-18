# Otopark Sistemi Otomasyonu

 TR

Otopark Araç Takip Sistemi

Bu proje, bir otoparka ait araç takip sistemini yönetmek için geliştirilmiştir.
Sistem, otoparkta bulunan araçların giriş-çıkış işlemlerini yönetmek, mevcut durumu 
göstermek ve istatistiksel veriler sunmak amacıyla tasarlanmıştır.

Özellikler

Ana Veri: Araç

Araç ID

Araç Plakası

Marka ve Model (Yabancı anahtar ile ilişkilendirilmiş)

Giriş Tarihi

Çıkış Tarihi

İçerde Olup Olmama Durumu (İçerde/Dışarıda)


Kullanılan Teknolojiler ve Teknik Detaylar


Programlama Dili: C# (.NET Framework veya .NET Core)

Veritabanı: Microsoft SQL Server

ORM Kütüphanesi: Entity Framework (Code-First yaklaşımıyla veritabanı işlemleri yapılmıştır)

Kullanıcı Arayüzü: Windows Forms veya WPF (Windows Presentation Foundation)


Formlar


Birinci Form: Ana Form
Bu form, otoparkın genel durumunu gösterir ve kayıtların alınacağı/listeleneceği ana formdur.
İçerde Bulunan Araç Sayısı
Boş Park Yeri Sayısı
Araç Başına Ortalama Kalış Süresi
Ortalama Günlük/Kazanç

İkinci Form: Güncelleme Formu
Bu form, kayıtların güncelleneceği ve düzenlenebileceği formdur.

Veritabanı Yapısı
Proje için kullanılan SQL veritabanı yapısı aşağıdaki gibidir:

CREATE DATABASE Otopark;

CREATE TABLE Araclar (

    AracID INT IDENTITY(1,1) PRIMARY KEY,
    
    Plaka NVARCHAR(10) NOT NULL,
    
    MarkaModel NVARCHAR(50) NOT NULL,
    
    GirisTarihi DATETIME NOT NULL,
    
    CikisTarihi DATETIME NULL,
    
    Durum NVARCHAR(10) CHECK (Durum IN ('İçerde', 'Dışarıda')) NOT NULL
    
);



EN

Parking Lot Vehicle Tracking System

This project is developed to manage a vehicle tracking 
system for a parking lot. The system is designed to handle 
entry and exit operations of vehicles, display current status, and provide statistical data.

Features

Main Entity: Vehicle

Vehicle ID

License Plate

Make and Model (Linked with foreign key)

Entry Date

Exit Date

Status (Inside/Outside)

Technologies Used and Technical Details

Programming Language: C# (.NET Framework or .NET Core)

Database: Microsoft SQL Server

ORM Framework: Entity Framework (Code-First approach for database operations)

User Interface: Windows Forms or WPF (Windows Presentation Foundation)

Forms

First Form: Main Form
This form displays the overall status of the parking lot and serves as the main interface for capturing/listing records.
Number of Vehicles Inside
Number of Available Parking Spaces
Average Duration per Vehicle
Average Daily Earnings

Second Form: Update Form
This form allows updating and editing of records.

Database Schema
Below is the SQL database schema used for the project:


CREATE DATABASE Otopark;


CREATE TABLE Araclar 
(

    AracID INT IDENTITY(1,1) PRIMARY KEY,
    
    Plaka NVARCHAR(10) NOT NULL,
    
    MarkaModel NVARCHAR(50) NOT NULL,
    
    GirisTarihi DATETIME NOT NULL,
    
    CikisTarihi DATETIME NULL,
    
    Durum NVARCHAR(10) CHECK (Durum IN ('İçerde', 'Dışarıda')) NOT NULL
    
);

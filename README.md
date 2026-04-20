# 242410102083_Wafiya-Ramadhaning-Tyas
# Sistem Manajemen Klinik Kecantikan

## Deskripsi
Project ini merupakan REST API sederhana untuk mengelola data pada klinik kecantikan. 
API ini bisa digunakan untuk mengelola data pasien, dokter, dan perawatan.

Di dalamnya sudah terdapat fitur CRUD (Create, Read, Update, Delete) serta relasi antar tabel.

---

## Teknologi yang Digunakan
- ASP.NET Core Web API (.NET 8)
- Entity Framework Core
- PostgreSQL
- Swagger (untuk testing API)

---

## Struktur Database
Database terdiri dari 3 tabel utama:

1. **pasien**
   - menyimpan data pasien seperti nama, email, dan nomor HP

2. **dokter**
   - menyimpan data dokter dan spesialisnya

3. **perawatan**
   - menyimpan data perawatan
   - memiliki relasi ke tabel pasien dan dokter

---

## Cara Menjalankan Project

1. Clone repository ini
2. Buka project di Visual Studio
3. Pastikan PostgreSQL sudah aktif
4. Import file `database.sql`
5. Jalankan project (F5)
6. Buka Swagger di browser

---

## Endpoint API

### Perawatan
- GET `/api/perawatan` → ambil semua data
- GET `/api/perawatan/{id}` → detail data
- POST `/api/perawatan` → tambah data
- PUT `/api/perawatan/{id}` → update data
- DELETE `/api/perawatan/{id}` → hapus data

### Pasien
- GET `/api/pasien`
- POST `/api/pasien`

### Dokter
- GET `/api/dokter`
- POST `/api/dokter`

---

## Format Response

### Success
```json
{
  "status": "success",
  "data": {...}
}

{
  "status": "error",
  "message": "Data tidak ditemukan"
}

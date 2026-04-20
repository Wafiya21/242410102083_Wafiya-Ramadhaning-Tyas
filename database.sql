-- =========================
-- DROP TABLE (BIAR AMAN RE-RUN)
-- =========================
DROP TABLE IF EXISTS perawatan;
DROP TABLE IF EXISTS pasien;
DROP TABLE IF EXISTS Dokter;

-- =========================
-- TABEL PASIEN
-- =========================
CREATE TABLE Pasien (
    id SERIAL PRIMARY KEY,
    nama VARCHAR(100) NOT NULL,
    email VARCHAR(100),
    no_hp VARCHAR(15),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    deleted_at TIMESTAMP NULL
);

-- =========================
-- TABEL DOKTER
-- =========================
CREATE TABLE dokter (
    id SERIAL PRIMARY KEY,
    nama VARCHAR(100) NOT NULL,
    spesialis VARCHAR(100),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    deleted_at TIMESTAMP NULL
);

-- =========================
-- TABEL PERAWATAN
-- =========================
CREATE TABLE perawatan (
    id SERIAL PRIMARY KEY,
    pasien_id INT NOT NULL,
    dokter_id INT NOT NULL,
    jenis_perawatan VARCHAR(100),
    harga DECIMAL(10,2),
    tanggal DATE,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    deleted_at TIMESTAMP NULL,
    CONSTRAINT fk_pasien FOREIGN KEY (pasien_id) REFERENCES pasien(id) ON DELETE CASCADE,
    CONSTRAINT fk_dokter FOREIGN KEY (dokter_id) REFERENCES dokter(id) ON DELETE CASCADE
);

-- =========================
-- INDEX (BIAR SESUAI RUBRIK)
-- =========================
CREATE INDEX idx_pasien_nama ON pasien(nama);
CREATE INDEX idx_dokter_nama ON dokter(nama);
CREATE INDEX idx_perawatan_tanggal ON perawatan(tanggal);

-- =========================
-- INSERT DATA PASIEN
-- =========================
INSERT INTO pasien (nama, email, no_hp) VALUES
('Wafiya', 'Wafiya@mail.com', '0811111111'),
('Fiya', 'Fiya@mail.com', '0822222222'),
('Tyas', 'Tyas@mail.com', '0833333333'),
('Miko', 'Miko@mail.com', '0844444444'),
('Miki', 'Miki@mail.com', '0855555555');

-- =========================
-- INSERT DATA DOKTER
-- =========================
INSERT INTO dokter (nama, spesialis) VALUES
('Dr. Miko', 'Kulit'),
('Dr. Wafiya', 'Estetika'),
('Dr. Miki', 'Jerawat'),
('Dr. Tyas', 'Anti Aging'),
('Dr. Fiya', 'Laser');

-- =========================
-- INSERT DATA PERAWATAN
-- =========================
INSERT INTO perawatan (pasien_id, dokter_id, jenis_perawatan, harga, tanggal) VALUES
(1, 1, 'Facial', 150000, '2026-01-01'),
(2, 2, 'Laser', 300000, '2026-01-02'),
(3, 3, 'Acne Treatment', 200000, '2026-01-03'),
(4, 4, 'Botox', 500000, '2026-01-04'),
(5, 5, 'Peeling', 250000, '2026-01-05');

SELECT * FROM perawatan;

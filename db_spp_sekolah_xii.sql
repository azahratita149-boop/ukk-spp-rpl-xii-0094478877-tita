CREATE DATABASE db_spp_sekolah_xii;
use db_spp_sekolah_xii;
CREATE Table spp(
id_spp INT AUTO_INCREMENT,
tahun INT,
nominal int,
keterangan VARCHAR(20),
created_at TIMESTAMP,
update_at TIMESTAMP

);
CREATE TABLE siswa(
    nisn CHAR(10),
    nis CHAR(8),
    nama VARCHAR(50),
    id_kelas INT,
    alamat TEXT,
    no_telp VARCHAR(15),
    id_spp INT,
    created_at TIMESTAMP,
    updated_at TIMESTAMP

);
CREATE Table kelas(
    id_kelas INT AUTO_INCREMENT,
    nama_kelas VARCHAR(15),
    
)

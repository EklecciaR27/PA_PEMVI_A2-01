-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 23 Bulan Mei 2023 pada 15.36
-- Versi server: 10.4.25-MariaDB
-- Versi PHP: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_pa_vb`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `db_akun`
--

CREATE TABLE `db_akun` (
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `status` varchar(100) NOT NULL,
  `fullname` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `db_akun`
--

INSERT INTO `db_akun` (`username`, `password`, `status`, `fullname`) VALUES
('admin', 'admin123', 'Admin', ''),
('ciaaa.rey', '123', 'User', 'Ekleccia'),
('man1', '111', 'Manager', 'DITA LOLONGAN'),
('nopshi', '111', 'Pembeli', 'Ramadhani'),
('Staf2', '111', 'Staff', 'aaaa'),
('t', '1', 'Pembeli', 'Tito Darmawan');

-- --------------------------------------------------------

--
-- Struktur dari tabel `db_barang`
--

CREATE TABLE `db_barang` (
  `idBarang` varchar(10) NOT NULL,
  `namaBarang` varchar(100) NOT NULL,
  `jenisBarang` varchar(100) NOT NULL,
  `asalEnergi` varchar(100) NOT NULL,
  `stokBarang` int(11) NOT NULL,
  `idSupplier` varchar(5) NOT NULL,
  `hargaBarang` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `db_barang`
--

INSERT INTO `db_barang` (`idBarang`, `namaBarang`, `jenisBarang`, `asalEnergi`, `stokBarang`, `idSupplier`, `hargaBarang`) VALUES
('B01', 'PANASONIC HJ', 'Kulkas', 'Listrik', 10, 'SUP02', 4500000),
('B02', 'LG 42 INCH', 'Televisi', 'Listrik', 0, 'SUP01', 3456000),
('B03', 'MITHOCHIBBA BLD', 'BLENDER', 'BATERAI CHARGE', 28, 'SUP01', 376000),
('B04', 'MODERNA MV6', 'Freezer', 'Listrik', 1, 'SUP03', 5400000),
('B05', 'KRISBOW FAN MINI', 'Kipas Angin', 'Baterai', 3, 'SUP04', 110000),
('B06', 'RILBOSS', 'AUDIO SPEAKER', 'BATERAI CHARGE', 5, 'SUP02', 450000),
('B11', 'POPOPA', 'KIPAS ANGIN', 'BATERAI CHARGE', 82, 'SUP08', 100000),
('B12', 'KIPAS WADESTA', 'KIPAS ANGIN', 'BATERAI CHARGE', 12, 'SUP04', 280000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `db_supplier`
--

CREATE TABLE `db_supplier` (
  `idSupplier` varchar(5) NOT NULL,
  `namaSupplier` varchar(100) NOT NULL,
  `cpSupplier` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `db_supplier`
--

INSERT INTO `db_supplier` (`idSupplier`, `namaSupplier`, `cpSupplier`) VALUES
('SUP01', 'AGDITHA EVALYN', '0827482942'),
('SUP02', 'CIA REYD', '08218278981'),
('SUP03', 'NOVIA INDAH', '1232131313'),
('SUP04', 'TITO DARMAWAN', '0822126781'),
('SUP08', 'REFAL HADY', '08080080808');

-- --------------------------------------------------------

--
-- Struktur dari tabel `pembelian`
--

CREATE TABLE `pembelian` (
  `idPembelian` int(200) NOT NULL,
  `idUser` varchar(100) NOT NULL,
  `totalJumlah` int(11) NOT NULL,
  `totalHarga` int(63) NOT NULL,
  `status` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `pembelian`
--

INSERT INTO `pembelian` (`idPembelian`, `idUser`, `totalJumlah`, `totalHarga`, `status`) VALUES
(31, 't', 7, 14124000, 'selesai'),
(32, 't', 5, 1954000, 'diproses'),
(34, 't', 28, 13400000, 'diproses'),
(36, 't', 1, 3456000, 'selesai'),
(40, 't', 1, 450000, 'selesai'),
(41, 'nopshi', 10, 4130000, 'selesai'),
(42, 'ciaaa.rey', 2, 9000000, 'diproses');

-- --------------------------------------------------------

--
-- Struktur dari tabel `pesanan`
--

CREATE TABLE `pesanan` (
  `idPembelian` int(200) NOT NULL,
  `idBarang` varchar(100) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `subTotalHarga` int(63) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `pesanan`
--

INSERT INTO `pesanan` (`idPembelian`, `idBarang`, `jumlah`, `subTotalHarga`) VALUES
(31, 'B02', 4, 13824000),
(31, 'B11', 3, 300000),
(32, 'B03', 4, 1504000),
(32, 'B06', 1, 450000),
(34, 'B04', 2, 10800000),
(34, 'B11', 26, 2600000),
(36, 'B02', 1, 3456000),
(40, 'B06', 1, 450000),
(41, 'B03', 5, 1880000),
(41, 'B06', 5, 2250000),
(42, 'B01', 2, 9000000);

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `db_akun`
--
ALTER TABLE `db_akun`
  ADD PRIMARY KEY (`username`);

--
-- Indeks untuk tabel `db_barang`
--
ALTER TABLE `db_barang`
  ADD PRIMARY KEY (`idBarang`),
  ADD KEY `barang_supplier` (`idSupplier`);

--
-- Indeks untuk tabel `db_supplier`
--
ALTER TABLE `db_supplier`
  ADD PRIMARY KEY (`idSupplier`);

--
-- Indeks untuk tabel `pembelian`
--
ALTER TABLE `pembelian`
  ADD PRIMARY KEY (`idPembelian`),
  ADD KEY `pembelian_user` (`idUser`);

--
-- Indeks untuk tabel `pesanan`
--
ALTER TABLE `pesanan`
  ADD KEY `pesanan_pembelian` (`idPembelian`),
  ADD KEY `pesanan_barang` (`idBarang`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `pembelian`
--
ALTER TABLE `pembelian`
  MODIFY `idPembelian` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=43;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `db_barang`
--
ALTER TABLE `db_barang`
  ADD CONSTRAINT `barang_supplier` FOREIGN KEY (`idSupplier`) REFERENCES `db_supplier` (`idSupplier`) ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `pembelian`
--
ALTER TABLE `pembelian`
  ADD CONSTRAINT `pembelian_user` FOREIGN KEY (`idUser`) REFERENCES `db_akun` (`username`) ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `pesanan`
--
ALTER TABLE `pesanan`
  ADD CONSTRAINT `pesanan_barang` FOREIGN KEY (`idBarang`) REFERENCES `db_barang` (`idBarang`) ON UPDATE CASCADE,
  ADD CONSTRAINT `pesanan_pembelian` FOREIGN KEY (`idPembelian`) REFERENCES `pembelian` (`idPembelian`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

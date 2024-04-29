using System;
using System.Collections.Generic;

namespace PenjualanProduk
{
    class ManajemenProduk
    {
        private List<Produk> daftarProduk;

        public ManajemenProduk()
        {
            daftarProduk = new List<Produk>
            {
                new Produk("P001", "Buku Tulis A", 5000, 100),
                new Produk("P002", "Buku Tulis B", 2000, 150),
                new Produk("P003", "Buku Tulis C", 1000, 200),
                new Produk("P004", "Pensil A", 7000, 120),
                new Produk("P005", "Pensil B", 9000, 180),
                new Produk("P006", "Pensil C", 10000, 220),
                new Produk("P007", "Penghapus A", 5500, 170),
                new Produk("P008", "Penghapus B", 3000, 140),
                new Produk("P009", "Penghapus C", 4000, 250),
            };
        }

        public void CariProduk(string kataKunci, int minHarga, int maxHarga)
        {
            Console.WriteLine("\n=== Hasil Pencarian ===");
            foreach (Produk produk in daftarProduk)
            {
                if (produk.Nama.ToLower().Contains(kataKunci.ToLower()) && produk.Harga >= minHarga && produk.Harga <= maxHarga)
                {
                    Console.WriteLine(produk);
                }
            }
        }

        public void SortirProduk()
        {
            Console.WriteLine("\n=== Produk yang Tersedia (Diurutkan berdasarkan Stok) ===");
            daftarProduk.Sort((x, y) => y.Stok.CompareTo(x.Stok));
            foreach (Produk produk in daftarProduk)
            {
                Console.WriteLine(produk);
            }
        }

        public void TambahProduk(string id, string nama, int harga, int stok)
        {
            Produk produkBaru = new Produk(id, nama, harga, stok);
            daftarProduk.Add(produkBaru);
            Console.WriteLine("Produk berhasil ditambahkan!");
        }

        public void HapusProduk(string id)
        {
            Produk produkDihapus = daftarProduk.Find(p => p.ID == id);
            if (produkDihapus != null)
            {
                daftarProduk.Remove(produkDihapus);
                Console.WriteLine("Produk berhasil dihapus!");
            }
            else
            {
                Console.WriteLine("Produk tidak ditemukan.");
            }
        }
    }
}

using System;

namespace PenjualanProduk
{
    class Produk
    {
        public string ID { get; set; }
        public string Nama { get; set; }
        public int Harga { get; set; }
        public int Stok { get; set; }

        public Produk(string id, string nama, int harga, int stok)
        {
            ID = id;
            Nama = nama;
            Harga = harga;
            Stok = stok;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Nama: {Nama}, Harga: {Harga}, Stok: {Stok}";
        }
    }
}

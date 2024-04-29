using System;

namespace PenjualanProduk
{
    class Program
    {
        static void Main(string[] args)
        {
            ManajemenProduk manajemenProduk = new ManajemenProduk();

            // Login
            Console.WriteLine("=== Selamat datang di RHEVA OLSHOP ===");
            Console.Write("Masukkan username: ");
            string username = Console.ReadLine();
            Console.Write("Masukkan password: ");
            string password = Console.ReadLine();
            if (username == "admin" && password == "1234")
            {
                Console.WriteLine("Login berhasil!");

                // Tampilkan menu
                while (true)
                {
                    Console.WriteLine("\n===== MENU =====");
                    Console.WriteLine("1. Cari Produk");
                    Console.WriteLine("2. Sortir Produk berdasarkan stok");
                    Console.WriteLine("3. Tambah Produk Baru");
                    Console.WriteLine("4. Hapus Produk");
                    Console.WriteLine("5. Keluar");
                    Console.Write("Pilih menu: ");
                    int pilihan = int.Parse(Console.ReadLine());

                    switch (pilihan)
                    {
                        case 1:
                            Console.Write("Masukkan kata kunci pencarian: ");
                            string kataKunci = Console.ReadLine();
                            Console.Write("Masukkan harga minimum: ");
                            int minHarga = int.Parse(Console.ReadLine());
                            Console.Write("Masukkan harga maksimum: ");
                            int maxHarga = int.Parse(Console.ReadLine());
                            manajemenProduk.CariProduk(kataKunci, minHarga, maxHarga);
                            break;
                        case 2:
                            manajemenProduk.SortirProduk();
                            break;
                        case 3:
                            Console.Write("Masukkan ID produk: ");
                            string id = Console.ReadLine();
                            Console.Write("Masukkan nama produk: ");
                            string nama = Console.ReadLine();
                            Console.Write("Masukkan harga produk: ");
                            int harga = int.Parse(Console.ReadLine());
                            Console.Write("Masukkan jumlah stok produk: ");
                            int stok = int.Parse(Console.ReadLine());
                            manajemenProduk.TambahProduk(id, nama, harga, stok);
                            break;
                        case 4:
                            Console.Write("Masukkan ID produk yang akan dihapus: ");
                            string idHapus = Console.ReadLine();
                            manajemenProduk.HapusProduk(idHapus);
                            break;
                        case 5:
                            Console.WriteLine("Terima kasih telah menggunakan aplikasi.");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Menu tidak valid. Silakan pilih menu yang benar.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Login gagal. Username atau password salah.");
            }
        }
    }
}

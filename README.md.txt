# VIRUS PRÉVISIONS

APlikasi VIRUS PRÉVISIONS adalah sebuah aplikasi simulasi yang digunakan untuk mengetahui penyebaran virus penyakit dengan memanfaatkan algoritma BFS untuk penulusuran graf sebagai pemenuhan tugas besar II IF2211 Strategi Algoritma semester II tahun 2019/2020 yang menggunakan bahasa pemrograman C# berbasis Windows-Form .net framework visual studio.

## Penggunaan
Cara menjalankan aplikasi VIRUS PRÉVISIONS (gunakan sistem operasi Windows):
1. Buka folder bin;
2. Buka folder Debug;
3. Buka file VIRUS PRÉVISIONS.exe;
4. Input file map pada bin>FileTestCase atau file map lainnya yang memenuhi data sebagai berikut:
   a. Baris pertama merupakan N sisi kota yang terhubung
   b. Baris kedua hingga N+1 berisi X Y Z dengan rincian X adalah string kota asal, Y adalah string kota tujuan, dan Z adalah double peluang penyebaran virus dari X ke Y dengan nilai 0 <= Z <= 1;
5. Input file populasi pada bin>FileTestCase atau file map lainnya yang memenuhi data sebagai berikut:
   a. Baris pertama berisi N X dengan rincian N adalah jumlah kota yang disimulasikan dan X adalah kota yang pertama kali terinfeksi
   b. Baris kedua hingga N+1 berisi X P dengan rincian X adalah string kota yang disimulasikan dan P adalah integer jumlah populasi pada kota X dengan nilai P >= 2;
6. Pilih folder tempat penyimpanan data hasil simulasi yang akan diberi nama file dafault oleh sistem dengan nama DataHasilPenyebaranVirus.txt;
7. Input jumlah hari infeksi yang akan disimulasikan penyebarannya dengan nilai 0 <= jumlah hari infeksi <= 1000000000;
8. Tekan tombol "Infected City Map" untuk menampilkan peta penyebaran virus penyakit;
9. Tekan tombol "Clear All" untuk menghapus seluruh input file atau data.


Catatatn developer:
Tetap jaga kesehatannya masing-masing :)

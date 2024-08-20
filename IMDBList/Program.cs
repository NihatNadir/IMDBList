using System;
namespace IMDBList
{
    class Program 
    {
        public List<Film> filmList = new List<Film>();
        int sayac = 1;

        static void Main() 
        {
           Program program = new Program(); // Program classından yeni bir nesne oluşturuyoruz.
           program.Run();
        }

        public void Run()
        {
            Console.WriteLine("IMDB Film Listesi Uygulamasına Hoşgeldiniz..."); 

            while (true) // Kullanıcı aksi belirtilen duruma kadar çalışacak döngüye sokarız.
            {
            addFilm:
                AddFilm(); // AddFilm() metodunu çağırır.
                Console.WriteLine("\nBaşka film eklemek istiyorsanız 'y' film listesini görmek istiyorsanız 'n' basın.");
                string input = Console.ReadLine() ?? "";

                if (input == "y")
                    goto addFilm; // goto ile geriye döner.

                else
                {
                    Console.WriteLine("\nBütün Filmlerin Listesi");
                    AllList(); // AllList() metodunu çağırır.

                    Console.WriteLine("\nIMDB Puanı 4 ile 9 arasında olan Bütün Filmlerin Listesi");
                    FourNine(); // FourNine() metodunu çağırır.

                    Console.WriteLine("\nİsmi 'A' ile başlayan Filmlerin Listesi");
                    StartA(); // StartA() metodunu çağırır.
                    break;
                }
            }
        }

        public void AddFilm() 
        {
            Film film = new Film(); // Film classından film nesnesi oluşturuyoruz.

            Console.WriteLine("\nFilm Adını Giriniz.");

            film.Name = Console.ReadLine() ?? ""; // Kullanıcıdan film adı alıyoruz.

            Console.WriteLine("IMDB Puanını Giriniz.");

            film.ImdbPoint = Convert.ToDouble(Console.ReadLine()); // Kullanıcıdan film imdb puanını alıyoruz.

            filmList.Add(film); // filmList listesine film nesnesini ekliyoruz.

        }

        public void AllList()
        {

            foreach (Film film in filmList) // filmListesindeki filmleri teker teker alır.
            {
                Console.WriteLine(sayac + " - " + film.Name + " " + film.ImdbPoint);
                sayac++;
            }
        }

        public void FourNine()
        {
            var filterList = filmList.Where(film => film.ImdbPoint >= 4 && film.ImdbPoint <= 9).ToList(); // filmListesindeki filmleri ImdbPoint 4 ile 9 arasındaki puanları alacak şekilde filtreler.
            sayac = 1;
            foreach (Film filter in filterList) // filtrelenmiş listedeki filmleri teker teker alır.
            {
                Console.WriteLine(sayac + " - " + filter.Name + " " + filter.ImdbPoint);
                sayac++;
            }
        }

        public void StartA()
        {
            var filterList = filmList.Where(film => film.Name.StartsWith("A")).ToList(); // filmListesindeki filmleri Name "A" ile başlayanları filtreler.
            sayac = 1;
            foreach (Film filter in filterList) // filtrelenmiş listedeki filmleri teker teker alır.
            {
                Console.WriteLine(sayac + " - " + filter.Name + " " + filter.ImdbPoint);
                sayac++;
            }
        }

    }
}
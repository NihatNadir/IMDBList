# IMDBList TR || ENG

##  Film nesnesi ile Film Listesi oluşturuyoruz.
- Filmlerin yer alacağı film listesini oluşturuyoruz.
- Main metodundan yeni bir nesne oluşturdum.
- Bu nesne Run() metodunu çağırıyor.
- Run() metodu içerisinde karşılama mesajı ile program başlıyor.
- Kullanıcıdan aksi durum gelene kadar sürekli çalışan döngüye sokuyoruz.
- AddFilm() metodu çağrılıyor.Bu metot içerisinde yeni bir film nesnesi oluşturuluyor.
- Film nesnesi içindeki propertyler -> Imdb Puanı (Double) - İsmi 
- Kullanıcı yeni film bilgilerini AddFilm() metodunda giriyor.
- Girilen bilgilerden sonra başka film eklemek isteyip istemediğini soruyoruz.
- Eklemek isterse tekrar AddFilm() metoduna giriyor eklemek istemezse filmlistesini konsol ekranına yazdırıyor.
- Film listesini yazdırırken ilk yazdırılan bütün filmlerin yer aldığı listeyi yazdırıyoruz.
- Bütün filmlerin yer aldığı listeyi AllList() metodu ile çağırıyoruz.
- Listedeki elemanlar foreach ile teker teker alınıp konsola yazdırılıyor.
- Imdb puanları 4 ile 9 arasında olanları yazdırması için FourNine() metodu çağrılıyor.
- Filmlistesindeki elemanları linq sorgusu ile filtreleyip bu listeyi foreach ile teker teker konsola yazdırır.
- A harfi ile başlayan filmleri yazdırmak için StartA() metodu çağrılıyor.
- Filmlistesindeki elemanları linq sorgusu ile filtreleyip bu listeyi foreach ile teker teker konsola yazdırır.
- Kullanıcıya bu bilgiler geldikten sonra konsol ekranı kapanır.

--- 

## We are creating a Film List with Film objects.
- We create a film list where the films will be stored.
- A new object is instantiated from the Main method.
- This object calls the Run() method.
- The program starts with a welcome message inside the Run() method.
- We put the program in a loop that continues to run until the user decides otherwise.
- The AddFilm() method is called. In this method, a new Film object is created.
- The Film object has properties such as IMDb rating (Double) and Name.
- The user inputs the new film's details in the AddFilm() method.
- After the details are entered, we ask if the user wants to add another film.
- If they want to add another film, the AddFilm() method is called again. If not, the film list is printed on the console.
- When printing the film list, we first print the entire list of films.
- We call the AllList() method to retrieve the complete list.
- The elements in the list are printed to the console one by one using a foreach loop.
- To print only the films with IMDb ratings between 4 and 9, we call the FourNine() method.
- This method filters the elements in the film list using a LINQ query, and then prints the filtered list to the console using a foreach loop.
- To print the films that start with the letter 'A', the StartA() method is called.
- This method filters the elements in the film list using a LINQ query, and then prints the filtered list to the console using a foreach loop.
- After displaying this information, the console screen closes.




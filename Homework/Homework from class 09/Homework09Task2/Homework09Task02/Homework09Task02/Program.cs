namespace Homework09Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song("Bohemian Rhapsody", 5.55, Genre.Rock);
            Song song2 = new Song("Lose Yourself", 5.26, Genre.Hip_Hop);
            Song song3 = new Song("Billie Jean", 3.45, Genre.Techno);

            
            Person person1 = new Person(1, "Petar", "Dimi", 25, Genre.Rock);
            person1.FavoriteSongs.Add(song1);
            person1.FavoriteSongs.Add(song2); 

            
            person1.GetFavSongs(); 

            
            Person person2 = new Person(2, "Bob", "Bobski", 30, Genre.Classical);

           
            person2.GetFavSongs(); 
        }
    }
}

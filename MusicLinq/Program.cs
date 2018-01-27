using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            // foreach (Group group in Groups)
            // {
            //     Console.WriteLine(group.GroupName);
            // }

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            var foundArtists = (from match in Artists
                    orderby match.ArtistName descending
                    select new { match.ArtistName, match.Age, match.Hometown, match.RealName });

            Console.WriteLine(" Task "  + "There is only one artist in this collection from Mount Vernon, what is their name and age?");
            //There is only one artist in this collection from Mount Vernon, what is their name and age?

            var result = foundArtists.Where(match => match.Hometown.ToString() == "Mount Vernon");

            foreach (var artist in result)
            {
                Console.WriteLine(artist.ArtistName + " "  + artist.Age);
            }

            Console.WriteLine(" Task "  + "Who is the youngest artist in our collection of artists?");
            //Who is the youngest artist in our collection of artists?
            var result2 = foundArtists.Where(match => match.Age == foundArtists.Min(r=> r.Age));
            foreach (var artist in result2)
            {
                Console.WriteLine(artist.ArtistName + " "  + artist.Age);
            }

            Console.WriteLine(" Task "  + "Display all artists with 'William' somewhere in their real name " );
            //Display all artists with 'William' somewhere in their real name
            var result3 = foundArtists.Where(match => match.RealName.Contains("William"));
            foreach (var artist in result3)
            {
                Console.WriteLine(artist.ArtistName + " "  + artist.Age);
            }

            Console.WriteLine(" Task "  + "Display the 3 oldest artist from Atlanta " );
            //Display the 3 oldest artist from Atlanta
            var result4 = foundArtists.Where(match => match.Hometown == "Atlanta").OrderByDescending(artist => artist.Age).Take(3);
            foreach (var artist in result4)
            {
                Console.WriteLine(artist.ArtistName + " "  + artist.Age);
            }

            Console.WriteLine(" Task "  + "(Optional) Display the Group Name of all groups that have members that are not from New York City " );
            //(Optional) Display the Group Name of all groups that have members that are not from New York City

            Console.WriteLine(" Task "  + "(Optional) Display the artist names of all members of the group 'Wu-Tang Clan' " );
            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
        }
    }
}

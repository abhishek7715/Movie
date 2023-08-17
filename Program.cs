
using MovieAppTask.Service;
using MovieAppTask.Service;
using MoviesAppTask.Controller1;
using MoviesAppTask.Model;


using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppTask
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            new MovieController();
          
        }

     //   static void AddMovies()
      //  {
        //    string Name;
        //    string genre;
        //    string director;
        //    int year;
        //    if (movies.Count <= length)
        //    {
        
        //        Console.Write("Enter Movie Name :");
        //        Name = Console.ReadLine();
        //        Console.Write("Enter Movie Genre :");
        //        genre = Console.ReadLine();
        //        Console.Write("Enter Movie Director Name :");
        //        director = Console.ReadLine();
        //        Console.Write("Enter Movie year of Release :");
        //        year = Convert.ToInt32(Console.ReadLine());
        //        movieObject= new Movie(Name, genre, director, year);
        //        movies.Add(movieObject);
        //        DataSerializer.BinarySerializer(movies, filePath);
        //        Console.WriteLine("Movie Added in the list");
        //    }
        //    else
        //    {
        //        Console.WriteLine("List is Full");
        //    }
      //  }
        
        
      //  private static void RemoveByName()
      //  {
            //File.WriteAllText(filePath, string.Empty);
            //Console.WriteLine("-------------------------------");
            //Console.Write("Enter Movie name: ");
            //string findMovie = Console.ReadLine();
            //for (int i = 0; i < movies.Count; i++)
            //{
            //    if (movies[i].MovieName == findMovie)
            //    {
            //        Movie a = movies[i];
            //        movies.Remove(a);
            //    }
            //    DataSerializer.BinarySerializer(movies, filePath);
            //}
            //Console.WriteLine("Movie Deleted Succesfully");
        //  }
        //public static void DisplayByYear(List<Movie> movies)
        //{
        //    Console.WriteLine("-------------------------------");
        //    Console.Write("Enter Movie year : ");
        //    int findMovie = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine(movies.Find(movie => movie.Year == findMovie).MovieName);
        //}
    }
}

        

    

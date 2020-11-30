﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FilesAndObjects
{
    class Program
    {
        class Movie
        {
            public string title;
            public string rating;
            public string year;

            public Movie(string _title, string _rating, string _year)
            {
                title = _title;
                rating = _rating;
                year = _year;
            }
        }
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\opilane\samples";
            string fileName = @"MovieTV.txt";
            // a list to store the movies from the file
            List<string> movielist = File.ReadAllLines(Path.Combine(filePath, fileName)).ToList();
            List<Movie> ListOfMovies = new List<Movie>();

            foreach (string movieitem in movielist)
            {
                string[] tempArray = movieitem.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                Movie newMovie = new Movie(tempArray[0], tempArray[1], tempArray[2]);

                ListOfMovies.Add(newMovie);
            }

            foreach(Movie movie in ListOfMovies)
            {
                Console.WriteLine($"Title: {movie.title}; Rating: {movie.rating}; Year: {movie.year}");
            }

        }
    }
}
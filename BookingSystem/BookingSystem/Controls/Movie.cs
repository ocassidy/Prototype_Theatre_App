using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BookingSystem.Controls
{
    class Movie : BindableObject
    {
        public static readonly BindableProperty TitleProperty =
        BindableProperty.Create("Title", typeof(string),
                              typeof(Movie),
                              default(string));

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly BindableProperty DescProperty =
        BindableProperty.Create("Year", typeof(int),
                             typeof(Movie),
                             default(string));

        public string Description
        {
            get { return (string)GetValue(DescProperty); }
            set { SetValue(DescProperty, value); }
        }

        public static readonly BindableProperty YearProperty =
        BindableProperty.Create("Year", typeof(int),
                             typeof(Movie),
                             default(string));

        public int Year
        {
            get { return (int)GetValue(YearProperty); }
            set { SetValue(YearProperty, value); }
        }

        public static readonly BindableProperty DirectorProperty =
        BindableProperty.Create("Director", typeof(string),
                             typeof(Movie),
                             default(string));

        public string Director
        {
            get { return (string)GetValue(DirectorProperty); }
            set { SetValue(DirectorProperty, value); }
        }

        public static readonly BindableProperty DurationProperty =
        BindableProperty.Create("Duration", typeof(int),
                             typeof(Movie),
                             default(string));

        public int Duration
        {
            get { return (int)GetValue(YearProperty); }
            set { SetValue(YearProperty, value); }
        }

        public static readonly BindableProperty RatingProperty =
        BindableProperty.Create("Title", typeof(int),
                             typeof(Movie),
                             default(string));

        public int Rating
        {
            get { return (int)GetValue(RatingProperty); }
            set { SetValue(RatingProperty, value); }
        }

        public static readonly BindableProperty PosterProperty =
        BindableProperty.Create("Poster", typeof(string),
                            typeof(Movie),
                            default(string));

        public string Poster
        {
            get { return (string)GetValue(PosterProperty); }
            set { SetValue(PosterProperty, value); }
        }

        public enum Genres { Comedy, Action, Thriller, Horror, Romance, SciFi, Western, Family, Documentary};

        public static readonly BindableProperty GenreProperty =
        BindableProperty.Create("Genre", typeof(Genres),
                           typeof(Movie),
                           default(string));

        public Genres Genre
        {
            get { return (Genres)GetValue(GenreProperty); }
            set { SetValue(GenreProperty, value); }
        }
    }
}

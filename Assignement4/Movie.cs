using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement4
{
    public class Movie
    {
        
            private string title;
            private string genre;
            private bool isAvailable;

            public string Title { get => title; }
            public string Genre { get => genre; }
            public bool IsAvailable { get => isAvailable; private set => isAvailable = value; }

            public Movie(string title, string genre)
            {
                this.title = title;
                this.genre = genre;
                this.isAvailable = true;
            }

            public bool Rent()
            {
                if (IsAvailable)
                {
                    IsAvailable = false;
                    return true;
                }
                return false;
            }

            public void Return()
            {
                IsAvailable = true;
            }
        }
    }


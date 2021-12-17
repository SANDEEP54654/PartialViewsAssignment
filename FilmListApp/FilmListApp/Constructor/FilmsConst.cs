using FilmListApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmListApp.Constructor
{
    public class FilmsConst
    {
        public FilmsModel FilmsModel;

        public FilmsConst(string title, string duration, string description)
        {
            FilmsModel = new FilmsModel()
            {
                Title = title,
                Duration = duration,
                Description = description
            };
        }
    }
}

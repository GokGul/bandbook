using Bandbook.Models;
using System;
using System.Collections.Generic;

namespace Bandbook.ViewModels
{
    public class BandFormViewModel
    {
        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public DateTime DateTime {
            get
            {
                return DateTime.Parse(string.Format("{0} {1}", Date, Time));
            }
        }
        public byte Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

    }
}
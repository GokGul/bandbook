using Bandbook.Models;
using System.Collections.Generic;

namespace Bandbook.ViewModels
{
    public class BandFormViewModel
    {
        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

    }
}
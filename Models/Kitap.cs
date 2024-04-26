using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kitap_modeli.Models
{
    public class Kitap
    {
        public string book_name {get; set;}
        public string writer_name {get; set;}
        public string publication_date {get; set;}
        public string type {get; set;}
        public int book_Number_of_pages {get; set;}
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebAlbum.Models
{
    public class Album
    {  

        public int id { get; set; }
        public int userId { get; set; }
        public string title { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}

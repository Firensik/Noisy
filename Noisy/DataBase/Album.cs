using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noisy.DataBase
{
    public class Album
    {
        public int Id { get; set; }
        public string ArtistName { get; set; }
        public string TitleAlbum { get; set; }
        public string VersionAlbum { get; set; }
        public DateTime PublicationDate { get; set; }


        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        public List<Song>Songs { get; set; }
    }
}

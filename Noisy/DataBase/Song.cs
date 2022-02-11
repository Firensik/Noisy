using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noisy.DataBase
{
    public class Song
    {
        public int Id { get; set; }
        public int Time { get; set; }
        public string Title { get; set; }


        public int AlbumId { get; set; }
        public Album Album { get; set; }
    }
}

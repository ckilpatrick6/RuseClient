using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeGrooverClient.Helpers
{
    public class AlbumMessage
    {
        public string Id { get; set; }
        public AlbumMessage(string id)
        {
            Id = id;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingRxCommons
{
    public interface IAlbum
    {
        string ServiceItemId { get; }

        string Name { get;}
        string Artist { get; }

        string CoverUrl { get; }

    }
}

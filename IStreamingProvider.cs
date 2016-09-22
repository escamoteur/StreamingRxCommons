using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingRxCommons
{
    public interface IStreamingProvider
    {
        ObservableCollection<IAlbum> GetNewReleases(int limit, int offset = 0);
    }
}

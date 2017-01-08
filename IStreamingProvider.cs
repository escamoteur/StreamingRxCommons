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
        IObservable<IEnumerable<IAlbum>> GetNewReleases(int limit, int offset = 0);

        IObservable<IEnumerable<IAlbum>> SearchAlbumsFreeText(string searchText, int limit, int offset = 0, string maket = "US");

        IObservable<IEnumerable<IAlbum>> GetAlbumByServiceId(string serviceID);

        IObservable<IEnumerable<ITrack>> GetTracksForAlbum(IAlbum album, int limit, int offset = 0);

        IObservable<IEnumerable<ITrack>> GetTracksForAlbum(string album_service_Id, int limit, int offset = 0);

        IObservable<int> GetTrackCountForAlbum(string album_service_Id);

    }
}

using System.Collections;
using System.Collections.Generic;

namespace CSharp_6
{
    class ArtistCollection : IEnumerable<Artist>
    {

        List<Artist> artists = new List<Artist> {
            new Artist { Age = 40, Name = "Jay Z" },
            new Artist { Age = 60, Name = "Julio Iglesias" } };

        public IEnumerator<Artist> GetEnumerator()
        {
            return artists.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Artist Put(Artist anotherArtist)
        {
            artists.Add(anotherArtist);
            return anotherArtist;
        }
    }
}
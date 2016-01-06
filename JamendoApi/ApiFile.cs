using JamendoApi.Util;

namespace JamendoApi
{
    /// <summary>
    /// Lists the possible Files that can be gotten from the Api.
    /// </summary>
    public enum ApiFile
    {
        /// <summary>
        /// A zip file of an album.
        /// </summary>
        [ApiName("albums")]
        Album,

        /// <summary>
        /// A zip file of a playlist.
        /// </summary>
        [ApiName("playlists")]
        Playlist,

        /// <summary>
        /// An mp3 file of a track.
        /// </summary>
        [ApiName("tracks")]
        Track
    }
}
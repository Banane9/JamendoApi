using JamendoApi.ApiParts.Albums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JamendoApi.Tests
{
    [TestClass]
    public class Albums
    {
        private JsonSerializer deserializer = new JsonSerializer();

        [TestMethod]
        public void BasicAlbumDeserializes()
        {
            var response = deserializer.Deserialize<JamendoApiResponse<BasicAlbum[]>>(new JsonTextReader(new StringReader(
                "{\"headers\":{\"status\":\"success\",\"code\":0,\"error_message\":\"\",\"warnings\":\"\",\"results_count\":1},\"results\":[{\"id\":\"24\",\"name\":\"Premiers Jets\",\"releasedate\":\"2004 - 12 - 17\",\"artist_id\":\"7\",\"artist_name\":\"TriFace\",\"image\":\"https:\\/\\/imgjam1.jamendo.com\\/albums\\/s0\\/24\\/covers\\/1.200.jpg\",\"zip\":\"https:\\/\\/mp3d.jamendo.com\\/download\\/a24\\/mp32\\/\",\"shorturl\":\"http:\\/\\/jamen.do\\/l\\/a24\",\"shareurl\":\"http:\\/\\/www.jamendo.com\\/list\\/a24\"}]}")));

            var result = response.Results[0];
            Assert.AreEqual(24u, result.Id);
            Assert.AreEqual("Premiers Jets", result.Name);
            Assert.AreEqual(new DateTime(2004, 12, 17), result.ReleaseDate);
            Assert.AreEqual(7u, result.ArtistId);
            Assert.AreEqual("TriFace", result.ArtistName);
            Assert.AreEqual("https://imgjam1.jamendo.com/albums/s0/24/covers/1.200.jpg", result.Image);
            Assert.AreEqual("https://mp3d.jamendo.com/download/a24/mp32/", result.Zip);
            Assert.AreEqual("http://jamen.do/l/a24", result.ShortUrl);
            Assert.AreEqual("http://www.jamendo.com/list/a24", result.ShareUrl);
        }

        [TestMethod]
        public void MusicInfoAlbumDeserializes()
        {
            var response = deserializer.Deserialize<JamendoApiResponse<MusicInfoAlbum[]>>(new JsonTextReader(new StringReader(
                "{\"headers\":{\"status\":\"success\",\"code\":0,\"error_message\":\"\",\"warnings\":\"\",\"results_count\":1},\"results\":[{\"id\":\"24\",\"name\":\"Premiers Jets\",\"releasedate\":\"2004 - 12 - 17\",\"artist_id\":\"7\",\"artist_name\":\"TriFace\",\"image\":\"https:\\/\\/imgjam1.jamendo.com\\/albums\\/s0\\/24\\/covers\\/1.200.jpg\",\"zip\":\"https:\\/\\/mp3d.jamendo.com\\/download\\/a24\\/mp32\\/\",\"shorturl\":\"http:\\/\\/jamen.do\\/l\\/a24\",\"shareurl\":\"http:\\/\\/www.jamendo.com\\/list\\/a24\",\"musicinfo\":{\"tags\":[\"angry\",\"metal\",\"drum\",\"hardrock\",\"hardcore\"],\"description\":{\"en\":\"Description\",\"de\":\"Beschreibung\"}}}]}")));

            var result = response.Results[0];
            Assert.AreEqual(24u, result.Id);
            Assert.AreEqual("Premiers Jets", result.Name);
            Assert.AreEqual(new DateTime(2004, 12, 17), result.ReleaseDate);
            Assert.AreEqual(7u, result.ArtistId);
            Assert.AreEqual("TriFace", result.ArtistName);
            Assert.AreEqual("https://imgjam1.jamendo.com/albums/s0/24/covers/1.200.jpg", result.Image);
            Assert.AreEqual("https://mp3d.jamendo.com/download/a24/mp32/", result.Zip);
            Assert.AreEqual("http://jamen.do/l/a24", result.ShortUrl);
            Assert.AreEqual("http://www.jamendo.com/list/a24", result.ShareUrl);

            foreach (var item in new[] { "angry", "metal", "drum", "hardrock", "hardcore" })
                Assert.IsTrue(result.MusicInfo.Tags.Contains(item));

            Assert.AreEqual("Description", result.MusicInfo.Descriptions["en"]);
            Assert.AreEqual("Beschreibung", result.MusicInfo.Descriptions["de"]);
        }

        [TestMethod]
        public void TracksAlbumDeserializes()
        {
            var response = deserializer.Deserialize<JamendoApiResponse<TracksAlbum[]>>(new JsonTextReader(new StringReader(
                "{\"headers\":{\"status\":\"success\",\"code\":0,\"error_message\":\"\",\"warnings\":\"\",\"results_count\":1},\"results\":[{\"id\":\"24\",\"name\":\"Premiers Jets\",\"releasedate\":\"2004-12-17\",\"artist_id\":\"7\",\"artist_name\":\"TriFace\",\"image\":\"https:\\/\\/imgjam1.jamendo.com\\/albums\\/s0\\/24\\/covers\\/1.200.jpg\",\"zip\":\"https:\\/\\/mp3d.jamendo.com\\/download\\/a24\\/mp32\\/\",\"tracks\":[{\"id\":\"168\",\"position\":\"1\",\"name\":\"J'm'e FPM\",\"duration\":\"183\",\"license_ccurl\":\"http:\\/\\/creativecommons.org\\/licenses\\/by-nc-sa\\/2.0\\/\",\"audio\":\"https:\\/\\/mp3l.jamendo.com\\/?trackid=168&format=mp31&from=app-9d9f42e3\",\"audiodownload\":\"https:\\/\\/mp3d.jamendo.com\\/download\\/track\\/168\\/mp32\\/\"},{\"id\":\"169\",\"position\":\"2\",\"name\":\"Trio HxC\",\"duration\":\"101\",\"license_ccurl\":\"http:\\/\\/creativecommons.org\\/licenses\\/by-nc-sa\\/2.0\\/\",\"audio\":\"https:\\/\\/mp3l.jamendo.com\\/?trackid=169&format=mp31&from=app-9d9f42e3\",\"audiodownload\":\"https:\\/\\/mp3d.jamendo.com\\/download\\/track\\/169\\/mp32\\/\"}]}]}")));

            var result = response.Results[0];
            Assert.AreEqual(24u, result.Id);
            Assert.AreEqual("Premiers Jets", result.Name);
            Assert.AreEqual(new DateTime(2004, 12, 17), result.ReleaseDate);
            Assert.AreEqual(7u, result.ArtistId);
            Assert.AreEqual("TriFace", result.ArtistName);
            Assert.AreEqual("https://imgjam1.jamendo.com/albums/s0/24/covers/1.200.jpg", result.Image);
            Assert.AreEqual("https://mp3d.jamendo.com/download/a24/mp32/", result.Zip);

            var track = result.Tracks[0];
            Assert.AreEqual(168u, track.Id);
            Assert.AreEqual(1u, track.Position);
            Assert.AreEqual("J'm'e FPM", track.Name);
            Assert.AreEqual(183u, track.Duration);
            Assert.AreEqual("http://creativecommons.org/licenses/by-nc-sa/2.0/", track.LicenseCCUrl);
            Assert.AreEqual("https://mp3l.jamendo.com/?trackid=168&format=mp31&from=app-9d9f42e3", track.Audio);
            Assert.AreEqual("https://mp3d.jamendo.com/download/track/168/mp32/", track.AudioDownload);

            track = result.Tracks[1];
            Assert.AreEqual(169u, track.Id);
            Assert.AreEqual(2u, track.Position);
            Assert.AreEqual("Trio HxC", track.Name);
            Assert.AreEqual(101u, track.Duration);
            Assert.AreEqual("http://creativecommons.org/licenses/by-nc-sa/2.0/", track.LicenseCCUrl);
            Assert.AreEqual("https://mp3l.jamendo.com/?trackid=169&format=mp31&from=app-9d9f42e3", track.Audio);
            Assert.AreEqual("https://mp3d.jamendo.com/download/track/169/mp32/", track.AudioDownload);
        }
    }
}
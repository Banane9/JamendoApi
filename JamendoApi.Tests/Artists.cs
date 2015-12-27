using JamendoApi.ApiEntities.Artists;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JamendoApi.Tests
{
    [TestClass]
    public class Artists
    {
        private JsonSerializer deserializer = new JsonSerializer();

        [TestMethod]
        public void ArtistTracksSingleDeserializes()
        {
            var response = deserializer.Deserialize<JamendoApiResponse<TracksArtist[]>>(new JsonTextReader(new StringReader(
                "{\"headers\":{\"status\":\"success\",\"code\":0,\"error_message\":\"\",\"warnings\":\"\",\"results_count\":1},\"results\":[{\"id\":\"482\",\"name\":\"SAKTO\",\"website\":\"http:\\/\\/www.myspace.com\\/pataknin\",\"joindate\":\"2005-09-01\",\"image\":\"https:\\/\\/imgjam2.jamendo.com\\/%2Fartists%2Fs%2Fsakto-nin.jpg\",\"tracks\":[{\"album_id\":\"\",\"album_name\":\"\",\"id\":\"1181180\",\"name\":\"I go towards me\",\"duration\":\"254\",\"releasedate\":\"2015-01-06\",\"license_ccurl\":\"http:\\/\\/creativecommons.org\\/licenses\\/by-nd\\/3.0\\/\",\"album_image\":\"\",\"image\":\"https:\\/\\/imgjam1.jamendo.com\\/track\\/s1181\\/1181180\\/covers\\/1.200.jpg\",\"audio\":\"https:\\/\\/mp3l.jamendo.com\\/?trackid=1181180&format=mp31&from=app-9d9f42e3\",\"audiodownload\":\"https:\\/\\/mp3l.jamendo.com\\/download\\/track\\/1181180\\/mp31\\/\"}]}]}")));

            var single = response.Results[0].Tracks[0];
            Assert.IsFalse(single.AlbumId.HasValue);
            Assert.IsTrue(single.IsSingle);
            Assert.AreEqual("", single.AlbumName);
            Assert.AreEqual(1181180u, single.Id);
            Assert.AreEqual("I go towards me", single.Name);
            Assert.AreEqual(254u, single.Duration);
            Assert.AreEqual(new DateTime(2015, 1, 6), single.ReleaseDate);
            Assert.AreEqual("http://creativecommons.org/licenses/by-nd/3.0/", single.LicenseCCUrl);
            Assert.AreEqual("", single.AlbumImage);
            Assert.AreEqual("https://imgjam1.jamendo.com/track/s1181/1181180/covers/1.200.jpg", single.Image);
            Assert.AreEqual("https://mp3l.jamendo.com/?trackid=1181180&format=mp31&from=app-9d9f42e3", single.Audio);
            Assert.AreEqual("https://mp3l.jamendo.com/download/track/1181180/mp31/", single.AudioDownload);
        }
    }
}
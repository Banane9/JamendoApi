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
            var response = deserializer.Deserialize<JamendoApiResponse<BasicAlbum>>(new JsonTextReader(new StringReader(
                "{\"headers\":{\"status\":\"success\",\"code\":0,\"error_message\":\"\",\"warnings\":\"\",\"results_count\":1},\"results\":[{\"id\":\"24\",\"name\":\"Premiers Jets\",\"releasedate\":\"2004 - 12 - 17\",\"artist_id\":\"7\",\"artist_name\":\"TriFace\",\"image\":\"https://imgjam1.jamendo.com/albums/s0/24/covers/1.200.jpg\",\"zip\":\"https://mp3d.jamendo.com/download/a24/mp32/\",\"shorturl\":\"http://jamen.do/l/a24\",\"shareurl\":\"http://www.jamendo.com/list/a24\"}]}")));
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
    }
}
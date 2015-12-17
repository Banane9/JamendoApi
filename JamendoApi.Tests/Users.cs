using JamendoApi.ApiParts.Users;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JamendoApi.Tests
{
    [TestClass]
    public class Users
    {
        private JsonSerializer deserializer = new JsonSerializer();

        [TestMethod]
        public void ArtistsUserDeserializes()
        {
            var response = deserializer.Deserialize<JamendoApiResponse<ArtistsUser[]>>(new JsonTextReader(new StringReader(
                "{\"headers\":{\"status\":\"success\",\"code\":0,\"error_message\":\"\",\"warnings\":\"\",\"results_count\":1},\"results\":[{\"name\":\"claudod\",\"dispname\":\"claudod\",\"id\":\"972174\",\"lang\":\"it\",\"creationdate\":\"2010 - 10 - 17\",\"image\":\"https:\\/\\/imgjam1.jamendo.com\\/users\\/s972\\/972174\\/covers\\/1.50.jpg\",\"artists\":[{\"id\":\"104\",\"name\":\"Tryad\",\"image\":\"https:\\/\\/imgjam1.jamendo.com\\/artists\\/t\\/tryad.jpg\",\"joindate\":\"2005-04-13\",\"updatedate\":\"2013-09-09 12:01:44\",\"relations\":{\"fan\":\"1\"}}]}]}")));

            var result = response.Results[0];
            Assert.AreEqual("claudod", result.Name);
            Assert.AreEqual("claudod", result.DisplayName);
            Assert.AreEqual(972174u, result.Id);
            Assert.AreEqual("it", result.Language);
            Assert.AreEqual(new DateTime(2010, 10, 17), result.CreationDate);
            Assert.AreEqual("https://imgjam1.jamendo.com/users/s972/972174/covers/1.50.jpg", result.Image);

            var artist = result.Artists[0];
            Assert.AreEqual(104u, artist.Id);
            Assert.AreEqual("Tryad", artist.Name);
            Assert.AreEqual("https://imgjam1.jamendo.com/artists/t/tryad.jpg", artist.Image);
            Assert.AreEqual(new DateTime(2005, 04, 13), artist.JoinDate);
            Assert.AreEqual(new DateTime(2013, 09, 09, 12, 01, 44), artist.UpdateDate);
            Assert.AreEqual(1u, artist.Relations[ArtistsUser.Artist.Relation.Fan]);
        }
    }
}
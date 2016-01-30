using JamendoApi.ApiEntities.Feeds;
using JamendoApi.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JamendoApi.Tests
{
    [TestClass]
    public class Feeds
    {
        [TestMethod]
        public void FeedDeserializes()
        {
            var deserializer = new JsonSerializer();
            var response = deserializer.Deserialize<JamendoApiResponse<BasicFeed[]>>(new JsonTextReader(new StringReader(
                "{\"headers\":{\"status\":\"success\",\"code\":0,\"error_message\":\"\",\"warnings\":\"\",\"results_count\":1},\"results\":[{\"id\":\"328\",\"title\":{\"en\":\"The best of 2015... so far!\",\"de\":\"Das Beste aus 2015 ... zumindest bis jetzt!\"},\"link\":\"https:\\/\\/www.jamendo.com\\/list\\/p500117138\",\"position\":\"8\",\"lang\":[\"en\",\"de\"],\"date_start\":\"2015-10-12 00:00:00\",\"date_end\":\"2200-01-01 00:00:00\",\"text\":{\"en\":\"2015 is not only a year of change for Jamendo, it's also a pretty awesome year of music! Discover the coolest 2015 songs we got, so far!\t\t\r\n\r\n\r\n\r\n\r\n\r\n\",\"de\":\"2015 bedeutet nicht nur gro\u00dfe Ver\u00e4nderungen f\u00fcr Jamendo, 2015 ist auch ein Jahr voll gro\u00dfartiger Musik! Entdecke unsere bislang coolsten Songs f\u00fcr 2015!\"},\"type\":\"playlist\",\"joinid\":\"500117138\",\"subtitle\":[],\"target\":\"all\",\"images\":{\"size996_350\":\"https:\\/\\/imgjam2.jamendo.com\\/feeds\\/28\\/328.996_350.jpg?du=2015-10-12+11%3A28%3A28\",\"size315_111\":\"https:\\/\\/imgjam1.jamendo.com\\/feeds\\/28\\/328.315_111.jpg?du=2015-10-12+11%3A28%3A28\",\"size600_211\":\"https:\\/\\/imgjam2.jamendo.com\\/feeds\\/28\\/328.600_211.jpg?du=2015-10-12+11%3A28%3A28\",\"size470_165\":\"https:\\/\\/imgjam1.jamendo.com\\/feeds\\/28\\/328.470_165.jpg?du=2015-10-12+11%3A28%3A28\"}}]}")));

            var result = response.Results[0];
            Assert.AreEqual(328u, result.Id);
            Assert.AreEqual("The best of 2015... so far!", result.Title[Language.English]);
            Assert.AreEqual("Das Beste aus 2015 ... zumindest bis jetzt!", result.Title[Language.German]);
            Assert.AreEqual(string.Empty, result.Title[Language.Russian]);
            Assert.AreEqual("https://www.jamendo.com/list/p500117138", result.Link);
            Assert.AreEqual(8u, result.Position);
            Assert.IsTrue(result.AvailableLanguages.All(lang => lang == Language.German || lang == Language.English));
            Assert.AreEqual(new DateTime(2015, 10, 12), result.StartDate);
            Assert.AreEqual(new DateTime(2200, 1, 1), result.EndDate);
            Assert.AreEqual("2015 is not only a year of change for Jamendo, it's also a pretty awesome year of music! Discover the coolest 2015 songs we got, so far!\t\t\r\n\r\n\r\n\r\n\r\n\r\n", result.Text[Language.English]);
            Assert.AreEqual("2015 bedeutet nicht nur große Veränderungen für Jamendo, 2015 ist auch ein Jahr voll großartiger Musik! Entdecke unsere bislang coolsten Songs für 2015!", result.Text[Language.German]);
            Assert.AreEqual(string.Empty, result.Text[Language.Spanish]);
            Assert.AreEqual(FeedType.Playlist, result.Type);
            Assert.AreEqual(500117138u, result.TargetId);
            Assert.AreEqual(string.Empty, result.Subtitle[Language.English]);
            Assert.AreEqual(UserStatus.All, result.TargetUsers);
            Assert.AreEqual("https://imgjam2.jamendo.com/feeds/28/328.996_350.jpg?du=2015-10-12+11%3A28%3A28", result.Images.Size996x350);
        }
    }
}
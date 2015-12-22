using JamendoApi.ApiParts.Autocomplete;
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
    public class Autocomplete
    {
        [TestMethod]
        public void AutocompleteDeserializes()
        {
            var deserializer = new JsonSerializer();
            var response = deserializer.Deserialize<JamendoApiResponse<Matches>>(new JsonTextReader(new StringReader(
                "{\"headers\":{\"status\":\"success\",\"code\":0,\"error_message\":\"\",\"warnings\":\"\",\"results_count\":4},\"results\":{\"tags\":[{\"match\":\"something\",\"count\":6}],\"artists\":[{\"match\":\"something\",\"count\":2}]}}")));

            var result = response.Results;
            Assert.IsTrue(result.ContainsKey(AutocompleteEntity.Tags));
            Assert.IsTrue(result.ContainsKey(AutocompleteEntity.Artists));

            Assert.AreEqual("something", result[AutocompleteEntity.Tags][0].Completion);
            Assert.AreEqual(6u, result[AutocompleteEntity.Tags][0].Count);

            Assert.AreEqual("something", result[AutocompleteEntity.Artists][0].Completion);
            Assert.AreEqual(2u, result[AutocompleteEntity.Artists][0].Count);
        }
    }
}
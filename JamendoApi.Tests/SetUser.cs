using JamendoApi.ApiEntities.SetUser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JamendoApi.Tests
{
    [TestClass]
    public class SetUser
    {
        [TestMethod]
        public void SetUserResponseDeserializes()
        {
            var deserializer = new JsonSerializer();
            var response = deserializer.Deserialize<JamendoApiResponse<EmptyResult[]>>(new JsonTextReader(new StringReader(
                "{\"headers\":{\"status\":\"success\",\"code\":0,\"error_message\":\"\",\"warnings\":\"\",\"results_count\":0},\"results\":[]}")));
        }
    }
}
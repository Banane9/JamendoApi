﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.IO;

namespace JamendoApi.Tests
{
    [TestClass]
    public class Headers
    {
        [TestMethod]
        public void HeaderDeserializes()
        {
            var deserializer = new JsonSerializer();
            var headers = deserializer.Deserialize<ApiEntities.Headers>(new JsonTextReader(new StringReader(
                "{\"status\":\"failed\", \"code\":1, \"error_message\":\"test\", \"warnings\":\"Test\", \"results_count\":1 }")));

            Assert.AreEqual(ApiEntities.Headers.ResponseStatus.Failed, headers.Status);
            Assert.AreEqual(ApiEntities.Headers.StatusCode.Exception, headers.Code);
            Assert.AreEqual("test", headers.ErrorMessage);
            Assert.AreEqual("Test", headers.Warnings);
            Assert.AreEqual(1u, headers.ResultCount);
        }
    }
}
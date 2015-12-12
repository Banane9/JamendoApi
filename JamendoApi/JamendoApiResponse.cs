using JamendoApi.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi
{
    [JsonObject]
    public sealed class JamendoApiResponse<TResult> where TResult : JamendoApiEntity
    {
        public Headers Headers { get; private set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Reviews
{
    public enum ReviewOrder
    {
        [ApiName("addeddate")]
        DateAdded,

        [ApiName("score")]
        Score,

        [ApiName("id")]
        Id
    }
}
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiEntities.Artists
{
    /// <summary>
    /// Represents the Artist object which is part of the /artists/locations results.
    /// <para/>
    /// Documented here: https://developer.jamendo.com/v3.0/artists/locations
    /// </summary>
    [JsonObject]
    public sealed class LocationsArtist : BasicArtist
    {
        /// <summary>
        /// Gets the artist's locations.
        /// </summary>
        [JsonProperty(PropertyName = "locations", Required = Required.Always)]
        public Location[] Locations { get; private set; }

        /// <summary>
        /// Represents the location object that's part of the artist result.
        /// </summary>
        [JsonObject]
        public sealed class Location
        {
            /// <summary>
            /// Gets the city that the location is for.
            /// </summary>
            [JsonProperty(PropertyName = "city", Required = Required.Always)]
            public string City { get; private set; }

            /// <summary>
            /// Gets the three letter code of the country that the location is in.
            /// </summary>
            [JsonProperty(PropertyName = "country", Required = Required.Always)]
            [JsonConverter(typeof(StringEnumConverter))]
            public CountryCode Country { get; private set; }

            /// <summary>
            /// Gets the location's Id.
            /// </summary>
            [JsonProperty(PropertyName = "id", Required = Required.Always)]
            public uint Id { get; private set; }

            /// <summary>
            /// Gets the location's latitude.
            /// </summary>
            [JsonProperty(PropertyName = "latitude", Required = Required.Always)]
            public float Latitude { get; private set; }

            /// <summary>
            /// Gets the location's longitude.
            /// </summary>
            [JsonProperty(PropertyName = "longitude", Required = Required.Always)]
            public float Longitude { get; private set; }

            /// <summary>
            /// Lists the possible values for the country field.
            /// </summary>
            public enum CountryCode
            {
                AFG,
                ALB,
                DZA,
                UMI,
                ASM,
                VIR,
                AND,
                AGO,
                AIA,
                ATA,
                ATG,
                ARG,
                ARM,
                ABW,
                ASC,
                AZE,
                AUS,
                BHS,
                BHR,
                BGD,
                BRB,
                BLR,
                BEL,
                BLZ,
                BEN,
                BMU,
                BTN,
                BOL,
                BIH,
                BWA,
                BVT,
                BRA,
                VGB,
                IOT,
                BRN,
                BGR,
                BFA,
                BDI,
                CHL,
                CHN,
                CPT,
                COK,
                CRI,
                CUW,
                CIV,
                PRK,
                DEU,
                DGA,
                DMA,
                DOM,
                DJI,
                DNK,
                ECU,
                SLV,
                ERI,
                EST,
                FLK,
                FJI,
                FIN,
                FRA,
                GUF,
                PYF,
                ATF,
                FRO,
                GAB,
                GMB,
                GEO,
                GHA,
                GIB,
                GRD,
                GRC,
                GRL,
                GLP,
                GUM,
                GTM,
                GGY,
                GIN,
                GNB,
                GUY,
                HTI,
                HMD,
                HND,
                IND,
                IDN,
                IRQ,
                IRN,
                IRL,
                ISL,
                IMN,
                ISR,
                ITA,
                JAM,
                JPN,
                YEM,
                JEY,
                JOR,
                CYM,
                KHM,
                CMR,
                CAN,
                CPV,
                BES,
                KAZ,
                QAT,
                KEN,
                KGZ,
                KIR,
                CCK,
                COL,
                COM,
                COG,
                COD,
                XKK,
                HRV,
                CUB,
                KWT,
                LAO,
                LSO,
                LVA,
                LBN,
                LBR,
                LBY,
                LIE,
                LTU,
                LUX,
                MDG,
                MWI,
                MYS,
                MDV,
                MLI,
                MLT,
                MAR,
                MHL,
                MTQ,
                MRT,
                MUS,
                MYT,
                MKD,
                MEX,
                FSM,
                MCO,
                MNG,
                MNE,
                MSR,
                MOZ,
                MMR,
                NAM,
                NRU,
                NPL,
                NCL,
                NZL,
                NIC,
                NLD,
                ANT,
                NER,
                NGA,
                NIU,
                NFK,
                NOR,
                MNP,
                OMN,
                PAK,
                PLW,
                PSE,
                PAN,
                PNG,
                PRY,
                PER,
                PHL,
                PCN,
                POL,
                PRT,
                PRI,
                KOR,
                MDA,
                RWA,
                ROU,
                RUS,
                REU,
                SLB,
                ZMB,
                WSM,
                SMR,
                SAU,
                SWE,
                CHE,
                SEN,
                SRB,
                SYC,
                SLE,
                ZWE,
                SGP,
                SXM,
                SVK,
                SVN,
                SOM,
                HKG,
                MAC,
                ESP,
                LKA,
                BLM,
                SHN,
                KNA,
                LCA,
                MAF,
                SPM,
                VCT,
                SDN,
                SUR,
                SJM,
                SWZ,
                SYR,
                STP,
                ZAF,
                SGS,
                SSD,
                TJK,
                TWN,
                TZA,
                THA,
                TLS,
                TGO,
                TKL,
                TON,
                TTO,
                TAA,
                TCD,
                CZE,
                TUN,
                TKM,
                TCA,
                TUV,
                TUR,
                UGA,
                UKR,
                HUN,
                URY,
                UZB,
                VUT,
                VAT,
                VEN,
                ARE,
                USA,
                GBR,
                VNM,
                WLF,
                CXR,
                ESH,
                CAF,
                CYP,
                EGY,
                GNQ,
                ETH,
                ALA,
                AUT
            }
        }
    }
}
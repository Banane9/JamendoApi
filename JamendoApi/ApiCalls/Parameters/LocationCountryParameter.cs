using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the location_country parameter which is present in calls relating to locations.
    /// </summary>
    public sealed class LocationCountryParameter : Parameter<LocationCountryParameter, LocationCountryParameter.Country>
    {
        public override string Name
        {
            get { return "location_country"; }
        }

        public LocationCountryParameter()
            : base(default(Country))
        { }

        public LocationCountryParameter(Country country)
            : base(country)
        { }

        /// <summary>
        /// Lists all the possible values for the country.
        /// </summary>
        public enum Country
        {
            /// <summary>
            /// Aruba
            /// </summary>
            ABW,

            /// <summary>
            /// Afghanistan
            /// </summary>
            AFG,

            /// <summary>
            /// Angola
            /// </summary>
            AGO,

            /// <summary>
            /// Anguilla
            /// </summary>
            AIA,

            /// <summary>
            /// Åland Islands
            /// </summary>
            ALA,

            /// <summary>
            /// Albania
            /// </summary>
            ALB,

            /// <summary>
            /// Andorra
            /// </summary>
            AND,

            /// <summary>
            /// United Arab Emirates
            /// </summary>
            ARE,

            /// <summary>
            /// Argentina
            /// </summary>
            ARG,

            /// <summary>
            /// Armenia
            /// </summary>
            ARM,

            /// <summary>
            /// American Samoa
            /// </summary>
            ASM,

            /// <summary>
            /// Antarctica
            /// </summary>
            ATA,

            /// <summary>
            /// French Southern Territories
            /// </summary>
            ATF,

            /// <summary>
            /// Antigua and Barbuda
            /// </summary>
            ATG,

            /// <summary>
            /// Australia
            /// </summary>
            AUS,

            /// <summary>
            /// Austria
            /// </summary>
            AUT,

            /// <summary>
            /// Azerbaijan
            /// </summary>
            AZE,

            /// <summary>
            /// Burundi
            /// </summary>
            BDI,

            /// <summary>
            /// Belgium
            /// </summary>
            BEL,

            /// <summary>
            /// Benin
            /// </summary>
            BEN,

            /// <summary>
            /// Bonaire, Sint Eustatius and Saba
            /// </summary>
            BES,

            /// <summary>
            /// Burkina Faso
            /// </summary>
            BFA,

            /// <summary>
            /// Bangladesh
            /// </summary>
            BGD,

            /// <summary>
            /// Bulgaria
            /// </summary>
            BGR,

            /// <summary>
            /// Bahrain
            /// </summary>
            BHR,

            /// <summary>
            /// Bahamas
            /// </summary>
            BHS,

            /// <summary>
            /// Bosnia and Herzegovina
            /// </summary>
            BIH,

            /// <summary>
            /// Saint Barthélemy
            /// </summary>
            BLM,

            /// <summary>
            /// Belarus
            /// </summary>
            BLR,

            /// <summary>
            /// Belize
            /// </summary>
            BLZ,

            /// <summary>
            /// Bermuda
            /// </summary>
            BMU,

            /// <summary>
            /// Bolivia, Plurinational State of
            /// </summary>
            BOL,

            /// <summary>
            /// Brazil
            /// </summary>
            BRA,

            /// <summary>
            /// Barbados
            /// </summary>
            BRB,

            /// <summary>
            /// Brunei Darussalam
            /// </summary>
            BRN,

            /// <summary>
            /// Bhutan
            /// </summary>
            BTN,

            /// <summary>
            /// Bouvet Island
            /// </summary>
            BVT,

            /// <summary>
            /// Botswana
            /// </summary>
            BWA,

            /// <summary>
            /// Central African Republic
            /// </summary>
            CAF,

            /// <summary>
            /// Canada
            /// </summary>
            CAN,

            /// <summary>
            /// Cocos (Keeling) Islands
            /// </summary>
            CCK,

            /// <summary>
            /// Switzerland
            /// </summary>
            CHE,

            /// <summary>
            /// Chile
            /// </summary>
            CHL,

            /// <summary>
            /// China
            /// </summary>
            CHN,

            /// <summary>
            /// Côte d'Ivoire
            /// </summary>
            CIV,

            /// <summary>
            /// Cameroon
            /// </summary>
            CMR,

            /// <summary>
            /// Congo, the Democratic Republic of the
            /// </summary>
            COD,

            /// <summary>
            /// Congo
            /// </summary>
            COG,

            /// <summary>
            /// Cook Islands
            /// </summary>
            COK,

            /// <summary>
            /// Colombia
            /// </summary>
            COL,

            /// <summary>
            /// Comoros
            /// </summary>
            COM,

            /// <summary>
            /// Cabo Verde
            /// </summary>
            CPV,

            /// <summary>
            /// Costa Rica
            /// </summary>
            CRI,

            /// <summary>
            /// Cuba
            /// </summary>
            CUB,

            /// <summary>
            /// Curaçao
            /// </summary>
            CUW,

            /// <summary>
            /// Christmas Island
            /// </summary>
            CXR,

            /// <summary>
            /// Cayman Islands
            /// </summary>
            CYM,

            /// <summary>
            /// Cyprus
            /// </summary>
            CYP,

            /// <summary>
            /// Czech Republic
            /// </summary>
            CZE,

            /// <summary>
            /// Germany
            /// </summary>
            DEU,

            /// <summary>
            /// Djibouti
            /// </summary>
            DJI,

            /// <summary>
            /// Dominica
            /// </summary>
            DMA,

            /// <summary>
            /// Denmark
            /// </summary>
            DNK,

            /// <summary>
            /// Dominican Republic
            /// </summary>
            DOM,

            /// <summary>
            /// Algeria
            /// </summary>
            DZA,

            /// <summary>
            /// Ecuador
            /// </summary>
            ECU,

            /// <summary>
            /// Egypt
            /// </summary>
            EGY,

            /// <summary>
            /// Eritrea
            /// </summary>
            ERI,

            /// <summary>
            /// Western Sahara
            /// </summary>
            ESH,

            /// <summary>
            /// Spain
            /// </summary>
            ESP,

            /// <summary>
            /// Estonia
            /// </summary>
            EST,

            /// <summary>
            /// Ethiopia
            /// </summary>
            ETH,

            /// <summary>
            /// Finland
            /// </summary>
            FIN,

            /// <summary>
            /// Fiji
            /// </summary>
            FJI,

            /// <summary>
            /// Falkland Islands (Malvinas)
            /// </summary>
            FLK,

            /// <summary>
            /// France
            /// </summary>
            FRA,

            /// <summary>
            /// Faroe Islands
            /// </summary>
            FRO,

            /// <summary>
            /// Micronesia, Federated States of
            /// </summary>
            FSM,

            /// <summary>
            /// Gabon
            /// </summary>
            GAB,

            /// <summary>
            /// United Kingdom
            /// </summary>
            GBR,

            /// <summary>
            /// Georgia
            /// </summary>
            GEO,

            /// <summary>
            /// Guernsey
            /// </summary>
            GGY,

            /// <summary>
            /// Ghana
            /// </summary>
            GHA,

            /// <summary>
            /// Gibraltar
            /// </summary>
            GIB,

            /// <summary>
            /// Guinea
            /// </summary>
            GIN,

            /// <summary>
            /// Guadeloupe
            /// </summary>
            GLP,

            /// <summary>
            /// Gambia
            /// </summary>
            GMB,

            /// <summary>
            /// Guinea-Bissau
            /// </summary>
            GNB,

            /// <summary>
            /// Equatorial Guinea
            /// </summary>
            GNQ,

            /// <summary>
            /// Greece
            /// </summary>
            GRC,

            /// <summary>
            /// Grenada
            /// </summary>
            GRD,

            /// <summary>
            /// Greenland
            /// </summary>
            GRL,

            /// <summary>
            /// Guatemala
            /// </summary>
            GTM,

            /// <summary>
            /// French Guiana
            /// </summary>
            GUF,

            /// <summary>
            /// Guam
            /// </summary>
            GUM,

            /// <summary>
            /// Guyana
            /// </summary>
            GUY,

            /// <summary>
            /// Hong Kong
            /// </summary>
            HKG,

            /// <summary>
            /// Heard Island and McDonald Islands
            /// </summary>
            HMD,

            /// <summary>
            /// Honduras
            /// </summary>
            HND,

            /// <summary>
            /// Croatia
            /// </summary>
            HRV,

            /// <summary>
            /// Haiti
            /// </summary>
            HTI,

            /// <summary>
            /// Hungary
            /// </summary>
            HUN,

            /// <summary>
            /// Indonesia
            /// </summary>
            IDN,

            /// <summary>
            /// Isle of Man
            /// </summary>
            IMN,

            /// <summary>
            /// India
            /// </summary>
            IND,

            /// <summary>
            /// British Indian Ocean Territory
            /// </summary>
            IOT,

            /// <summary>
            /// Ireland
            /// </summary>
            IRL,

            /// <summary>
            /// Iran, Islamic Republic of
            /// </summary>
            IRN,

            /// <summary>
            /// Iraq
            /// </summary>
            IRQ,

            /// <summary>
            /// Iceland
            /// </summary>
            ISL,

            /// <summary>
            /// Israel
            /// </summary>
            ISR,

            /// <summary>
            /// Italy
            /// </summary>
            ITA,

            /// <summary>
            /// Jamaica
            /// </summary>
            JAM,

            /// <summary>
            /// Jersey
            /// </summary>
            JEY,

            /// <summary>
            /// Jordan
            /// </summary>
            JOR,

            /// <summary>
            /// Japan
            /// </summary>
            JPN,

            /// <summary>
            /// Kazakhstan
            /// </summary>
            KAZ,

            /// <summary>
            /// Kenya
            /// </summary>
            KEN,

            /// <summary>
            /// Kyrgyzstan
            /// </summary>
            KGZ,

            /// <summary>
            /// Cambodia
            /// </summary>
            KHM,

            /// <summary>
            /// Kiribati
            /// </summary>
            KIR,

            /// <summary>
            /// Saint Kitts and Nevis
            /// </summary>
            KNA,

            /// <summary>
            /// Korea, Republic of
            /// </summary>
            KOR,

            /// <summary>
            /// Kuwait
            /// </summary>
            KWT,

            /// <summary>
            /// Lao People's Democratic Republic
            /// </summary>
            LAO,

            /// <summary>
            /// Lebanon
            /// </summary>
            LBN,

            /// <summary>
            /// Liberia
            /// </summary>
            LBR,

            /// <summary>
            /// Libya
            /// </summary>
            LBY,

            /// <summary>
            /// Saint Lucia
            /// </summary>
            LCA,

            /// <summary>
            /// Liechtenstein
            /// </summary>
            LIE,

            /// <summary>
            /// Sri Lanka
            /// </summary>
            LKA,

            /// <summary>
            /// Lesotho
            /// </summary>
            LSO,

            /// <summary>
            /// Lithuania
            /// </summary>
            LTU,

            /// <summary>
            /// Luxembourg
            /// </summary>
            LUX,

            /// <summary>
            /// Latvia
            /// </summary>
            LVA,

            /// <summary>
            /// Macao
            /// </summary>
            MAC,

            /// <summary>
            /// Saint Martin (French part)
            /// </summary>
            MAF,

            /// <summary>
            /// Morocco
            /// </summary>
            MAR,

            /// <summary>
            /// Monaco
            /// </summary>
            MCO,

            /// <summary>
            /// Moldova, Republic of
            /// </summary>
            MDA,

            /// <summary>
            /// Madagascar
            /// </summary>
            MDG,

            /// <summary>
            /// Maldives
            /// </summary>
            MDV,

            /// <summary>
            /// Mexico
            /// </summary>
            MEX,

            /// <summary>
            /// Marshall Islands
            /// </summary>
            MHL,

            /// <summary>
            /// Macedonia, the former Yugoslav Republic of
            /// </summary>
            MKD,

            /// <summary>
            /// Mali
            /// </summary>
            MLI,

            /// <summary>
            /// Malta
            /// </summary>
            MLT,

            /// <summary>
            /// Myanmar
            /// </summary>
            MMR,

            /// <summary>
            /// Montenegro
            /// </summary>
            MNE,

            /// <summary>
            /// Mongolia
            /// </summary>
            MNG,

            /// <summary>
            /// Northern Mariana Islands
            /// </summary>
            MNP,

            /// <summary>
            /// Mozambique
            /// </summary>
            MOZ,

            /// <summary>
            /// Mauritania
            /// </summary>
            MRT,

            /// <summary>
            /// Montserrat
            /// </summary>
            MSR,

            /// <summary>
            /// Martinique
            /// </summary>
            MTQ,

            /// <summary>
            /// Mauritius
            /// </summary>
            MUS,

            /// <summary>
            /// Malawi
            /// </summary>
            MWI,

            /// <summary>
            /// Malaysia
            /// </summary>
            MYS,

            /// <summary>
            /// Mayotte
            /// </summary>
            MYT,

            /// <summary>
            /// Namibia
            /// </summary>
            NAM,

            /// <summary>
            /// New Caledonia
            /// </summary>
            NCL,

            /// <summary>
            /// Niger
            /// </summary>
            NER,

            /// <summary>
            /// Norfolk Island
            /// </summary>
            NFK,

            /// <summary>
            /// Nigeria
            /// </summary>
            NGA,

            /// <summary>
            /// Nicaragua
            /// </summary>
            NIC,

            /// <summary>
            /// Niue
            /// </summary>
            NIU,

            /// <summary>
            /// Netherlands
            /// </summary>
            NLD,

            /// <summary>
            /// Norway
            /// </summary>
            NOR,

            /// <summary>
            /// Nepal
            /// </summary>
            NPL,

            /// <summary>
            /// Nauru
            /// </summary>
            NRU,

            /// <summary>
            /// New Zealand
            /// </summary>
            NZL,

            /// <summary>
            /// Oman
            /// </summary>
            OMN,

            /// <summary>
            /// Pakistan
            /// </summary>
            PAK,

            /// <summary>
            /// Panama
            /// </summary>
            PAN,

            /// <summary>
            /// Pitcairn
            /// </summary>
            PCN,

            /// <summary>
            /// Peru
            /// </summary>
            PER,

            /// <summary>
            /// Philippines
            /// </summary>
            PHL,

            /// <summary>
            /// Palau
            /// </summary>
            PLW,

            /// <summary>
            /// Papua New Guinea
            /// </summary>
            PNG,

            /// <summary>
            /// Poland
            /// </summary>
            POL,

            /// <summary>
            /// Puerto Rico
            /// </summary>
            PRI,

            /// <summary>
            /// Korea, Democratic People's Republic of
            /// </summary>
            PRK,

            /// <summary>
            /// Portugal
            /// </summary>
            PRT,

            /// <summary>
            /// Paraguay
            /// </summary>
            PRY,

            /// <summary>
            /// Palestine, State of
            /// </summary>
            PSE,

            /// <summary>
            /// French Polynesia
            /// </summary>
            PYF,

            /// <summary>
            /// Qatar
            /// </summary>
            QAT,

            /// <summary>
            /// Réunion
            /// </summary>
            REU,

            /// <summary>
            /// Romania
            /// </summary>
            ROU,

            /// <summary>
            /// Russian Federation
            /// </summary>
            RUS,

            /// <summary>
            /// Rwanda
            /// </summary>
            RWA,

            /// <summary>
            /// Saudi Arabia
            /// </summary>
            SAU,

            /// <summary>
            /// Sudan
            /// </summary>
            SDN,

            /// <summary>
            /// Senegal
            /// </summary>
            SEN,

            /// <summary>
            /// Singapore
            /// </summary>
            SGP,

            /// <summary>
            /// South Georgia and the South Sandwich Islands
            /// </summary>
            SGS,

            /// <summary>
            /// Saint Helena, Ascension and Tristan da Cunha
            /// </summary>
            SHN,

            /// <summary>
            /// Svalbard and Jan Mayen
            /// </summary>
            SJM,

            /// <summary>
            /// Solomon Islands
            /// </summary>
            SLB,

            /// <summary>
            /// Sierra Leone
            /// </summary>
            SLE,

            /// <summary>
            /// El Salvador
            /// </summary>
            SLV,

            /// <summary>
            /// San Marino
            /// </summary>
            SMR,

            /// <summary>
            /// Somalia
            /// </summary>
            SOM,

            /// <summary>
            /// Saint Pierre and Miquelon
            /// </summary>
            SPM,

            /// <summary>
            /// Serbia
            /// </summary>
            SRB,

            /// <summary>
            /// South Sudan
            /// </summary>
            SSD,

            /// <summary>
            /// Sao Tome and Principe
            /// </summary>
            STP,

            /// <summary>
            /// Suriname
            /// </summary>
            SUR,

            /// <summary>
            /// Slovakia
            /// </summary>
            SVK,

            /// <summary>
            /// Slovenia
            /// </summary>
            SVN,

            /// <summary>
            /// Sweden
            /// </summary>
            SWE,

            /// <summary>
            /// Swaziland
            /// </summary>
            SWZ,

            /// <summary>
            /// Sint Maarten (Dutch part)
            /// </summary>
            SXM,

            /// <summary>
            /// Seychelles
            /// </summary>
            SYC,

            /// <summary>
            /// Syrian Arab Republic
            /// </summary>
            SYR,

            /// <summary>
            /// Turks and Caicos Islands
            /// </summary>
            TCA,

            /// <summary>
            /// Chad
            /// </summary>
            TCD,

            /// <summary>
            /// Togo
            /// </summary>
            TGO,

            /// <summary>
            /// Thailand
            /// </summary>
            THA,

            /// <summary>
            /// Tajikistan
            /// </summary>
            TJK,

            /// <summary>
            /// Tokelau
            /// </summary>
            TKL,

            /// <summary>
            /// Turkmenistan
            /// </summary>
            TKM,

            /// <summary>
            /// Timor-Leste
            /// </summary>
            TLS,

            /// <summary>
            /// Tonga
            /// </summary>
            TON,

            /// <summary>
            /// Trinidad and Tobago
            /// </summary>
            TTO,

            /// <summary>
            /// Tunisia
            /// </summary>
            TUN,

            /// <summary>
            /// Turkey
            /// </summary>
            TUR,

            /// <summary>
            /// Tuvalu
            /// </summary>
            TUV,

            /// <summary>
            /// Taiwan, Province of China
            /// </summary>
            TWN,

            /// <summary>
            /// Tanzania, United Republic of
            /// </summary>
            TZA,

            /// <summary>
            /// Uganda
            /// </summary>
            UGA,

            /// <summary>
            /// Ukraine
            /// </summary>
            UKR,

            /// <summary>
            /// United States Minor Outlying Islands
            /// </summary>
            UMI,

            /// <summary>
            /// Uruguay
            /// </summary>
            URY,

            /// <summary>
            /// United States of America
            /// </summary>
            USA,

            /// <summary>
            /// Uzbekistan
            /// </summary>
            UZB,

            /// <summary>
            /// Holy See (Vatican City State)
            /// </summary>
            VAT,

            /// <summary>
            /// Saint Vincent and the Grenadines
            /// </summary>
            VCT,

            /// <summary>
            /// Venezuela, Bolivarian Republic of
            /// </summary>
            VEN,

            /// <summary>
            /// Virgin Islands, British
            /// </summary>
            VGB,

            /// <summary>
            /// Virgin Islands, U.S.
            /// </summary>
            VIR,

            /// <summary>
            /// Viet Nam
            /// </summary>
            VNM,

            /// <summary>
            /// Vanuatu
            /// </summary>
            VUT,

            /// <summary>
            /// Wallis and Futuna
            /// </summary>
            WLF,

            /// <summary>
            /// Samoa
            /// </summary>
            WSM,

            /// <summary>
            /// Yemen
            /// </summary>
            YEM,

            /// <summary>
            /// South Africa
            /// </summary>
            ZAF,

            /// <summary>
            /// Zambia
            /// </summary>
            ZMB,

            /// <summary>
            /// Zimbabwe
            /// </summary>
            ZWE
        }
    }
}
//using System.ComponentModel;

//namespace TMDb.Client
//{
//    public enum OriginCountry
//    {
//        [Description("Andorra")]
//        AD,
//        [Description("United Arab Emirates")]
//        AE,
//        [Description("Afghanistan")]
//        AF,
//        [Description("Antigua and Barbuda")]
//        AG,
//        [Description("Anguilla")]
//        AI,
//        [Description("Albania")]
//        AL,
//        [Description("Armenia")]
//        AM,
//        [Description("Netherlands Antilles")]
//        AN,
//        [Description("Angola")]
//        AO,
//        [Description("Antarctica")]
//        AQ,
//        [Description("Argentina")]
//        AR,
//        [Description("American Samoa")]
//        AS,
//        [Description("Austria")]
//        AT,
//        [Description("Australia")]
//        AU,
//        [Description("Aruba")]
//        AW,
//        [Description("Azerbaijan")]
//        AZ,
//        [Description("Bosnia and Herzegovina")]
//        BA,
//        [Description("Barbados")]
//        BB,
//        [Description("Bangladesh")]
//        BD,
//        [Description("Belgium")]
//        BE,
//        [Description("Burkina Faso")]
//        BF,
//        [Description("Bulgaria")]
//        BG,
//        [Description("Bahrain")]
//        BH,
//        [Description("Burundi")]
//        BI,
//        [Description("Benin")]
//        BJ,
//        [Description("Bermuda")]
//        BM,
//        [Description("Brunei Darussalam")]
//        BN,
//        [Description("Bolivia")]
//        BO,
//        [Description("Brazil")]
//        BR,
//        [Description("Bahamas")]
//        BS,
//        [Description("Bhutan")]
//        BT,
//        [Description("Bouvet Island")]
//        BV,
//        [Description("Botswana")]
//        BW,
//        [Description("Belize")]
//        BZ,
//        [Description("Belarus")]
//        BY,
//        [Description("Canada")]
//        CA,
//        [Description("Cocos Islands")]
//        CC,
//        [Description("Congo")]
//        CD,
//        [Description("Central African Republic")]
//        CF,
//        [Description("Congo")]
//        CG,
//        [Description("Switzerland")]
//        CH,
//        [Description("Cote D'Ivoire")]
//        CI,
//        [Description("Cook Islands")]
//        CK,
//        [Description("Chile")]
//        CL,
//        [Description("Cameroon")]
//        CM,
//        [Description("China")]
//        CN,
//        [Description("Colombia")]
//        CO,
//        [Description("Costa Rica")]
//        CR,
//        [Description("Serbia and Montenegro")]
//        CS,
//        [Description("Cuba")]
//        CU,
//        [Description("Cape Verde")]
//        CV,
//        [Description("Christmas Island")]
//        CX,
//        [Description("Cyprus")]
//        CY,
//        [Description("Czech Republic")]
//        CZ,
//        [Description("Germany")]
//        DE,
//        [Description("Djibouti")]
//        DJ,
//        [Description("Denmark")]
//        DK,
//        [Description("Dominica")]
//        DM,
//        [Description("Dominican Republic")]
//        DO,
//        [Description("Algeria")]
//        DZ,
//        [Description("Ecuador")]
//        EC,
//        [Description("Estonia")]
//        EE,
//        [Description("Egypt")]
//        EG,
//        [Description("Western Sahara")]
//        EH,
//        [Description("Eritrea")]
//        ER,
//        [Description("Spain")]
//        ES,
//        [Description("Ethiopia")]
//        ET,
//        [Description("Finland")]
//        FI,
//        [Description("Fiji")]
//        FJ,
//        [Description("Falkland Islands")]
//        FK,
//        [Description("Serbia")]
//        RS,
//        [Description("Micronesia")]
//        FM,
//        [Description("Faeroe Islands")]
//        FO,
//        [Description("France")]
//        FR,
//        [Description("Gabon")]
//        GA,
//        [Description("United Kingdom")]
//        GB,
//        [Description("Grenada")]
//        GD,
//        [Description("Georgia")]
//        GE,
//        [Description("French Guiana")]
//        GF,
//        [Description("Ghana")]
//        GH,
//        [Description("Gibraltar")]
//        GI,
//        [Description("Greenland")]
//        GL,
//        [Description("Gambia")]
//        GM,
//        [Description("Guinea")]
//        GN,
//        [Description("Guadaloupe")]
//        GP,
//        [Description("Equatorial Guinea")]
//        GQ,
//        [Description("Greece")]
//        GR,
//        [Description("South Georgia and the South Sandwich Islands")]
//        GS,
//        [Description("Guatemala")]
//        GT,
//        [Description("Guam")]
//        GU,
//        [Description("Guinea-Bissau")]
//        GW,
//        [Description("Guyana")]
//        GY,
//        [Description("Hong Kong")]
//        HK,
//        [Description("Heard and McDonald Islands")]
//        HM,
//        [Description("Honduras")]
//        HN,
//        [Description("Croatia")]
//        HR,
//        [Description("Haiti")]
//        HT,
//        [Description("Hungary")]
//        HU,
//        [Description("Indonesia")]
//        ID,
//        [Description("Ireland")]
//        IE,
//        [Description("Israel")]
//        IL,
//        [Description("India")]
//        IN,
//        [Description("British Indian Ocean Territory")]
//        IO,
//        [Description("Iraq")]
//        IQ,
//        [Description("Iran")]
//        IR,
//        [Description("Iceland")]
//        IS,
//        [Description("Italy")]
//        IT,
//        [Description("Jamaica")]
//        JM,
//        [Description("Jordan")]
//        JO,
//        [Description("Japan")]
//        JP,
//        [Description("Kenya")]
//        KE,
//        [Description("Kyrgyz Republic")]
//        KG,
//        [Description("Cambodia")]
//        KH,
//        [Description("Kiribati")]
//        KI,
//        [Description("Comoros")]
//        KM,
//        [Description("St. Kitts and Nevis")]
//        KN,
//        [Description("North Korea")]
//        KP,
//        [Description("Kuwait")]
//        KW,
//        [Description("Cayman Islands")]
//        KY,
//        [Description("Kazakhstan")]
//        KZ,
//        [Description("Lao People's Democratic Republic")]
//        LA,
//        [Description("Lebanon")]
//        LB,
//        [Description("St. Lucia")]
//        LC,
//        [Description("Liechtenstein")]
//        LI,
//        [Description("Sri Lanka")]
//        LK,
//        [Description("Liberia")]
//        LR,
//        [Description("Lesotho")]
//        LS,
//        [Description("Lithuania")]
//        LT,
//        [Description("Luxembourg")]
//        LU,
//        [Description("Latvia")]
//        LV,
//        [Description("Libyan Arab Jamahiriya")]
//        LY,
//        [Description("Morocco")]
//        MA,
//        [Description("Monaco")]
//        MC,
//        [Description("Moldova")]
//        MD,
//        [Description("Madagascar")]
//        MG,
//        [Description("Marshall Islands")]
//        MH,
//        [Description("Macedonia")]
//        MK,
//        [Description("Mali")]
//        ML,
//        [Description("Myanmar")]
//        MM,
//        [Description("Mongolia")]
//        MN,
//        [Description("Macao")]
//        MO,
//        [Description("Northern Mariana Islands")]
//        MP,
//        [Description("Martinique")]
//        MQ,
//        [Description("Mauritania")]
//        MR,
//        [Description("Montserrat")]
//        MS,
//        [Description("Malta")]
//        MT,
//        [Description("Mauritius")]
//        MU,
//        [Description("Maldives")]
//        MV,
//        [Description("Malawi")]
//        MW,
//        [Description("Mexico")]
//        MX,
//        [Description("Malaysia")]
//        MY,
//        [Description("Mozambique")]
//        MZ,
//        [Description("Namibia")]
//        NA,
//        [Description("New Caledonia")]
//        NC,
//        [Description("Niger")]
//        NE,
//        [Description("Norfolk Island")]
//        NF,
//        [Description("Nigeria")]
//        NG,
//        [Description("Montenegro")]
//        ME,
//        [Description("Nicaragua")]
//        NI,
//        [Description("Netherlands")]
//        NL,
//        [Description("Norway")]
//        NO,
//        [Description("Nepal")]
//        NP,
//        [Description("Nauru")]
//        NR,
//        [Description("Niue")]
//        NU,
//        [Description("New Zealand")]
//        NZ,
//        [Description("Oman")]
//        OM,
//        [Description("Panama")]
//        PA,
//        [Description("Peru")]
//        PE,
//        [Description("French Polynesia")]
//        PF,
//        [Description("Papua New Guinea")]
//        PG,
//        [Description("Philippines")]
//        PH,
//        [Description("Yugoslavia")]
//        YU,
//        [Description("Kosovo")]
//        XK,
//        [Description("Czechoslovakia")]
//        XC,
//        [Description("Pakistan")]
//        PK,
//        [Description("Poland")]
//        PL,
//        [Description("St. Pierre and Miquelon")]
//        PM,
//        [Description("Pitcairn Island")]
//        PN,
//        [Description("Puerto Rico")]
//        PR,
//        [Description("Palestinian Territory")]
//        PS,
//        [Description("Portugal")]
//        PT,
//        [Description("Palau")]
//        PW,
//        [Description("Paraguay")]
//        PY,
//        [Description("Qatar")]
//        QA,
//        [Description("Reunion")]
//        RE,
//        [Description("Romania")]
//        RO,
//        [Description("Russia")]
//        RU,
//        [Description("Rwanda")]
//        RW,
//        [Description("Saudi Arabia")]
//        SA,
//        [Description("Solomon Islands")]
//        SB,
//        [Description("Seychelles")]
//        SC,
//        [Description("Sudan")]
//        SD,
//        [Description("Sweden")]
//        SE,
//        [Description("Singapore")]
//        SG,
//        [Description("St. Helena")]
//        SH,
//        [Description("Slovenia")]
//        SI,
//        [Description("Svalbard & Jan Mayen Islands")]
//        SJ,
//        [Description("Slovakia")]
//        SK,
//        [Description("Sierra Leone")]
//        SL,
//        [Description("San Marino")]
//        SM,
//        [Description("Senegal")]
//        SN,
//        [Description("Somalia")]
//        SO,
//        [Description("Suriname")]
//        SR,
//        [Description("Sao Tome and Principe")]
//        ST,
//        [Description("El Salvador")]
//        SV,
//        [Description("Syrian Arab Republic")]
//        SY,
//        [Description("Swaziland")]
//        SZ,
//        [Description("Turks and Caicos Islands")]
//        TC,
//        [Description("Chad")]
//        TD,
//        [Description("French Southern Territories")]
//        TF,
//        [Description("Togo")]
//        TG,
//        [Description("Thailand")]
//        TH,
//        [Description("Tajikistan")]
//        TJ,
//        [Description("Tokelau")]
//        TK,
//        [Description("Timor-Leste")]
//        TL,
//        [Description("Turkmenistan")]
//        TM,
//        [Description("Tunisia")]
//        TN,
//        [Description("Tonga")]
//        TO,
//        [Description("Turkey")]
//        TR,
//        [Description("Trinidad and Tobago")]
//        TT,
//        [Description("Tuvalu")]
//        TV,
//        [Description("Taiwan")]
//        TW,
//        [Description("Tanzania")]
//        TZ,
//        [Description("Ukraine")]
//        UA,
//        [Description("Uganda")]
//        UG,
//        [Description("United States Minor Outlying Islands")]
//        UM,
//        [Description("United States of America")]
//        US,
//        [Description("Uruguay")]
//        UY,
//        [Description("Uzbekistan")]
//        UZ,
//        [Description("Holy See")]
//        VA,
//        [Description("St. Vincent and the Grenadines")]
//        VC,
//        [Description("Venezuela")]
//        VE,
//        [Description("British Virgin Islands")]
//        VG,
//        [Description("US Virgin Islands")]
//        VI,
//        [Description("Vietnam")]
//        VN,
//        [Description("Vanuatu")]
//        VU,
//        [Description("Wallis and Futuna Islands")]
//        WF,
//        [Description("Samoa")]
//        WS,
//        [Description("Yemen")]
//        YE,
//        [Description("Mayotte")]
//        YT,
//        [Description("South Africa")]
//        ZA,
//        [Description("Zambia")]
//        ZM,
//        [Description("Zimbabwe")]
//        ZW,
//        [Description("South Korea")]
//        KR,
//        [Description("East Germany")]
//        XG,
//        [Description("Soviet Union")]
//        SU,
//        [Description("South Sudan")]
//        SS,
//  }
//}
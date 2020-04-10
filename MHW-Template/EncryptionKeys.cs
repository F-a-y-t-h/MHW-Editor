﻿using System.Collections.Generic;

namespace MHW_Template {
    public static class EncryptionKeys {
        // ReSharper disable IdentifierTypo
        public const string PL_PARAM_KEY = "j1P15gEkgVa7NdFxiqwCPitykHctY2nZPjSaElvqb0eSwcLO1cOlTqqv"; // mParam
        public const string OWP_DAT_KEY = "FZoS8QLyOyeFmkdrz73P9Fh2N4NcTwy3QQPjc1YRII5KWovK6yFuU8SL"; // rOtomoToolLevelTbl also .shlp
        public const string DTT_EDA_KEY = "Fqkpg1xx1cMlvg3AtKOCLxFgVFBwHkCbjizBRV49hWmEe5lOAaNOTm7m"; // rEmDamageAttr
        public const string DTT_EPG_KEY = "sJV4g7d55gKnQB5nS6XJ9pZ1qZmmQwNnSbidUW1OeAhHrpPd6MKbfsrt"; // rEmPartsGroup
        public const string MSK_KEY = "qm7psvaMXQoay7kARXpNPcLNWqsbqcOyI4lqHtxFh26HSuE6RHNq7J4e"; // A bunch?
        public const string ROD_INSE_KEY = "SFghFQVFJycHnypExurPwut98ZZq1cwvm7lpDpASeP4biRhstQgULzlb"; // mMoneyItemTbl
        public const string CUS_PAR_KEY = "PCEBFfRCbwIdy6AZIoNA5lXV6FEki0yBEyW4FPXZUyWgeauqY8PYeZkM"; // rCharmData
        public const string ITLOT_KEY = "D7N88VEGEnRl0HEHTO0xMQkbeMb37arJF488lREp90WYojAONkLoxfMt"; // rItemData .itlot
        public const string ASKILLP_KEY = "Nb06gpPJ9WtbO6FF1ZYqm5NbLREsCzuqAY0G25ug2Ei5XkkAtVXD5Uda"; // rASkillData askill_param.asp
        public const string STLST_KEY = "ZduEVAgrFnd8jpnwHF2ur64BHcd37gEYDQwRbeBwMt6dGRK3tUwm2wx5"; // rSpecialTraceLotData // CommonParam00_st.stlst

        // The rest are untested and/or unused.
        public const string SAVE_FILE_KEY = "xieZjoe#P2134-3zmaghgpqoe0z8$3azeq";
        public const string UNKNOWN_KEY_3 = "b71AMFJuw63cUTlDt5ntSAtaAvwLKizNtapy4W0QAsC39QXPr6b78Asz"; // cRomPacketSysSyncStart
        public const string UNKNOWN_KEY_6 = "TZNgJfzyD2WKiuV4SglmI6oN5jP2hhRJcBwzUooyfIUTM4ptDYGjuRTP";
        // Pre Iceborn
        public const string DTT_KEY_PREIB = "hZ2H0gvUA4xIELjPoCIKefoCUFK9D77aPQvL9goKDpFbC2U2yhTRhWJG";

        public static readonly Dictionary<string, string> FILE_EXT_KEY_LOOKUP = new Dictionary<string, string> {
            {".aeq", UNKNOWN_KEY_3},
            {".asp", ASKILLP_KEY},
            {".cus_otr", CUS_PAR_KEY},
            {".cus_ou", CUS_PAR_KEY},
            {".cus_pa", CUS_PAR_KEY},
            {".cus_par", CUS_PAR_KEY},
            {".dtt_eda", DTT_EDA_KEY},
            {".dtt_epg", DTT_EPG_KEY},
            {".itlot", ITLOT_KEY},
            {".msk", MSK_KEY},
            {".mske", MSK_KEY},
            {".owp_dat", OWP_DAT_KEY},
            {".plip", PL_PARAM_KEY},
            {".plp", PL_PARAM_KEY},
            {".plsp", PL_PARAM_KEY},
            {".rod_inse", ROD_INSE_KEY},
            {".shlp", OWP_DAT_KEY},
            {".stlst", STLST_KEY},
            {".w00p", PL_PARAM_KEY},
            {".w01p", PL_PARAM_KEY},
            {".w02p", PL_PARAM_KEY},
            {".w03p", PL_PARAM_KEY},
            {".w04p", PL_PARAM_KEY},
            {".w05p", PL_PARAM_KEY},
            {".w06p", PL_PARAM_KEY},
            {".w07p", PL_PARAM_KEY},
            {".w08p", PL_PARAM_KEY},
            {".w09p", PL_PARAM_KEY},
            {".w10p", PL_PARAM_KEY},
            {".w11p", PL_PARAM_KEY},
            {".w12p", PL_PARAM_KEY},
            {".w13p", PL_PARAM_KEY}
        };
    }
}

// Shadow Race Path Decider
// Code written by Zwataketa (Logan Holt)

//using System.Collections;
using System.Collections.Generic;
//using UnityEngine;

public class PathNameSelector
{
    public Dictionary<int, string> pathStrings = new Dictionary<int, string>
        {
            {0   , "ERROR: PATH ID NOT SET"},
            {1   , "Punishment, Thy Name is Ruin"},
            {2   , "Prologue to World Conquest"},
            {3   , "The March to a Darker World"},
            {4   , "The Ultimate Ego"},
            {5   , "Purification via Ruination"},
            {6   , "Apogee of Darkness"},
            {7   , "True Soldier of Destruction"},
            {8   , "Believe in Yourself"},
            {9   , "An Android�s Determination"},
            {10  , "For Machine, By Machine..."},
            {11  , "Revenge at Last"},
            {12  , "Ego�s Awakening"},
            {13  , "Destruction and Scorn"},
            {14  , "The Last Remaining Purpose"},
            {15  , "The Nightmare�s Insulation"},
            {16  , "The Nightmare�s Sublimation"},
            {17  , "The Loner�s Choice"},
            {18  , "Subjugation in Black"},
            {19  , "Replica�s Depression"},
            {20  , "Machine, Machine"},
            {21  , "Disciple from the Darkness"},
            {22  , "Beloved Clone"},
            {23  , "Revenge Upon the Doctor"},
            {24  , "The Ultimate Replica"},
            {25  , "Sanction�s Demise"},
            {26  , "Along With My Home"},
            {27  , "The Cleansing of Darkness"},
            {28  , "Birth of a God"},
            {29  , "The Last Soldier�s Grim Fate"},
            {30  , "Isolation and Solitude"},
            {31  , "Archimedes and the Tortoise"},
            {32  , "Where Is My Happiness?"},
            {33  , "Seduced By Taste of Blood"},
            {34  , "A Machine Made for War"},
            {35  , "Original Definition"},
            {36  , "Machine Paradise"},
            {37  , "Last Will and Testament"},
            {38  , "Enveloped in Solitude"},
            {39  , "Parricidal Savior"},
            {40  , "Copy of a Savior"},
            {41  , "Excess of Intellect"},
            {42  , "Crystallization of Intellect"},
            {43  , "The Ultimate Confrontation"},
            {44  , "Miracle of Love"},
            {45  , "The World�s Demise"},
            {46  , "The Ultimate Power"},
            {47  , "Dyed in Lovely Darkness..."},
            {48  , "Vainglory or Abandonment?"},
            {49  , "Messenger of Ruination"},
            {50  , "Standing at the Summit"},
            {51  , "Controller from the Capsule"},
            {52  , "Beyond One�s Own Power..."},
            {53  , "A Clone�s Determination"},
            {54  , "Machine Utopia"},
            {55  , "A Toast to the Ruler"},
            {56  , "Answer from the Black Comet"},
            {57  , "Transcendentalism"},
            {58  , "Imperialism"},
            {59  , "The Weight of One�s Crimes"},
            {60  , "Imprisoned by the Past..."},
            {61  , "The Ultimate World Conquest"},
            {62  , "Black Angel"},
            {63  , "Under Darkness� Control"},
            {64  , "To Love Oneself"},
            {65  , "Revenge and Determination"},
            {66  , "Birth of the Robot Emperor"},
            {67  , "Shadow, the Black Android"},
            {68  , "A Solitary Android"},
            {69  , "Over the Original"},
            {70  , "Machine Sunshine"},
            {71  , "Life is Guilty"},
            {72  , "Fallen Angel of Despair"},
            {73  , "An Eternal Rival..."},
            {74  , "This is Just the Beginning"},
            {75  , "Crystal of Tragic Knowledge"},
            {76  , "Shadow�s Second Death...?"},
            {77  , "The Legend of Shadow"},
            {78  , "Power of Love"},
            {79  , "Deep Black"},
            {80  , "Walk My Way"},
            {81  , "This is Shadow�s Way of Life"},
            {82  , "A Monarch�s Style"},
            {83  , "In the Gap of Sadness"},
            {84  , "To Be Ignorant of the Past"},
            {85  , "At Vengeance�s End"},
            {86  , "Machine Boys"},
            {87  , "Reborn Along with Sorrow"},
            {88  , "With a Fate of Self-Denial"},
            {89  , "I Am Shadow"},
            {90  , "Shining Within Memory..."},
            {91  , "The Rise and Fall of The ARK"},
            {92  , "Requiem for a Fallen Angel"},
            {93  , "Ultimate Shadow"},
            {94  , "For Love�s Sake"},
            {95  , "A Heart Awoken from Darkness"},
            {96  , "Destruction From Perfection"},
            {97  , "Darkness� Strongest Soldier"},
            {98  , "Severed Chains"},
            {99  , "Retribution Against Humanity"},
            {100 , "To Be Known as �Ultimate�"},
            {101 , "Dark Warrior�s Advent"},
            {102 , "Arriving at the Ego"},
            {103 , "Determination of a Fake"},
            {104 , "Path to the Machine Empire"},
            {105 , "Demise Wrought by Tragedy"},
            {106 , "Turning Sorrow Into Strength"},
            {107 , "The Liberated Soldier"},
            {108 , "Stupefaction�s End"},
            {109 , "Humanity�s Folly"},
            {110 , "Surpassing All Else"},
            {111 , "Soldier of Grief"},
            {112 , "Reclaimed Heart"},
            {113 , "Fighting Spirit of Steel"},
            {114 , "Machine Soldier Uprising"},
            {115 , "The Devil Born From Betrayal"},
            {116 , "Beyond the Truth of Impact"},
            {117 , "The Immortal Android"},
            {118 , "The New, Coldhearted Empire"},
            {119 , "A Singular Atonement"},
            {120 , "Spawn of the Devil"},
            {121 , "Black Doom�s Scheme"},
            {122 , "Subjugating Heaven and Earth"},
            {123 , "Road of the Dark Soldier"},
            {124 , "Dark Finale"},
            {125 , "Realization While On Board"},
            {126 , "Birth of a Champion"},
            {127 , "With the Black Arms"},
            {128 , "The Road to Self-Assurance"},
            {129 , "The Pursuit of Dr. Eggman"},
            {130 , "Surpassing His Creator"},
            {131 , "ARK, Colony of Pathos"},
            {132 , "Perfection Lost to Darkness"},
            {133 , "A New Challenge"},
            {134 , "The Machines� Coup d�Etat"},
            {135 , "A Vow for the Victims"},
            {136 , "The Truth of Sadness"},
            {137 , "The Destined Sonic Showdown"},
            {138 , "The Black Hero�s Rebirth"},
            {139 , "Truth, Thy Name is Vengeance"},
            {140 , "Searching for 'Ultimate'"},
            {141 , "Reborn Hatred for Humanity"},
            {142 , "A Future Taken from the Past"},
            {143 , "The Devils' Victory Song"},
            {144 , "One to Succeed a God"},
            {145 , "Disappointed in Humanity"},
            {146 , "Faith Taken from Solitude"},
            {147 , "Planted Memories"},
            {148 , "To Unite Humanity"},
            {149 , "Isolated Soldier Shadow"},
            {150 , "Answer Derived from Truth"},
            {151 , "A Fake�s Disposition"},
            {152 , "A New World Without Betrayal"},
            {153 , "Together With Maria..."},
            {154 , "The Tragedy�s Conclusion"},
            {155 , "The Day That Hope Died"},
            {156 , "Dark Destroyer"},
            {157 , "Diabolical Power"},
            {158 , "For Freedom"},
            {159 , "At Least, Be Like Shadow..."},
            {160 , "Seeking a Silent Paradise"},
            {161 , "The Lion�s Awakening"},
            {162 , "Identity"},
            {163 , "An Android�s Rebellion"},
            {164 , "A New Empire�s Beginning"},
            {165 , "Bullets from Tears"},
            {166 , "Journey to Nihility"},
            {167 , "Shadow Surpassing Shadow"},
            {168 , "Dr. Eggman�s Miscalculation"},
            {169 , "Along With the ARK"},
            {170 , "Requiem for the Heavens"},
            {171 , "Sonic Dethroned!"},
            {172 , "Justice Reborn in Space"},
            {173 , "Steel Ruler"},
            {174 , "For the Sake of the Self"},
            {175 , "Farewell to the Past"},
            {176 , "Steel Paradise"},
            {177 , "The Guardian With No Past"},
            {178 , "The Ultimate Atonement"},
            {179 , "A Fake�s Aspiration"},
            {180 , "Machine World"},
            {181 , "Twilight Ark"},
            {182 , "Compensation for a Miracle"},
            {183 , "The Strongest Hedgehog"},
            {184 , "The Ultimate Punisher"},
            {185 , "Voyage of Reminiscence"},
            {186 , "Wandering�s End"},
            {187 , "The Ultimate Proof"},
            {188 , "Punisher of Love"},
            {189 , "Messenger from the Darkness"},
            {190 , "The New Ruler"},
            {191 , "Dark Soldier"},
            {192 , "The Road of Light"},
            {193 , "The Machine-Laden Kingdom"},
            {194 , "New Determination"},
            {195 , "Birth of the Dark Soldier"},
            {196 , "A New Journey"},
            {197 , "The Android�s Opposition"},
            {198 , "Founding of the Robot Nation"},
            {199 , "The Eternal Protector"},
            {200 , "The Sinner�s Repose"},
            {201 , "A Hero�s Resolution"},
            {202 , "The Weapons� Empire"},
            {203 , "Perpetual Voyage"},
            {204 , "A Hero�s Atonement"},
            {205 , "Dark Hegemony"},
            {206 , "And the Dream Continues"},
            {207 , "Fighter for Darkness"},
            {208 , "The Path I Believed In"},
            {209 , "Determination�s Daybreak"},
            {210 , "Machine Kingdom at Dawn"},
            {211 , "Sinful Protector"},
            {212 , "At the End of the Journey"},
            {213 , "Surmounting the Nightmare"},
            {214 , "Dawn of the Machines"},
            {215 , "Wandering for Eternity"},
            {216 , "At Vagrancy�s End"},
            {217 , "The Summit of Power"},
            {218 , "Under the Name of Love"},
            {219 , "Eternally Drifting"},
            {220 , "The Importance of Truth"},
            {221 , "The Beginning of Judgment"},
            {222 , "This World�s Guardian"},
            {223 , "Light Born from Darkness"},
            {224 , "The Order of Steel"},
            {225 , "Solitary Journey"},
            {226 , "The Fall Home"},
            {227 , "Sovereign of All Creation"},
            {228 , "I Shall Be the One to Judge"},
            {229 , "Gone With the Darkness"},
            {230 , "The Ultimate Choice"},
            {231 , "I Am the Strongest!"},
            {232 , "Justice�s Awakening"},
            {233 , "Prelude to Ruination"},
            {234 , "A World United by Darkness"},
            {235 , "The Pulse of Darkness"},
            {236 , "To Just Be Myself"},
            {237 , "Punishment in Jet Black"},
            {238 , "The Ruler�s First Cry"},
            {239 , "Darkness� Conspiracy"},
            {240 , "The Faint Light of Tomorrow"},
            {241 , "Time of Departure"},
            {242 , "Rise of the Machine Kingdom"},
            {243 , "Despair�s Quickening"},
            {244 , "The Beginning"},
            {245 , "Setting Out in the Morning"},
            {246 , "The Weapons� Dawn"},
            {247 , "Pure Ark"},
            {248 , "Making Up For It in the End"},
            {249 , "The Coming of the Dark Time"},
            {250 , "The Throne of God"},
            {251 , "God of War"},
            {252 , "Howl of Solitude"},
            {253 , "Proof of Existence"},
            {254 , "Ardent Vow"},
            {255 , "A Deal With the Devil"},
            {256 , "A Reason to Live"},
            {257 , "Induplicable Thoughts"},
            {258 , "Steel Struck With Flame"},
            {259 , "A Heart Bound to the ARK"},
            {260 , "Tears Shed by the Stars"},
            {261 , "Imitation Complex"},
            {262 , "Steel Combat Boots"},
            {263 , "Protector of the Ashen Moon"},
            {264 , "A Demon Drifting"},
            {265 , "The Ultimate Pride"},
            {266 , "I Know the Will of Heaven"},
            {267 , "Ego Dyed in Black"},
            {268 , "Isolation By Choice"},
            {269 , "Faith Without Falsehood"},
            {270 , "Machine Empire"},
            {271 , "The Eternally-Closed Door"},
            {272 , "The Sealed-Away Ark of Sin"},
            {273 , "Silver Emergence"},
            {274 , "Pulsating Supercurrent"},
            {275 , "The Reason I Was Born"},
            {276 , "The Dark Part of the Galaxy"},
            {277 , "The View From Atop the World"},
            {278 , "Maria�s Testament"},
            {279 , "A Genius Scientist�s Lineage"},
            {280 , "Distorted Truth"},
            {281 , "A Counterfeit Existence"},
            {282 , "Beloved Memories"},
            {283 , "Birth of a Devil"},
            {284 , "A Dark Myth�s Beginnings"},
            {285 , "Black Thunder"},
            {286 , "The Torn-Away Necklace"},
            {287 , "A Soul Sheltered by Iron"},
            {288 , "Steel Nation�s Decree"},
            {289 , "Coronation of Darkness"},
            {290 , "Opened Eyes"},
            {291 , "The Doctor�s Lie"},
            {292 , "The Uninvited Successor"},
            {293 , "The Closed Pandora�s Box"},
            {294 , "A Heart Bound by Sin"},
            {295 , "Courage from Turning Gears"},
            {296 , "Fullmetal Prince"},
            {297 , "Time�s Watchman"},
            {298 , "Galaxy�s Requiem"},
            {299 , "Charm of the Chaos Emeralds"},
            {300 , "Promise of a Far-Off Day"},
            {301 , "The Grim Reaper�s Horn"},
            {302 , "A Flame Extinguished by Fate"},
            {303 , "Shouting at the Morning Sun"},
            {304 , "Iron Ambition"},
            {305 , "Sleeping on Hallowed Ground"},
            {306 , "Explanation of the Truth"},
            {307 , "An Android�s Dream"},
            {308 , "Metallic Quickening"},
            {309 , "Funeral Procession in Space"},
            {310 , "Lost to the Universe�s Abyss"},
            {311 , "Destiny for Two"},
            {312 , "The Spun Threads of Fate"},
            {313 , "Ark of the Heavens"},
            {314 , "Ghost of The ARK"},
            {315 , "A Pair of Shooting Stars"},
            {316 , "The One Who Maria Entrusted"},
            {317 , "A.I.�s Enlightenment"},
            {318 , "A Dying Empire�s Cry"},
            {319 , "Moon of Atonement"},
            {320 , "Tear-Soaked Hometown"},
            {321 , "Sparks on the Horizon"},
            {322 , "A Use for a Saved Life"},
            {323 , "Coffin of Memories"},
            {324 , "The Self-Imposed Seal"},
            {325 , "Pretense in the Mirror"},
            {326 , "A Missive from 50 Years Ago"},
        };

    public int GetPathID(string pathString)
    {
        switch (pathString)
        {
            default:
                return 0;
            case "dddddd":
                return 1;
            case "dddddh":
                return 2;
            case "ddddnd":
                return 3;
            case "ddddnh":
                return 4;
            case "dddhdd":
                return 5;
            case "dddhdh":
                return 6;
            case "dddhnd":
                return 7;
            case "dddhnh":
                return 8;
            case "dddhhd":
                return 9;
            case "dddhhh":
                return 10;
            case "ddnddd":
                return 11;
            case "ddnddh":
                return 12;
            case "ddndnd":
                return 13;
            case "ddndnh":
                return 14;
            case "ddnndd":
                return 15;
            case "ddnndh":
                return 16;
            case "ddnnnd":
                return 17;
            case "ddnnnh":
                return 18;
            case "ddnnhd":
                return 19;
            case "ddnnhh":
                return 20;
            case "ddnhdd":
                return 21;
            case "ddnhdh":
                return 22;
            case "ddnhnd":
                return 23;
            case "ddnhnh":
                return 24;
            case "ddnhhd":
                return 25;
            case "ddnhhh":
                return 26;
            case "ddhddd":
                return 27;
            case "ddhddh":
                return 28;
            case "ddhdnd":
                return 29;
            case "ddhdnh":
                return 30;
            case "ddhdhd":
                return 31;
            case "ddhdhh":
                return 32;
            case "ddhndd":
                return 33;
            case "ddhndh":
                return 34;
            case "ddhnnd":
                return 35;
            case "ddhnnh":
                return 36;
            case "ddhnhd":
                return 37;
            case "ddhnhh":
                return 38;
            case "ddhhdd":
                return 39;
            case "ddhhdh":
                return 40;
            case "ddhhnd":
                return 41;
            case "ddhhnh":
                return 42;
            case "ddhhhd":
                return 43;
            case "ddhhhh":
                return 44;
            case "dhdddd":
                return 45;
            case "dhdddh":
                return 46;
            case "dhddnd":
                return 47;
            case "dhddnh":
                return 48;
            case "dhdndd":
                return 49;
            case "dhdndh":
                return 50;
            case "dhdnnd":
                return 51;
            case "dhdnnh":
                return 52;
            case "dhdnhd":
                return 53;
            case "dhdnhh":
                return 54;
            case "dhdhdd":
                return 55;
            case "dhdhdh":
                return 56;
            case "dhdhnd":
                return 57;
            case "dhdhnh":
                return 58;
            case "dhdhhd":
                return 59;
            case "dhdhhh":
                return 60;
            case "dhnddd":
                return 61;
            case "dhnddh":
                return 62;
            case "dhndnd":
                return 63;
            case "dhndnh":
                return 64;
            case "dhndhd":
                return 65;
            case "dhndhh":
                return 66;
            case "dhnndd":
                return 67;
            case "dhnndh":
                return 68;
            case "dhnnnd":
                return 69;
            case "dhnnnh":
                return 70;
            case "dhnnhd":
                return 71;
            case "dhnnhh":
                return 72;
            case "dhnhdd":
                return 73;
            case "dhnhdh":
                return 74;
            case "dhnhnd":
                return 75;
            case "dhnhnh":
                return 76;
            case "dhnhhd":
                return 77;
            case "dhnhhh":
                return 78;
            case "dhhddd":
                return 79;
            case "dhhddh":
                return 80;
            case "dhhdnd":
                return 81;
            case "dhhdnh":
                return 82;
            case "dhhdhd":
                return 83;
            case "dhhdhh":
                return 84;
            case "dhhndd":
                return 85;
            case "dhhndh":
                return 86;
            case "dhhnnd":
                return 87;
            case "dhhnnh":
                return 88;
            case "dhhnhd":
                return 89;
            case "dhhnhh":
                return 90;
            case "dhhhnd":
                return 91;
            case "dhhhnh":
                return 92;
            case "dhhhhd":
                return 93;
            case "dhhhhh":
                return 94;

            // Neutral
            case "nddddd":
                return 95;
            case "nddddh":
                return 96;
            case "ndddnd":
                return 97;
            case "ndddnh":
                return 98;
            case "nddhdd":
                return 99;
            case "nddhdh":
                return 100;
            case "nddhnd":
                return 101;
            case "nddhnh":
                return 102;
            case "nddhhd":
                return 103;
            case "nddhhh":
                return 104;

            case "nnnnnd":
                return 163;
            case "nnnnnh":
                return 164;

            // Hero
            case "hhhhhd":
                return 361;
            case "hhhhhh":
                return 326;
        }
    }
}

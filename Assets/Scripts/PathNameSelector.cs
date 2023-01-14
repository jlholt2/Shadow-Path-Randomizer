// Shadow Race Path Decider
// Code written by Zwataketa (Logan Holt)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathNameSelector : MonoBehaviour
{
    public string GetPathName(string pathString)
    {
        switch (pathString)
        {
            default:
                return "ERROR: PATH NAME NOT FOUND";
            case "dddddd":
                return "001. Punishment, Thy Name is Ruin";
            case "dddddh":
                return "002. Prologue to World Conquest";
            case "ddddnd":
                return "003. The March to a Darker World";
            case "ddddnh":
                return "004. The Ultimate Ego";
            case "dddhdd":
                return "005. Purification via Ruination";
            case "dddhdh":
                return "006. Apogee of Darkness";
            case "dddhnd":
                return "007. True Soldier of Destruction";
            case "dddhnh":
                return "008. Believe in Yourself";
            case "dddhhd":
                return "009. An Android's Determination";
            case "dddhhh":
                return "010. For Machine, By Machine...";
            case "ddnddd":
                return "011. Revenge at Last";
            case "ddnddh":
                return "012. Ego's Awakening";
            case "ddndnd":
                return "013. Destruction and Scorn";
            case "ddndnh":
                return "014. The Last Remaining Purpose";
            case "ddnndd":
                return "015. The Nightmare's Insulation";
            case "ddnndh":
                return "016. The Nightmare's Sublimination";
            case "ddnnnd":
                return "017. The Loner's Choice";
            case "ddnnnh":
                return "018. Subjugation in Black";
            case "ddnnhd":
                return "019. Replica's Depression";
            case "ddnnhh":
                return "020. Machine, Machine";
            case "ddnhdd":
                return "021. Disciple from the Darkness";
            case "ddnhdh":
                return "022. Beloved Clone";
            case "ddnhnd":
                return "023. Revenge Upon the Doctor";
            case "ddnhnh":
                return "024. The Ultimate Replica";
            case "ddnhhd":
                return "025. Sanction's Demise";
            case "ddnhhh":
                return "026. Along With My Home";
            case "ddhddd":
                return "027. The Cleansing of Darkness";
            case "ddhddh":
                return "028. Birth of a God";
            case "ddhdnd":
                return "029. The Last Soldier's Grim Fate";
            case "ddhdnh":
                return "030. Isolation and Solitude";
            case "ddhdhd":
                return "031. Archimedes and the Tortoise";
            case "ddhdhh":
                return "032. Where Is My Happiness?";
            case "ddhndd":
                return "033. Seduced By Taste of Blood";
            case "ddhndh":
                return "034. A Machine Made for War";
            case "ddhnnd":
                return "035. Original Definition";
            case "ddhnnh":
                return "036. Machine Paradise";
            case "ddhnhd":
                return "037. Last Will and Testament";
            case "ddhnhh":
                return "038. Enveloped in Solitude";
            case "ddhhdd":
                return "039. Parricidal Savior";
            case "ddhhdh":
                return "040. Copy of a Savior";
            case "ddhhnd":
                return "041. Excess of Intellect";
            case "ddhhnh":
                return "042. Crystallization of Intellect";
            case "ddhhhd":
                return "043. The Ultimate Confrontation";
            case "ddhhhh":
                return "044. Miracle of Love";
            case "dhdddd":
                return "045. The World's Demise";
            case "dhdddh":
                return "046. The Ultimate Power";
            case "dhddnd":
                return "047. Dyed in Lovely Darkness...";
            case "dhddnh":
                return "048. Vainglory or Abandonment?";
            case "dhdndd":
                return "049. Messenger of Ruination";
            case "dhdndh":
                return "050. Standing at the Summit";
            case "dhdnnd":
                return "051. Controller from the Capsule";
            case "dhdnnh":
                return "052. Beyond One's Own Power...";
            case "dhdnhd":
                return "053. A Clone's Determination";
            case "dhdnhh":
                return "054. Machine Utopia";
            case "dhdhdd":
                return "055. A Toast to the Ruler";
            case "dhdhdh":
                return "056. Answer from the Black Comet";
            case "dhdhnd":
                return "057. Transcendentalism";
            case "dhdhnh":
                return "058. Imperialism";
            case "dhdhhd":
                return "059. The Weight of One's Crimes";
            case "dhdhhh":
                return "060. Imprisoned by the Past...";
            case "dhnddd":
                return "061. The Ultimate World Conquest";
            case "dhnddh":
                return "062. Black Angel";
            case "dhndnd":
                return "063. Under Dakness' Control";
            case "dhndnh":
                return "064. To Love Onself";
            case "dhndhd":
                return "065. Revenge and Determination";
            case "dhndhh":
                return "066. Birth of the Robot Emperor";
            case "dhnndd":
                return "067. Shadow, the Black Android";
            case "dhnndh":
                return "068. A Solitary Android";
            case "dhnnnd":
                return "069. Over the Original";
            case "dhnnnh":
                return "070. Machine Sunshine";
            case "dhnnhd":
                return "071. Life is Guilty";
            case "dhnnhh":
                return "072. Fallen Angel of Despair";
            case "dhnhdd":
                return "073. An Eternal Rival...";
            case "dhnhdh":
                return "074. This is Just the Beginning";
            case "dhnhnd":
                return "075. Crystal of Tragic Knowledge";
            case "dhnhnh":
                return "076. Shadow's Second Death...?";
            case "dhnhhd":
                return "077. The Legend of Shadow";
            case "dhnhhh":
                return "078. Power of Love";
            case "dhhddd":
                return "079. Deep Black";
            case "dhhddh":
                return "080. Walk My Way";


            // Neutral
            case "nnnnnd":
                return "163. An Android's Rebellion";
            case "nnnnnh":
                return "164. A New Empire's Beginning";

            // Hero
            case "hhhhhd":
                return "361. Pretense in the Mirror";
            case "hhhhhh":
                return "326. A Missive from 50 Years Ago";
        }
    }
}

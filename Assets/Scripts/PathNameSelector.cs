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
        }
    }
}

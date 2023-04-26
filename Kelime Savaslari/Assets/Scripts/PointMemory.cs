using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PointMemory 
{
   public static string score1="score1";
   public static string score2="score2";
   public static string score3="score3";
  // public static string score4="score4";
   //public static string score5="score5";
   public static void setMaxScore(int maxScore)
   {
    PlayerPrefs.SetInt(PointMemory.score1,maxScore);
   }
   public static int getMaxScore()
   {
    return PlayerPrefs.GetInt(PointMemory.score1);
   }
    public static void set2MaxScore(int maxScore)
   {
    PlayerPrefs.SetInt(PointMemory.score2,maxScore);
   }
   public static int get2MaxScore()
   {
    return PlayerPrefs.GetInt(PointMemory.score2);
   }
    public static void set3MaxScore(int maxScore)
   {
    PlayerPrefs.SetInt(PointMemory.score3,maxScore);
   }
   public static int get3MaxScore()
   {
    return PlayerPrefs.GetInt(PointMemory.score3);
   }
  /*  public static void set4MaxScore(int maxScore)
   {
    PlayerPrefs.SetInt(PointMemory.score4,maxScore);
   }
   public static int get4MaxScore()
   {
    return PlayerPrefs.GetInt(PointMemory.score4);
   }
    public static void set5MaxScore(int maxScore)
   {
    PlayerPrefs.SetInt(PointMemory.score5,maxScore);
   }
   public static int get5MaxScore()
   {
    return PlayerPrefs.GetInt(PointMemory.score5);
   }

*/
   public static bool hasMaxScore()
   {
    if(PlayerPrefs.HasKey(PointMemory.score1)){
        return true;
    }else{
        return false;
    }
   }
   public static bool has2MaxScore()
   {
    if(PlayerPrefs.HasKey(PointMemory.score2)){
        return true;
    }else{
        return false;
    }
   }
   public static bool has3MaxScore()
   {
    if(PlayerPrefs.HasKey(PointMemory.score3)){
        return true;
    }else{
        return false;
    }
   }/*
   public static bool has4MaxScore()
   {
    if(PlayerPrefs.HasKey(PointMemory.score4)){
        return true;
    }else{
        return false;
    }
   }
   public static bool has5MaxScore()
   {
    if(PlayerPrefs.HasKey(PointMemory.score5)){
        return true;
    }else{
        return false;
    }
   }*/
}

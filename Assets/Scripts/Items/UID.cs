using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UID : MonoBehaviour
{
    public static int safeExit = 0;

    public static string GetUniqueID()
    {
        DateTime epochStart = new DateTime(1970, 1, 1, 8, 0, 0, DateTimeKind.Utc);
        double timestamp = (DateTime.UtcNow - epochStart).TotalSeconds;

        string uniqueID = string.Format("{0:X}", Convert.ToInt32(timestamp))                //Time
                  + "-" + string.Format("{0:X}", Convert.ToInt32(Time.time * 1000000))        //Time in game
                  + "-" + string.Format("{0:X}", Convert.ToInt32((int)(UnityEngine.Random.value * 1000000)))            //random number
                  + "-" + safeExit.ToString();             //random number
        safeExit++;
        return uniqueID;
    }
}

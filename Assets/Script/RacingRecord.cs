using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RacingRecord : MonoBehaviour
{
    public GameObject MinuteRecord;
    public GameObject SecondRecord;
    public GameObject MilliRecord;
    public GameObject RacingRecordTrigger;

    void OnTriggerEnter()
    {
        if(RacingTime.SecondCount <= 9)
        {
            SecondRecord.GetComponent<Text>().text = "0" + RacingTime.SecondCount + ".";
        }
        else
        {
            SecondRecord.GetComponent<Text>().text = "" + RacingTime.SecondCount + ".";
        }
        if(RacingTime.MinuteCount <= 9)
        {
            MinuteRecord.GetComponent<Text>().text = "0" + RacingTime.MinuteCount + ".";
        }
        else
        {
            MinuteRecord.GetComponent<Text>().text = "" + RacingTime.MinuteCount + ".";
        }

        MilliRecord.GetComponent<Text>().text = "" + RacingTime.MilliCount;

        RacingTime.MinuteCount = 0;
        RacingTime.SecondCount = 0;
        RacingTime.MilliCount = 0;

        RacingRecordTrigger.SetActive(false);

    }
}

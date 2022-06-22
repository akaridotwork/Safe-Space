using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoveButton : MonoBehaviour
{
    public GameObject Player;
    public GameObject MainCanvas;
    public GameObject LoveCanvas;
    public GameObject Girl1;
    public GameObject Girl2;
    public GameObject Girl3;
    public GameObject Girl4;
    public GameObject HeartGirl1;
    public GameObject HeartGirl2;
    public GameObject notification;
    public GameObject Pijl;

    public void onClick()
    {
        MainCanvas.SetActive(false);
        LoveCanvas.SetActive(true);
        Player.SetActive(false);
        Girl1.SetActive(false);
        Girl2.SetActive(false);
        Girl3.SetActive(false);
        Girl4.SetActive(false);
        notification.SetActive(false);
        Pijl.SetActive(false);

        if(HeartGirl1.activeInHierarchy == true)
        {
            Girl1.SetActive(true);
        }
        if (HeartGirl2.activeInHierarchy == true)
        {
            Girl2.SetActive(true);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{
    public GameObject Light1;
    public GameObject Light2;
    public GameObject switch1;
    public GameObject switch2;
    public GameObject active1;
    public GameObject active2;
    public GameObject active3;
    public GameObject active4;
    public GameObject active5;
    public GameObject MainCanvas;
    public GameObject PowerCanvas;
    public GameObject player;
    public GameObject heart;
    public void onClick()
    {
        if (switch1.activeInHierarchy == true)
        {

            switch2.SetActive(true);
            switch1.SetActive(false);
            active1.SetActive(true);
            Light2.SetActive(true);
            Light1.SetActive(false);
            if (active1.activeInHierarchy == true && active2.activeInHierarchy == true && active3.activeInHierarchy == true && active4.activeInHierarchy == true && active5.activeInHierarchy == true)
            {
                MainCanvas.SetActive(true);
                player.SetActive(true);
                heart.SetActive(true);
                PowerCanvas.SetActive(false);
            }
        }
        else
        {
            switch2.SetActive(false);
            switch1.SetActive(true);
            active1.SetActive(false);
            Light1.SetActive(true);
            Light2.SetActive(false);
        }
    }
}

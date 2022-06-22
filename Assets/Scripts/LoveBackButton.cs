using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoveBackButton : MonoBehaviour
{
    public GameObject Player;
    public GameObject MainCanvas;
    public GameObject LoveCanvas;

    public void onClick()
    {
        MainCanvas.SetActive(true);
        LoveCanvas.SetActive(false);
        Player.SetActive(true);
    }
}

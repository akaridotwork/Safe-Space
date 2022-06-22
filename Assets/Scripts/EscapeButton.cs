using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeButton : MonoBehaviour
{
    public GameObject Player;
    public GameObject MainCanvas;
    public GameObject LoveCanvas;

    public void onClick()
    {
        MainCanvas.SetActive(false);
        LoveCanvas.SetActive(true);
        Player.SetActive(false);
    }
}

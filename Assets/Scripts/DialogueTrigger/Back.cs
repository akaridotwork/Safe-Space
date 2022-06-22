using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    public GameObject MainCanvas;
    public GameObject LoveCanvas;

    public void onClick()
    {
        MainCanvas.SetActive(true);
        LoveCanvas.SetActive(false);
    }
}

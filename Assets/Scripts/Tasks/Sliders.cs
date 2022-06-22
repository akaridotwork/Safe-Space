using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sliders : MonoBehaviour
{
    public Slider Power;
    public Slider Oxygen;
    public Slider Hydorgen;
    public GameObject Player;
    public GameObject MainCanvas;
    public GameObject SliderCanvas;
    public GameObject Heart3;
    public GameObject notification;

    public void Slidersetting()
    {
        if(Power.value == 7 && Oxygen.value == 0 && Hydorgen.value == 10)
        {
            Player.SetActive(true);
            MainCanvas.SetActive(true);
            SliderCanvas.SetActive(false);
            Heart3.SetActive(true);
            notification.SetActive(true);
        }
    }
    
}

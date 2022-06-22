using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XSlider : MonoBehaviour
{
    public GameObject Player;
    public GameObject MainCanvas;
    public GameObject SliderCanvas;

    public void OnClick()
    {
        
            Player.SetActive(true);
            MainCanvas.SetActive(true);
            SliderCanvas.SetActive(false);
        
    }

}

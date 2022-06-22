using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueStartScreen : MonoBehaviour
{
    public GameObject Lore;
    public GameObject Startscreen;
    public GameObject SecondButton;
    public GameObject firstButton;

    public void onClick()
    {
        if (Lore == true)
            Lore.SetActive(false);
            Startscreen.SetActive(true);
            SecondButton.SetActive(true);
            firstButton.SetActive(true);
        
    }
}

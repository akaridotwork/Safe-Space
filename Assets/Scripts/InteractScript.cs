using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractScript : Interactable
{

 
    public GameObject Canvas;
    public GameObject player;
    public GameObject MainCanvas;

    public override void interact()
    {
       
        Canvas.SetActive(true);
        player.SetActive(false);
        MainCanvas.SetActive(false);


    }

    
}



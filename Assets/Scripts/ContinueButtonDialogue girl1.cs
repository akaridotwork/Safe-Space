using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueButtonDialoguegirl1 : MonoBehaviour
{
	public GameObject player;
	public GameObject MainCanvas;
	public GameObject DialogueScreen;
	public GameObject Text1;
	public GameObject Text2;
	public GameObject Text3;

    public void onClick()
    {
        if (Text1.activeInHierarchy == true)
        {
			Text1.SetActive(false);
			Text2.SetActive(true);
        }
		if (Text2.activeInHierarchy == true)
        {
			Text2.SetActive(false);
			Text3.SetActive(true);
        }
		if (Text3.activeInHierarchy == true)
        {
			player.SetActive(true);
			MainCanvas.SetActive(true);
			DialogueScreen.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Con1D : MonoBehaviour
{
	public GameObject player;
	public GameObject MainCanvas;
	public GameObject DialogueScreen;
	public GameObject Interaction;
	public GameObject notification;

	

	public void onClick()
	{
		
			player.SetActive(true);
			MainCanvas.SetActive(true);
			DialogueScreen.SetActive(false);
			Destroy(DialogueScreen);
			Destroy(Interaction);
			notification.SetActive(true);


		
	}
}

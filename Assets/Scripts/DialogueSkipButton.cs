using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSkipButton : MonoBehaviour
{
	public Dialogue dialogue;
	public GameObject Canvas;
	public GameObject Circle;
	public GameObject player;
	public GameObject MainCanvas;
	public GameObject Text2;
	public GameObject Text3;

	public void TriggerDialogue()
	{
		Canvas.SetActive(true);
		player.SetActive(false);
		MainCanvas.SetActive(false);
		Text2.SetActive(false);
		Text3.SetActive(false);
	}

	private void OnCollisionEnter(Collision collision)
	{
		TriggerDialogue();
		Destroy(this);
		Destroy(Circle);
	}
}

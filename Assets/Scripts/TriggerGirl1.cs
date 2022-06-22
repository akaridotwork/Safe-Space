using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGirl1 : MonoBehaviour
{
	public GameObject Canvas;
	public GameObject Circle;
	public GameObject player;
	public GameObject MainCanvas;
	public GameObject Heart;

	public void TriggerDialogue()
	{
		Canvas.SetActive(true);
		player.SetActive(false);
		MainCanvas.SetActive(false);
		Heart.SetActive(true);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		TriggerDialogue();
		Destroy(Circle);
	}
}

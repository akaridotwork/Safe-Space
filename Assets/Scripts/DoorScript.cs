using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
	public Dialogue dialogue;
	public GameObject DoorCanvas;
	public GameObject player;
	public GameObject MainCanvas;

	public void TriggerDialogue()
	{
		FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
		DoorCanvas.SetActive(true);
		player.SetActive(false);
		MainCanvas.SetActive(false);
	}
	private void OnCollisionEnter(Collision collision)
	{
		TriggerDialogue();
	}
}

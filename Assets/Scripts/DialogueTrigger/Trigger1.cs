using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger1 : MonoBehaviour
{
	public Dialogue dialogue;
	public GameObject task1;

	public void TriggerDialogue1()
	{
		FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
		task1.SetActive(true);
	}
}

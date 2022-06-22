using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    Rigidbody rb;
    float moveSpeed = 5f, dirX;

    [SerializeField]
    GameObject codePanel, closedDoor, openedDoor;

    public static bool isDoorOpened = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        codePanel.SetActive(false);
        closedDoor.SetActive(true);
        openedDoor.SetActive(false);

    }
    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * moveSpeed;
        if (isDoorOpened)
        {
            codePanel.SetActive(false);
            closedDoor.SetActive(false);
            openedDoor.SetActive(true);
        }

    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Door") && !isDoorOpened)
        {
            codePanel.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Door"))
        {
            codePanel.SetActive(false);
        }
    }
}

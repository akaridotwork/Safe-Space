using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 3;

    private Animator animator;

    public GameObject interactableIcon;
    public Vector2 boxSize;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        animator.SetFloat("Speed", 0);
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-movementSpeed, 0, 0) * Time.deltaTime;
            animator.SetFloat("Speed", 1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(movementSpeed, 0, 0) * Time.deltaTime;
            animator.SetFloat("Speed", 1);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += new Vector3(movementSpeed * 2, 0, 0) * Time.deltaTime;
            animator.SetFloat("Speed", 1);
        }
        if (Input.GetKey(KeyCode.E))
        {
            CheckInteraction();
        }
    }
    public void OpenInteractableIcon()
    {
        interactableIcon.SetActive(true);
    }
    public void CloseInteractableIcon()
    {
        interactableIcon.SetActive(false);
    }

    private void CheckInteraction()
    {
        RaycastHit2D[] hits = Physics2D.BoxCastAll(transform.position, boxSize, 0, Vector2.zero);   
        

        if (hits.Length > 0)
        {
            foreach (RaycastHit2D rc in hits)
            {
                if (rc.transform.GetComponent<Interactable>())
                {
                    rc.transform.GetComponent<Interactable>().interact();
                    return;
                }
            }
        }
    }
}


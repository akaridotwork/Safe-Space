using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire : MonoBehaviour
{
    public SpriteRenderer WireMoving;
    Vector3 startPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMouseDrag()
    {
        //mouse position to world point

        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newPosition.z = 0;

        //update wire
        transform.position = newPosition;

        // update direction
        Vector3 direction = newPosition - startPoint;
        transform.right = direction * transform.lossyScale.x;

        // update scale
        float dist = Vector2.Distance(startPoint, newPosition);
        WireMoving.size = new Vector2(dist, WireMoving.size.y);
    }
}

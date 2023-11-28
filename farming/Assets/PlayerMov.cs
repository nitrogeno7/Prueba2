using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMov : MonoBehaviour
{
    private float speed = 1 ;
    private Vector2 posSquare = new Vector2(50,50);
    public void mLeft(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            transform.position += new Vector3(-1, 0, 0) * speed;
            posSquare.x -= 1;
            GetComponent<SpriteRenderer>().flipX = true;
            Debug.Log(posSquare);
        }
    }
    public void mRight(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            transform.position += new Vector3(1, 0, 0) * speed;
            posSquare.x += 1;
            GetComponent<SpriteRenderer>().flipX = false;
            Debug.Log(posSquare);
        } 
    }
    public void mDown(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            transform.position += new Vector3(0, -1, 0) * speed;
            posSquare.y -= 1;
            Debug.Log(posSquare);
        }
    }
    public void mUp(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            transform.position += new Vector3(0, 1, 0) * speed;
            posSquare.y += 1;
            Debug.Log(posSquare);
        }
    }
}

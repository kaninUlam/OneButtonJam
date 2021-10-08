using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falseFloor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) // trigger when player touches this object it activates gravity making it fall
    {
        if(collision.gameObject.tag == "Player")
        {
            GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }
}

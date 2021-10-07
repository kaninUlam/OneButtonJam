using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterStats : MonoBehaviour
{
    bool isalive = true;
    private void Update()
    {
        if(isalive == false)
        {
            GetComponent<charactermovement>().enabled = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Trap")
        {
            isalive = false;
            GetComponent<BoxCollider2D>().enabled = false;
        }

    }

}

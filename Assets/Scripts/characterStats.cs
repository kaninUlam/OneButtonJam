using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class characterStats : MonoBehaviour
{
    public bool isalive = true;
    private void Update()
    {
        if(isalive == false)// checks if the character is dead. disables its movement
        {
            GetComponent<charactermovement>().enabled = false;
            SceneManager.LoadScene("Restart");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Trap") // checks if the character is hit or touches a trap. makes the character dead
        {
            isalive = false;
            GetComponent<BoxCollider2D>().enabled = false;
        }

    }

}

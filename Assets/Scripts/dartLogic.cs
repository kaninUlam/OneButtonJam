using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dartLogic : MonoBehaviour
{
    // put this on a 2d object disable the renderer and add collider trigger
    //add an empty make it the spawn point of instantiated object
    public GameObject dart = null;
    public GameObject spawnpoint = null;
    GameObject dartprojectile = null;

    public float projectilespeed = 10f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")// triggers when the player enters the trigger. spawns a dart at the dart spawn and launches it with the velocity using projectile speed
        {
            dartprojectile = Instantiate(dart, spawnpoint.transform.position, spawnpoint.transform.rotation);
            dartprojectile.GetComponent<Rigidbody2D>().velocity = transform.position * new Vector2(10 * Time.deltaTime * projectilespeed, 0) ;
        }
    }
    private void OnBecameInvisible()
    {
        Destroy(dartprojectile);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dartLogic : MonoBehaviour
{
    public GameObject dart = null;
    public GameObject spawnpoint = null;
    GameObject dartprojectile = null;

    public float projectilespeed = 10f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            dartprojectile = Instantiate(dart, spawnpoint.transform.position, spawnpoint.transform.rotation);
            dartprojectile.GetComponent<Rigidbody2D>().velocity = transform.position * new Vector2(10 * Time.deltaTime * projectilespeed, 0) ;
        }
    }
}

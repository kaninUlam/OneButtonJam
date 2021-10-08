using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boostItem : MonoBehaviour
{
    public float multiplier = 2.5f;
    public float duration = 1.5f;
    private void OnTriggerEnter2D(Collider2D player)// trigger when the character touches this object. increase character movement
    {
        if (player.CompareTag("Player"))
        {
            StartCoroutine(Pickup(player));
        }
    }

    IEnumerator Pickup(Collider2D player)
    {
        charactermovement stats = player.GetComponent<charactermovement>();
        stats.speed *= multiplier;
        Debug.Log("your speed: " + stats.speed);
        GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(1f);
        stats.speed /= multiplier;
        Debug.Log("your speed: " + stats.speed);
        Destroy(gameObject);
    }
}

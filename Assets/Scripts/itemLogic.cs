using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemLogic : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D player)// trigger when the character touches this object. Increases the number of jumps to 2 (double jump) after which destroys the item
    {
            jumpLogic stats = player.GetComponent<jumpLogic>();
            stats.JumpNum = 2;
            Debug.Log(stats.JumpNum);
            Destroy(gameObject);
    }
}

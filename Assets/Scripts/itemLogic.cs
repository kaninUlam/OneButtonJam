using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemLogic : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D player)
    {
            jumpLogic stats = player.GetComponent<jumpLogic>();
            stats.JumpNum = 2;
            Debug.Log(stats.JumpNum);
            Destroy(gameObject);
    }
}

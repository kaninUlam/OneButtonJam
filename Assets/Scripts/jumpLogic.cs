using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpLogic : MonoBehaviour
{
    public float jumpheight = 4f;
    public int JumpNum = 1;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("w") && JumpNum >= 1) // press w and jump number is 1 or higher
        {
            rb.AddForce(Vector2.up * jumpheight, ForceMode2D.Impulse); // adds force in the positive y times the jump height(can edit), adds instant force to rigidbody2d
            JumpNum--;// decrease jump number

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Platform")) // when this object touches a game object containing name with platform
        {
            if(JumpNum == 0) // increases jump number when jump number is at 0
            {
                JumpNum = 1;
            }
            
        }
    }
}

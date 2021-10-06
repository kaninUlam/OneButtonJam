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
        if(Input.GetKeyDown("w") && JumpNum >= 1)
        {
            rb.AddForce(Vector2.up * jumpheight, ForceMode2D.Impulse);
            JumpNum--;

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Platform"))
        {
            if(JumpNum == 0)
            {
                JumpNum = 1;
            }
            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityFlip : MonoBehaviour
{
    private Rigidbody2D prb;
    private Player player;

    public Player script;

    private bool top;

    void Start()
    {
        player = GetComponent<Player>();
        prb = GetComponent<Rigidbody2D>();

    }

    
    void Update()
    {
        if (Input.GetButtonDown("Fire3"))
        {
            prb.gravityScale *= -1;
            Rotation();
        }

    }

    void Rotation()
    {
        if(top == false)
        {
            transform.eulerAngles = new Vector3(0, 0, 180f);
            player.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            transform.eulerAngles = Vector3.zero;
            player.GetComponent<SpriteRenderer>().flipX = false;
        }
      
        top = !top;
    }
  




}

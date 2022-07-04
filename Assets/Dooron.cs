using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dooron : MonoBehaviour
{
    private Animator anim;
    Collider2D t;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        t = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Open()
    {
        anim.SetInteger("anim", 1);
        t.isTrigger = true;
    }


    public void Close()
    {
        anim.SetInteger("anim", 0);
        t.isTrigger = false;
    }
}


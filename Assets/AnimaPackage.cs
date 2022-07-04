using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimaPackage : MonoBehaviour
{
    private Animator anim;
    public Dooron dooron;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D target)
    {
        anim.SetInteger("anim", 1);
        dooron.Open();
    }


    void OnCollisionExit2D(Collision2D target)
    {
        anim.SetInteger("anim", 0);
        dooron.Close();
    }
}


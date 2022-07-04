using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animalrotate : MonoBehaviour
{
    public Transform animaT, OAnimaT;
    private bool Collisons = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Collisons = Physics2D.Linecast(animaT.position, OAnimaT.position, 1 << LayerMask.NameToLayer("solid"));

        if (Collisons)
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
}

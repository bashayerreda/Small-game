using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextlevel : MonoBehaviour
{
    public string levelName;
    private bool LockMode = false;
    // Use this for initialization
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !LockMode)
        {
            //LockMode = true;
            Application.LoadLevel(levelName);

        }


    }
}

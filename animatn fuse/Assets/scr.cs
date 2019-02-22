using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr : MonoBehaviour
{


    public Animator a;

    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<Animator>();
    }

    private void Update()
    {

        if(Input.GetMouseButton(0))
        a.SetInteger("int",1);
    }
}

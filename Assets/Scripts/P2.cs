using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("up")){
            transform.Translate(0,20*Time.deltaTime,0);
        } else if(Input.GetKey("down")){
            transform.Translate(0,-20*Time.deltaTime,0);
        }
        var pos = transform.position;
        pos.y =  Mathf.Clamp(transform.position.y, -12.0f, 12.0f);
        transform.position = pos;
    }
}

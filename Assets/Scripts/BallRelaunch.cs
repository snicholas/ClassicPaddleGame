using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallRelaunch : MonoBehaviour
{
    public gameManager gm;
    void OnTriggerEnter(Collider other){
        gm.score(other.transform.position.x>0);
    }
}

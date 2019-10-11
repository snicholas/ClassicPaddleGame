using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    AudioSource audioSource;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Stop();
        rb=GetComponent<Rigidbody>();
        StartCoroutine(delayedRun());
    }
    public void resetPositionAndStop(){
        transform.position=new Vector3(0,0,0);
        rb.velocity=new Vector3(0,0,0);
    }
    public IEnumerator delayedRun()
    {
        resetPositionAndStop();
        yield return new WaitForSeconds(2);

        rb.AddForce(Random.Range(7,9)*randomDir(), Random.Range(5,7)*randomDir(), 0 );
    }
    int randomDir ()
    {
        if (Random.value >= 0.5)
        {
            return -1;
        }
        return 1;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision){
        if (collision.gameObject.name != "Playfield")
        {
            audioSource.Play();
        }
    }
}

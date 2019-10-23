using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// this enemy will move towards the turrrent and dies when shot

public class CB_Minion : MonoBehaviour
{

    public GameObject turrent;
    public float speed = 5;



    private void Start()
    {
        turrent = GameObject.Find("Turrent");
    }
    // Update is called once per frame
    void Update()
    {
        // look at turrent
        transform.LookAt(turrent.transform.position);


        // move
        transform.position += transform.forward * Time.deltaTime * speed;

    }
}

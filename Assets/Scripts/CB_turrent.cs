using System.Collections;
using System.Collections.Generic;
using UnityEngine;




//SHIOTS WHEN CLICK 
public class CB_turrent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ROATAE TO MOUSE POISITION 
        // the infomation of what raycast has hit
        RaycastHit hit;
        // create a raycast to point at the mouses position
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
       if (Physics.Raycast(ray, out hit, 100))
        {
            transform.LookAt(new Vector3(hit.point.x, 0, hit.point.z));
        }
        
        // SHHOT ON CLICK
    }
}

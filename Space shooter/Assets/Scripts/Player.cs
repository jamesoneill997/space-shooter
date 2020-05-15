using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Player Extends MonoBehaviour
public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //curr position = 0
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {  
        //z axis 1 unit per second
        transform.Translate(Vector3.forward, Time.deltaTime);

        //
        
    }
}

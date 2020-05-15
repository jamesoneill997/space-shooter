using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Player Extends MonoBehaviour
public class Player : MonoBehaviour
{   
    //speed setting
    [SerializeField]
    private int _speed = 5;
    public float horizontalInput;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {  
        //user input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalBound = 5.0f;
        float verticalBound = 9.23f;

        Vector3 direction = new Vector3(horizontalInput,verticalInput,0);
        transform.Translate(direction*_speed*Time.deltaTime);
        

        if(transform.position.y >= horizontalBound || transform.position.y <= -1*horizontalBound){
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
        else if(transform.position.x >= verticalBound || transform.position.x <= -1*verticalBound){
            transform.position = new Vector3(-1*transform.position.x, transform.position.y, transform.position.z);
        }
    }
}

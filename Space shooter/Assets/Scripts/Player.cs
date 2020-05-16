using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Player Extends MonoBehaviour
public class Player : MonoBehaviour
{   
    //speed setting
    [SerializeField]
    private int _speed = 10;
    [SerializeField]
    private GameObject laserPrefab = null;
    [SerializeField]
    private float _fireRate = 0.1f;
    [SerializeField]
    private float _nextFire = 0.0f;
    [SerializeField]
    private Vector3 _offset = new Vector3(0,1,0);
    [SerializeField]
    private int _lives = 3;

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
        calculateMovement();
        if(Input.GetKeyDown(KeyCode.Space) && Time.time > _nextFire){
            fireLaser();
        }
    }

    void calculateMovement(){
        //user input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalBound = 9.1f;
        float verticalBound = 3.8f;

        Vector3 direction = new Vector3(horizontalInput,verticalInput,0);
        transform.Translate(direction* _speed * Time.deltaTime);
        
        if(transform.position.y >= 0){
            transform.position = new Vector3(transform.position.x,0,transform.position.z);
        }

        else if(transform.position.y < -1*verticalBound){
            transform.position = new Vector3(transform.position.x, -1*verticalBound,0);
        }

        if(transform.position.x <= -1*horizontalBound){
            transform.position = new Vector3(horizontalBound, transform.position.y,transform.position.z);
        }

        else if(transform.position.x >= horizontalBound){
            transform.position = new Vector3(-1*horizontalBound, transform.position.y,transform.position.z);
        }


    }

    void fireLaser(){
        _nextFire = Time.time+_fireRate;
        Instantiate(laserPrefab, transform.position+_offset, Quaternion.identity);
        
    }

    public void damage(){
        _lives--;
        Debug.Log(_lives);
        if(_lives<1){
            Destroy(this.gameObject);
        }
    }
}

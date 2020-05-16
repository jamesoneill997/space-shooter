﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _speed = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Random.Range(-9.0f, 9.0f), 5, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(0,-5,0);
        transform.Translate(direction* _speed * Time.deltaTime);

        if (transform.position.y <=-6.0f){
            transform.position = new Vector3(Random.Range(-9.0f,9.0f), 6,0f);
        }

        
        
    }

    void OnTriggerEnter(Collider other){
        Debug.Log(other.transform.name);
        if(other.transform.name.Contains("Laser")){
            GameObject.Destroy(other.gameObject);
            GameObject.Destroy(this.gameObject);
        }

        else if(other.transform.name == "Player"){
            Player player = other.transform.GetComponent<Player>();
            player.damage();
            GameObject.Destroy(this.gameObject);
        }

    }
}

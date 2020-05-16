using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField]
    private float _speed = 4.0f;
    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(0,10,0);
        transform.Translate(direction* _speed * Time.deltaTime);

        if(transform.position.y >= 7){
            GameObject.Destroy(this.gameObject);
        }
    }
}

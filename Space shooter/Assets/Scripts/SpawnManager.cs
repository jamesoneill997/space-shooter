using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private IEnumerator coroutine;
    private GameObject enemyPrefab;

    void Start(){
        enemyPrefab = GameObject.Find("Enemy");
        Debug.Log("Starting " + Time.time + " seconds");
        coroutine = Spawn(2.0f);
        while (true)
        {
            StartCoroutine(coroutine);
        }
            
    }
    void Update()
    {
        
    }

    private IEnumerator Spawn(float waitTime)
    {
        
        yield return new WaitForSeconds(waitTime);
        Instantiate(enemyPrefab,new Vector3(0,Random.Range(-9.0f,9.0f),0),Quaternion.identity);
        
    }
}

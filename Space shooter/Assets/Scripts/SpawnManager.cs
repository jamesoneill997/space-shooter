using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private IEnumerator coroutine;
    [SerializeField]
    private GameObject enemyPrefab = null;
    [SerializeField]
    private GameObject enemyContainer = null;
    private float _spawnRate = 2.0f;

    void Start(){
        coroutine = Spawn(_spawnRate);
        StartCoroutine(coroutine);
    }

    private IEnumerator Spawn(float waitTime)
    {
        while(true){
            GameObject newEnemy = Instantiate(enemyPrefab,new Vector3(Random.Range(-9.0f,9.0f),6.0f,0.0f),Quaternion.identity);
            newEnemy.transform.parent = enemyContainer.transform;
            yield return new WaitForSeconds(waitTime);
        }
    }
}
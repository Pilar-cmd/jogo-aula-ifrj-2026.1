using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LixoSpawnerController : MonoBehaviour
{
    public float maximum;
    
    public float fixedY;

    public float fixedZ;

    public float time;

    public GameObject lixo;

    public int maxPoints;

    public int points = 0;

}   

    void Start() {
    StartCoroutine(SpawnRoutine());
    }

    void Update()
    {
        
    }

    IEnumerator SpawnRoutine() {
    while (points < MaxPoints) {
        Instantiate(Lixo,
            new Vector3(Random.Range(-maximumX, maximumX + 1),
                fixedY,
                fixedZ),
            Quaternion.identity);
        yield return new WaitForSeconds(timer);
    }
}


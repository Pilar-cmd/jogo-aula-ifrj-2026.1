using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LixoSpawnerController : MonoBehaviour
{
    // 2 references
    public float maximum;
    public float fixedY;

    // 1 reference
    public float fixedZ;

    // 1 reference
    public float time;

    // 1 reference
    public GameObject lixo;

    // 1 reference
    public int maxPoints;

    // 1 reference
    public int points = 0;

}   void Start()
{
    StartCoroutine(SpawnRoutine());
}

    // Update is called once per frame
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


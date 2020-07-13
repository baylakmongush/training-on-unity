using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFlower : MonoBehaviour
{
    public GameObject[] flowers;
    public GameObject flower;
    int mint = 3;
    int maxt = 5;


    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawner_flow",Random.Range (mint, maxt));
    }
    void Spawner_flow()
    {

        Instantiate(flowers[Random.Range(0, 3)], new Vector3(Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Camera.main.pixelWidth, 0)).x),  Camera.main.ScreenToWorldPoint(new Vector2(Camera.main.pixelWidth, Camera.main.pixelHeight)).y, flower.transform.position.z), Quaternion.identity);
        Invoke("Spawner_flow", Random.Range (mint, maxt));
    }
}

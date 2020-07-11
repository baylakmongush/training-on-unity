using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFlower : MonoBehaviour
{
    public GameObject[] flowers;
    public GameObject flower;
    float count = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        if (count >= 5)
        {
            Instantiate(flowers[Random.Range(0, 3)], new Vector3(Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Camera.main.pixelWidth, 0)).x),  Camera.main.ScreenToWorldPoint(new Vector2(Camera.main.pixelWidth, Camera.main.pixelHeight)).y, flower.transform.position.z), Quaternion.identity);
            count = 0;
        }
        count += Time.deltaTime;
    }
}

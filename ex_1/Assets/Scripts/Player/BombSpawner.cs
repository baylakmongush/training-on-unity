using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    public GameObject bomb;
    int mint = 7;
    int maxt = 10;

    // Start is called before the first frame update
    void Start()
    {
         Invoke("Spawner_bomb",Random.Range (mint, maxt));
    }
    void Spawner_bomb()
    {
        Instantiate(bomb, new Vector3(Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Camera.main.pixelWidth, 0)).x),  Camera.main.ScreenToWorldPoint(new Vector2(Camera.main.pixelWidth, Camera.main.pixelHeight)).y, bomb.transform.position.z), Quaternion.identity);
        Invoke("Spawner_bomb", Random.Range (mint, maxt));
    }
}

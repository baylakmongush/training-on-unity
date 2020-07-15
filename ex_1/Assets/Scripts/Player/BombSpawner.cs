using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    public GameObject bomb;
    float mint = 7;
    float maxt = 10;
    Bomb bombClass;

    // Start is called before the first frame update
    void Start()
    {
        bombClass = new Bomb();
        Invoke("Spawner_bomb", Random.Range (mint, maxt));
        InvokeRepeating("Accelerate", 0, 15);
    }

    public void Accelerate()
    {
        bombClass.Thrust += 0.5f;
        Debug.Log(bombClass.Thrust);
    }
    void Spawner_bomb()
    {
        Instantiate(bomb, new Vector3(Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Camera.main.pixelWidth, 0)).x),  Camera.main.ScreenToWorldPoint(new Vector2(Camera.main.pixelWidth, Camera.main.pixelHeight)).y, bomb.transform.position.z), Quaternion.identity);
        if (mint > 0.5f)
        {
            mint -= 0.5f;
            maxt -= 0.5f;
            Invoke("Spawner_bomb", Random.Range (mint, maxt));
        }
        else
            Invoke("Spawner_bomb", 0.3f);
            Debug.Log(mint);
    }
}

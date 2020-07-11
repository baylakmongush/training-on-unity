using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveClouds : MonoBehaviour
{
    Rigidbody2D rigidbody;
    float       thrust = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.x += Time.deltaTime * thrust;
        transform.position = position;
        if (gameObject.transform.position.x > Camera.main.ScreenToWorldPoint(new Vector2(Camera.main.pixelWidth, 0)).x * 2)
            Destroy(gameObject);
    }
}

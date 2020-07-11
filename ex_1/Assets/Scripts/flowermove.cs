﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowermove : MonoBehaviour
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
        rigidbody.AddForce(transform.up * -1.0f * thrust);
        if (gameObject.transform.position.y < Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y)
            Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D otherObj)
    {
        if (otherObj.gameObject.tag.Equals("man"))
            Destroy(gameObject);
    }
}

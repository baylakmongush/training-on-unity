using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bomb : MonoBehaviour
{
    Rigidbody2D rigidbody;
    static float       thrust = 0.5f;

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
        {
            Destroy(gameObject);
            SceneManager.LoadScene("gameover", LoadSceneMode.Single);
        }
    }

    public float Thrust {
        get => thrust;
        set {
            thrust = value;
        }
    }
}
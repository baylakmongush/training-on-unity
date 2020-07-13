using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FlowerMove : MonoBehaviour
{
    Rigidbody2D rigidbody;
    
    float       thrust = 0.5f;
    Text score;
    int score_count;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        score = GameObject.FindWithTag("score").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddForce(transform.up * -1.0f * thrust);
        if (gameObject.transform.position.y < Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y)
            Destroy(gameObject);
    }

    public void Score_update()
    {
        score_count += 1;
        score.text = "Score: " + score_count;
    }
    void OnCollisionEnter2D(Collision2D otherObj)
    {
        if (otherObj.gameObject.tag.Equals("man"))
        {
            Score_update();
            Destroy(gameObject);
        }
    }
}

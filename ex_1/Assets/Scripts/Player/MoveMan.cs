using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveMan : MonoBehaviour
{
    Animator anim;
    AudioSource audio_Flower;
    float speed = 5f;
    Text        score;
    int         score_count;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        score = GameObject.FindWithTag("score").GetComponent<Text>();
        audio_Flower = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        float horiz = Input.GetAxis("Horizontal");
        if (horiz < 0)
        {
            position.x += Time.deltaTime * speed * horiz;
            anim.SetBool("direction", false);
            anim.SetBool("walk", true);
        }
        else if (horiz == 0)
            anim.SetBool("walk", false);
        if (horiz > 0)
        {
            position.x += Time.deltaTime * speed * horiz;
            anim.SetBool("direction", true);
            anim.SetBool("walk_right", true);
        }
        else if (horiz == 0)
            anim.SetBool("walk_right", false);
        transform.position = this.ScreenWrapper(position);
    }

     public void Score_update()
    {
        score_count += 1;
        score.text = "Score: " + score_count;
    }
    void OnCollisionEnter2D(Collision2D otherObj)
    {
        if (otherObj.gameObject.tag.Equals("flower"))
        {
            audio_Flower.Play();
            Score_update();
            Destroy(GameObject.FindGameObjectWithTag("flower"));
        }
    }

    private Vector3 ScreenWrapper(Vector3 position)
    {
        if (gameObject.transform.position.x > Camera.main.ScreenToWorldPoint(new Vector2(Camera.main.pixelWidth, 0)).x)
            position.x = Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x;
        if (gameObject.transform.position.x < Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x)
            position.x = Camera.main.ScreenToWorldPoint(new Vector2(Camera.main.pixelWidth, 0)).x;
        return (position);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMan : MonoBehaviour
{
    Animator anim;
    float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        float horiz = Input.GetAxis("Horizontal");
        if (horiz < 0)
        {
            position.x += Time.deltaTime * speed * horiz;
            anim.SetBool("walk", true);
        }
        else if (horiz > 0)
        {
            position.x += Time.deltaTime * speed * horiz;
            anim.SetBool("walk", true);
        }
        else
            anim.SetBool("walk", false);
        transform.position = this.ScreenWrapper(position);
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

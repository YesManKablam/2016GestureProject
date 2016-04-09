using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 2f;
    public int HP = 2;
    public int LiveTime = 2;
    public GameObject hundredPointsUI;
    //public float deathSpinMin = -100f;
    //public float deathSpinMax = 100f;
<<<<<<< HEAD

    private Transform frontCheck;
    private bool dead = false;
    //private Score score;
=======
    private Transform frontCheck;
    private bool dead = false;
    private Score score;
>>>>>>> Score

    void Awake()
    {
        //frontCheck = transform.Find("frontCheck").transform;
<<<<<<< HEAD
        //score = GameObject.Find("Score").GetComponent<Score>();
=======
        score = GameObject.Find("Score").GetComponent<Score>();
>>>>>>> Score
    }

    void FixedUpdate()
    {
        //GetComponent<Rigidbody2D>().velocity = new Vector2(transform.localScale.x * moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

        if (HP <= 0 && !dead)
        {
            Death();
        }

<<<<<<< HEAD
        Destroy(gameObject, LiveTime);  
=======
        Destroy(gameObject, LiveTime);
>>>>>>> Score
    }

    public void Hurt()
    {
        HP--;
    }

    void Death()
    {
        // Increase the score by 100 points
<<<<<<< HEAD
        //score.score += 100;
=======
        score.score += 100;
>>>>>>> Score

        // Set dead to true.
        dead = true;

        Collider2D[] cols = GetComponents<Collider2D>();
        foreach (Collider2D c in cols)
        {
            c.isTrigger = true;
        }

        Vector3 scorePos;
        scorePos = transform.position;
        scorePos.y += 1.5f;

        Instantiate(hundredPointsUI, scorePos, Quaternion.identity);
    }

}

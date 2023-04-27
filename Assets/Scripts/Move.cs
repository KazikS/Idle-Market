using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Vector2 target1 = new Vector2(-113.2694f, 10f);

    private float timer;
    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, target1, 0.02f);
        if (Vector2.Distance(transform.position, target1) < 0.01f)
        {
            Destroy(gameObject);
        }
    }
}

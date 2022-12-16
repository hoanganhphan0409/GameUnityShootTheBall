using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    GameController gc;
    private void Start()
    {
        gc = FindObjectOfType<GameController>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gc.IncScore();
        Destroy(collision.collider.gameObject);
        Destroy(gameObject);
    }
}

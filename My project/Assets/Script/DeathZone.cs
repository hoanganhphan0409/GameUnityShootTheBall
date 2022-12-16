using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    // Start is called before the first frame update
    GameController gc;
    // Update is called once per frame
    void Start()
    {
        gc = FindObjectOfType<GameController>();
    }

    // Update is called once per frame

    void OnTriggerEnter2D(Collider2D col)
    {
        gc.setOver(true);
        Destroy(col.gameObject);

    }
}

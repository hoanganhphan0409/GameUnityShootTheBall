using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball;
    public float spawTime;
    float timeDistance = 1.5f;
    int score = 0;
    bool over=false;
    UIManager ui;
    void Start()
    {
        spawTime = 0;
        ui = FindObjectOfType<UIManager>();

    }

    // Update is called once per frame
    void Update()
    {
        spawTime -= Time.deltaTime;
        if (over)
        {
            spawTime = 0;
            ui.showPannel(true);
            return;
        }
        if (spawTime <= 0)
        {
            SpawnBall();
            if (score%10 == 0 && timeDistance>=0.1f)
            {
                timeDistance -= 0.1f;
            }
            spawTime = timeDistance;
        }
    }
    public void replay()
    {
        over = false;
        score = 0;
        timeDistance = 1.5f;
        ui.showPannel(false);
        ui.showScore("Score: 0");
    }
    public void SpawnBall()
    {
        Vector2 spawPos = new Vector2(Random.Range(-8, 8), 5);
        if (ball)
        {
            Instantiate(ball,spawPos,Quaternion.identity);
        }
    }
    public void setScore(int score)
    {
        this.score= score;
    }
    public int getScore() { return score; }
    public void IncScore()
    {
        setScore(getScore()+1);
        ui.showScore("Score: " + score);
    }
    public void setOver(bool o)
    {
        this.over = o;
    }
    public bool isOver() { return this.over; }

}

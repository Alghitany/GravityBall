using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaserMove : MonoBehaviour
{
    [SerializeField] GameObject ball;
    [SerializeField] GameObject chaser;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        chaser.transform.position = Vector3.MoveTowards(chaser.transform.position, ball.transform.position, speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Ball" && chaser.name=="Rock")
        {
            collision.gameObject.SetActive(false);
        }else if (collision.gameObject.name == "Ball" && chaser.name == "Coin")
        {
            Destroy(chaser);
            ScoreCounter.scoreValue = 10;
        }
    }
}

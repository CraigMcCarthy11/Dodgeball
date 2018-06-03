using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float moveSpeed;
    private Transform playerPos;
    private Player player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update () {
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, moveSpeed * Time.deltaTime);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.health--;
            Debug.Log(player.health);
            Destroy(gameObject);
        }

        if (collision.CompareTag("Ball"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}

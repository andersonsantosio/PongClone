﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour {

    public BallMovement ballMovement;

	void BounceFromRacket (Collision2D c)
    {
        Vector2 ballPosition = this.transform.position;
        Vector2 racketPosition = c.gameObject.transform.position;

        float racketHeight = c.collider.bounds.size.y;
        float x;

        if (c.gameObject.name == "RacketPlayer1") {
            x = 1;
        } else {
            x = -1;
        }

        float y = (ballPosition.y - racketPosition.y) / racketHeight;

        this.ballMovement.IncreaseHitCounter();
        this.ballMovement.MoveBall(new Vector2(x, y));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "RacketPlayer1" || collision.gameObject.name == "RacketPlayer2") {
            this.BounceFromRacket(collision);
        } else if (collision.gameObject.name == "WallLeft") {
            Debug.Log("Collision on WallLeft");
        } else if (collision.gameObject.name == "WallRight") {
            Debug.Log("Collision on WallRight");
        }
    }
}
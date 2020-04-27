using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketPlayerMovement : MonoBehaviour {

	public float movementSpeed;
    public string axis;

    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw(axis);

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * movementSpeed;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Coins : MonoBehaviour
{
	public float speed = 1f;
	GameObject coin;
	float pos;	
	void Start()
    {
        pos = transform.position.y;
	}
	void FixedUpdate()
    {

		if (Mathf.Abs(pos - transform.position.y) >= 0.1) speed = -speed;
        transform.Translate(0, 0, speed * Time.fixedDeltaTime);
        transform.Rotate(0, 0, 30 * Time.fixedDeltaTime);
    }
}

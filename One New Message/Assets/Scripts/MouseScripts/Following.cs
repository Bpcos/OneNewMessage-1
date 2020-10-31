﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The Cursor doesn't line up with the real cursor

public class Following : MonoBehaviour
{
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(Camera.main.transform.position.z - transform.position.z)));
        newPos.z = transform.position.z;


        transform.position = newPos;

    }
}

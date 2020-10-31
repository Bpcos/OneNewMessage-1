using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
<<<<<<< HEAD
        Vector3 newPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(Camera.main.transform.position.z - transform.position.z)));
=======
        Vector3 newPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x+12, Input.mousePosition.y-12, Mathf.Abs(Camera.main.transform.position.z - transform.position.z)));
>>>>>>> upstream/main
        newPos.z = transform.position.z;


        transform.position = newPos;

    }
}

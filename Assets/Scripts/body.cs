using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class body : MonoBehaviour
{
    private Rigidbody2D rigid;
    public float force = 0;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        // rigid.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("c"))
        {
            // rigid.freezeRotation = false;
            rigid.AddTorque(force, ForceMode2D.Force);
            rigid.AddForce(new Vector2(-force * 0.5f, 0f), ForceMode2D.Force);
        }
        else if (Input.GetKey("n"))
        {
            // rigid.freezeRotation = false;
            rigid.AddTorque(-force, ForceMode2D.Force);
            rigid.AddForce(new Vector2(force * 0.5f, 0f), ForceMode2D.Force);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            // rigid.freezeRotation = false;
            rigid.AddForce(new Vector2(0, force), ForceMode2D.Force);
        }
        else
        {
            // rigid.freezeRotation = true;
        }
    }
}

using UnityEngine;

public class BallMove : MonoBehaviour
{
    Rigidbody rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        //rigid.linearVelocity = new Vector3(2, 4, 3);
    }

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
            Debug.Log(rigid.linearVelocity);
        }
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), 0,
            Input.GetAxis("Vertical"));
        rigid.AddForce(vec, ForceMode.Impulse);
    }
}

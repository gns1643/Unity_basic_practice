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
        
        Vector3 vec = new Vector3(20 * Input.GetAxis("Horizontal") * Time.deltaTime, 0,
            20 * Input.GetAxis("Vertical") * Time.deltaTime);
        rigid.AddForce(vec, ForceMode.Impulse);
    }
    //private void Update()
    //{
    //    if (Input.GetButtonDown("Jump"))
    //    {
    //        rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
    //        Debug.Log(rigid.linearVelocity);
    //    }
    //}
    private void OnTriggerStay(Collider other)
    {
        if(other.name == "Cube")
        {
            rigid.AddForce(Vector3.up, ForceMode.Impulse);
        }
    }
    public void Jump()
    {
        rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
    }
}

using UnityEngine;

public class Movement : MonoBehaviour
{
    void Start()
    {
        
      
    }
    private void Update()
    {
        //���� �� ���� : deltaTime ���
        Vector3 vec = new Vector3(10 * Input.GetAxisRaw("Vertical") * Time.deltaTime
            , 0, 10 * Input.GetAxisRaw("Horizontal") * Time.deltaTime);
        //���� �� ���� : deltatime �̻��
        //Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal") 
        //    , Input.GetAxisRaw("Vertical") , 0); //���� �� ����
        transform.Translate(vec);
    }
}

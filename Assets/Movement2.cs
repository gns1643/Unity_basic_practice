using UnityEngine;

public class Movement2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    Vector3 target = new Vector3(8, 0.3f, 0);
    void Update()
    {
        ////MoveTowards : ��ӿ
        //transform.position =
        //    Vector3.MoveTowards(transform.position, target, 2f);

        //SmoothDamp : ���� �̵�
        Vector3 velo = Vector3.zero;
        transform.position =
            Vector3.SmoothDamp(transform.position
            , target, ref velo, 0.1f);

        ////3. Lerp : ���� ���� �̵�
        //transform.position =
        //    Vector3.Lerp(transform.position
        //    , target, 0.005f);

        ////4. SLerp : ���� ���� ���� �̵�
        //transform.position =
        //    Vector3.Slerp(transform.position
        //    , target, 0.005f);
    }
}

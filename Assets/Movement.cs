using UnityEngine;

public class Movement : MonoBehaviour
{
    void Start()
    {
        
      
    }
    private void Update()
    {
        //벡터 값 생성 : deltaTime 사용
        Vector3 vec = new Vector3(10 * Input.GetAxisRaw("Vertical") * Time.deltaTime
            , 0, 10 * Input.GetAxisRaw("Horizontal") * Time.deltaTime);
        //벡터 값 생성 : deltatime 미사용
        //Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal") 
        //    , Input.GetAxisRaw("Vertical") , 0); //벡터 값 생성
        transform.Translate(vec);
    }
}

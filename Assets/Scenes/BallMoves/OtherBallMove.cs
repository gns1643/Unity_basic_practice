using UnityEngine;
public class OtherBallMove : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name== "Sphere") // 충돌되는 오브젝트 이름이 Sphere일경우
        {
            mat.color = new Color(0, 0, 0);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Sphere") // 충돌되는 오브젝트 이름이 Sphere일경우
        {
            mat.color = new Color(1, 1, 1);
        }
    }
}

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
        if(collision.gameObject.name== "Sphere") // �浹�Ǵ� ������Ʈ �̸��� Sphere�ϰ��
        {
            mat.color = new Color(0, 0, 0);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Sphere") // �浹�Ǵ� ������Ʈ �̸��� Sphere�ϰ��
        {
            mat.color = new Color(1, 1, 1);
        }
    }
}

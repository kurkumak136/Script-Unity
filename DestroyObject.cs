using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("������� ������");
        //������ ������� ������ � ������ ����
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

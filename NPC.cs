using UnityEngine;

public class NPC : MonoBehaviour
{
    //��������
    int health = 5;

    //������� NPC 
    int level = 1;

    //�������� NPC
    float speed = 1.2f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //���������� ��������
        health += level;

        //����� ��������
        print (health);
    }

    // Update is called once per frame
    void Update()
    {
        //������
        Vector3 newPosition = transform.position;

        newPosition.z += speed * Time.deltaTime;

        transform.position = newPosition;
    }
}

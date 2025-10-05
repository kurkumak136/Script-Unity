using UnityEngine;

public class NPC : MonoBehaviour
{
    //Здоровье
    int health = 5;

    //Уровень NPC 
    int level = 1;

    //Скорость NPC
    float speed = 1.2f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Обновление здоровья
        health += level;

        //Вывод здоровья
        print (health);
    }

    // Update is called once per frame
    void Update()
    {
        //Вперед
        Vector3 newPosition = transform.position;

        newPosition.z += speed * Time.deltaTime;

        transform.position = newPosition;
    }
}

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int health = 100;
    int coins = 0;
    int keys = 0;


    float money = 45.5f;
    string name = "Вася";

    void TakeDamage(int damage)
    {
        health = health - damage;
        Debug.Log("Был нанесен урон колличеством " + damage);

        Debug.Log("Жизней осталось " + health);
        
    }
    void takeHealth(int heal)
    {
        health = health + heal;
      Debug.Log("Был нанесен урон колличеством " +  heal);

      Debug.Log("Жизней осталось " + health);

    }
    void Start()
    {
        TakeDamage(20);
        takeHealth(20);
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

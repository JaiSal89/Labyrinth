using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player: MonoBehaviour
{
    public int health = 3;

    void collidedWithEnemy(Boss enemy)
    {
        enemy.Attack(this);
        if (health <= 0)
        {
            Application.Quit();
        }
    }
    



     void OnCollisionEnter(Collision col)
    {

        Boss enemy = col.collider.gameObject.GetComponent<Boss>();

        if (enemy)
        {
            collidedWithEnemy(enemy);
        }
       
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadSnake : MonoBehaviour
{
  public static int SnakeHealth;
  public GameObject GameoverScreen, SnakeBlood, GameObjectSnake;

  private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Snake"))
        {
           SnakeHealth--;
           if (SnakeHealth <=0)         
               Snake.isDead = true; 
               Instantiate (SnakeBlood, GameObjectSnake.transform.position, GameObjectSnake.transform.rotation);
               Destroy(GameObjectSnake);
               GameoverScreen.SetActive(true);
           }
        }
        
    }


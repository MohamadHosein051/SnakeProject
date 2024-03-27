using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class Snake : MonoBehaviour
{
    public Text point_txt;
    bool eat = false;
    public static bool isDead = false;
    int point = 0;
    public GameObject tailPrefab;
    Vector2 dir = Vector2.right;
    List<Transform> tail = new List<Transform>();
    void Start()
    {
        InvokeRepeating("Move",0.2f,0.3f);
    }
    void Update()
    {
        point_txt.text = "" + point;
        if (!isDead)
        {
            if (Input.GetKey(KeyCode.RightArrow))
                dir = Vector2.right;
            else if (Input.GetKey(KeyCode.DownArrow))
                dir = -Vector2.up;
            else if (Input.GetKey(KeyCode.UpArrow))
                dir = Vector2.up;
            else if (Input.GetKey(KeyCode.LeftArrow))
                dir = -Vector2.right;
        }
        else
        {
            if (Input.GetKey(KeyCode.R))
            {
                tail.Clear();
                transform.position = new Vector3(0,0,0);
                isDead = false;
            }
        }
    }
    void Move()
    {
        Vector2 v = transform.position;
        transform.Translate(dir);
        if (eat)
        {
            GameObject g = (GameObject)Instantiate(tailPrefab, v, Quaternion.identity);
            tail.Insert(0,g.transform);
            eat = false;
        } 
        else if (tail.Count > 0)
        {
            tail.Last().position = v;
            tail.Insert(0,tail.Last());
            tail.RemoveAt(tail.Count - 1);
        }
    }
    private void OnTriggerEnter2D(Collider2D Colltail) 
    {
        if (Colltail.CompareTag("Food"))
        {
            eat = true;
            point++;
            Destroy(Colltail.gameObject);
        }
        else
        {
            isDead = true;
        }
    }
}

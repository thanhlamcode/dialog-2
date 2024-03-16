using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributesManager : MonoBehaviour
{
    public GameObject FloatingTextPrefab;
    private Animator ani;
    public int health;
    public int attack;
    public void Update()
    { 
        if(health == 0)
        {
            Debug.Log("di");
        }    
    }
    public void TakeDamage(int amount)
    {
        if (FloatingTextPrefab && health > 0)
        {
            var go = Instantiate(FloatingTextPrefab, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = amount.ToString();
        }
        health -= amount;

    }     
}

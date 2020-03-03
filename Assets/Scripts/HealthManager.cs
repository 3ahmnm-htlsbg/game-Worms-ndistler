using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public int health = 10;

    [SerializeField] private Text textPlayerLife;

    void Start()
    {
        textPlayerLife.text = health.ToString();
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "DamageBullet")
        {
            health -= 1;
            textPlayerLife.text = health.ToString();
            Destroy(collider.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject batDie;

    private void Start()
    {
        player = GameObject.Find("Player");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.RestartGame();
        }
        if (other.CompareTag("Arrow"))
        {
            Instantiate(batDie,transform.position,Quaternion.identity);
            Destroy(gameObject);
        }
    }
}

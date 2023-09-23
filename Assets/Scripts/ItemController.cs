using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;


public class ItemController : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private float alphaShade= 1;
    [SerializeField] private float timeToDestroy;
    private Vector3 finalPosition;
    private BoxCollider2D boxCollider2D;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        finalPosition = new Vector3 (transform.position.x, transform.position.y+2, 0);
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    public void Update()
    {
        DestroyItem();
    }

    public void DestroyItem()
    {
        if (transform.position.y <= finalPosition.y)
        {
            transform.Translate(Vector2.up * (1 * Time.deltaTime));
        }
        if (boxCollider2D)
        {
            boxCollider2D.enabled = false;
        }
        alphaShade = alphaShade - (.02f / timeToDestroy * Time.timeScale);
        spriteRenderer.color = new UnityEngine.Color(1, 1, 1, alphaShade);
        Destroy(gameObject, timeToDestroy);
    }
}

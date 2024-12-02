using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pack : MonoBehaviour
{

    [SerializeField] Color32 hasPackageColor = new Color32(108, 219, 220, 255);
    [SerializeField] Color32 noPackageColor = new Color32(255, 255, 255, 255);
    [SerializeField] float destroyDelay = 0.5f;

    bool hasPackage;

SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "pack" && hasPackage == false)
        {
            Debug.Log("P has pick up");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }

        if (other.tag == "cus" && hasPackage)
        {
            Debug.Log("pac has delivered");
            spriteRenderer.color = noPackageColor;
            hasPackage = false;
        }
    }
}
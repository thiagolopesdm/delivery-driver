using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
  [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
  [SerializeField] Color32 hasNoPackageColor = new Color32(1, 1, 1, 1);
  [SerializeField] float packageDelay = 0.5f;
  bool hasPackage;
  SpriteRenderer spriteRenderer;

  private void Start()
  {
    spriteRenderer = GetComponent<SpriteRenderer>();
  }
  private void OnCollisionEnter2D(Collision2D other)
  {
    Debug.Log("I hitted something");
  }

  private void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Package" && !hasPackage)
    {
      Debug.Log("Package picked up");
      hasPackage = true;
      spriteRenderer.color = hasPackageColor;
      Destroy(other.gameObject, packageDelay);
    }

    if (other.tag == "Customer" && hasPackage)
    {
      Debug.Log("Packege delivered!");
      hasPackage = false;
      spriteRenderer.color = hasNoPackageColor;
    }

  }
}

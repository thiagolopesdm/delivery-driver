using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
  // should be the same as the car position

  [SerializeField] GameObject objectToFollow;

  void LateUpdate()
  {
    transform.position = objectToFollow.transform.position + new Vector3(0, 0, -10);
  }
}

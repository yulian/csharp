using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject: MonoBehaviour {
  float speed = 20 F;
  
  void Start() {}
  
  void Update() {
    float position = Input.GetAxis("Vertical");
    position = position * speed * Time.deltaTime;
    transform.Translate(Vector3.forward * position);
  }
}

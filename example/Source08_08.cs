using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision: MonoBehaviour {
  public AudioSource collisionSound;
  
  void Start() {
    collisionSound = GetComponent < AudioSource > ();
  }
  
  private void OnCollisionEnter(UnityEngine.Collision collision) {
    collisionSound.Play();
    print("충돌이 발생했습니다");
  }
}

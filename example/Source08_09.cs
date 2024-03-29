using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAnimation: MonoBehaviour {
  public Animator character;
  
  void Start() {
    character = GetComponent < Animator > ();
  }
  
  void Update() {
    if (Input.GetKeyDown(KeyCode.Space)) {
      character.SetTrigger(“ATTACK”);
    }
  }
}

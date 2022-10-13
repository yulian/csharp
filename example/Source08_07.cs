using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision: MonoBehaviour {
  private void OnCollisionEnter(UnityEngine.Collision collision) {
    print("충돌이 발생했습니다");
  }
}

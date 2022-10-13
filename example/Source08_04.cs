using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouse: MonoBehaviour {
  int count = 0;
  
  private void OnMouseDown() {
    count++;
    print("Count: " + count);
  }
}

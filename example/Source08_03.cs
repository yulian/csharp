using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouse: MonoBehaviour {
  private void OnMouseEnter() {
    print("마우스 커서가 들어왔습니다");
  }
  
  private void OnMouseExit() {
    print("마우스 커서가 나갔습니다");
  }
  
  private void OnMouseDown() {
    print("마우스 버튼을 누릅니다");
  }
  
  private void OnMouseUp() {
    print("마우스 버튼을 떼었습니다");
  }
}

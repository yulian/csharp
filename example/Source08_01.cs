using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestClass: MonoBehaviour {
  int iValue;
  float fValue;
  bool bValue;
  string sValue;
  
  void Start() {
    iValue = 50;
    fValue = 100.23 F;
    bValue = true;
    sValue = "Hello~";
    print("iValue : " + iValue);
    print("fValue : " + fValue);
    print("bValue : " + bValue);
    print("sValue : " + sValue);
  }
  
  void Update() {}
}

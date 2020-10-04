/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ClaySharp;

public static class ClayTestStatic
{
    [RuntimeInitializeOnLoadMethod]
    static void Init() {
    dynamic NEW = new ClayFactory();
    var person1 = NEW.Person(); // You can put ANYTHING here: NEW.House(), NEW.Animal(), etc; it's fully dynamic!
    person1.name = "Homer Simpson"; // Likewise here, the properties are dynamically created on the fly; see the README for more!
    Debug.Log(person1.name);
  }
}
*/
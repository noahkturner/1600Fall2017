using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Mammal {

public override void Start() {
        base.Start();
        Facebook();
    }

    void Facebook () {
        print(this.name + " Facebooks");
    }

}

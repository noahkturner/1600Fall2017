using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mammal : Animal {

    public Color furColor = Color.red;
    private Color hairColor = Color.green;
    protected Color BeardColor = Color.cyan;

public override void Start() {
        base.Start();
        LiveBirth();
    }

    void LiveBirth () {
        print(this.name + " Live Births");
    }

}

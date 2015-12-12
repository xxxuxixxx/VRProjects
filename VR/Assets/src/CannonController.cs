using UnityEngine;
using System.Collections;

public class CannonController : BaseObject {
    public GameObject prefab_ball;
    float cannonTime = 0;

	void Start () {
	
	}
	
	void Update () {
        updateCannon();
    }

    void updateCannon() {
        if(cannonTime > 1.0f) {
            CannonBall cb = CannonBall.create(prefab_ball,new Vector3(0,0,-4.0f),4.0f);
            cb.setPosition(getPosition());
            cannonTime = 0;
        }
        else {
            cannonTime += Time.deltaTime;
        }
        
    }
}

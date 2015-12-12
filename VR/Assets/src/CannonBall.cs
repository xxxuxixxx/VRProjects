using UnityEngine;
using System.Collections;

public class CannonBall : BaseObject {
    public Vector3 speedVec = Vector3.zero;
    public float life = 0;
    public float maxLife;
    
    public static CannonBall create(GameObject prefab,Vector3 speedvec,float maxlife) {
        GameObject obj = GameObject.Instantiate(prefab);
        CannonBall c = obj.AddComponent<CannonBall>();
        c.speedVec = speedvec;
        c.maxLife = maxlife;
        return c;
    }

    void Start() {
    }

    void Update() {
        updateTrans();
        updateTime();
    }

    void updateTrans() {
        Vector3 pos = getPosition();
        setPosition(pos + speedVec*Time.deltaTime);
    }

    void updateTime() {
        if(life >= maxLife) {
            Destroy(this.gameObject);
        }
        else {
            life += Time.deltaTime;
        }
    }
}

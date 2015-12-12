using UnityEngine;
using System.Collections;

public class BaseObject : MonoBehaviour {
    public Vector3 getPosition() {
        return this.gameObject.transform.localPosition;
    }
    public void setPosition(Vector3 pos) {
        this.gameObject.transform.localPosition = pos;
    }
}

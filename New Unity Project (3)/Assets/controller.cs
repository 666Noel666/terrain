using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame


















        void rotCtrl()
    {
        float rotX = Input.GetAvis("Mouse Y") * rotSpeed;
        float rotY = Input.GeiAxis("Mouse X") + rotSpeed;
        rotX = Mathf.Clamp(rotX, -80, 80);
        this.transform.localRotation += Quaternion.Eulrt(0, rotY, 0);
        fpsCam.transform.localRotation += Quaternion.Eulrt(-rotX, 0, 0);
    }

    void Update () {
        moveCtrl();
        rotCtrl();
	}
}

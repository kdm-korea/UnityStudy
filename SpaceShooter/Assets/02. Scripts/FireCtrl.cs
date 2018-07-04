using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour {
    //Bullet Prefabs
    public GameObject bullet;
    //Bullet fire Location
    public Transform firePos;

	void Start () {
		
	}
	
	void Update () {
        //Moues leftButtonClick
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
	}

    void Fire()
    {
        //Bullet Prefabs Dynamic produce
        Instantiate(bullet, firePos.position, firePos.rotation);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class PlayerAnim
{
    public AnimationClip idle;
    public AnimationClip runF;
    public AnimationClip runB;
    public AnimationClip runL;
    public AnimationClip runR;
}

public class PlayerCtrl : MonoBehaviour {
    private float h = 0.0f;
    private float v = 0.0f;
    private float r = 0.0f;

    private Transform tr;
    [SerializeField] private float moveSpeed = 10.0f;
    [SerializeField] private float rotSpeed = 80.0f;

    public PlayerAnim playerAnim;
    public PlayerCtrl playerCtrl;
    [HideInInspector] public Animation anim;

    public Image image;

    void Start () {
        Cursor.lockState = CursorLockMode.Locked; //마우스 포인터 제거
        tr = GetComponent<Transform>();
        anim = GetComponent<Animation>();
        //Animation 컴포넌트의 애니메이션 클립을 지정하고 실행
        anim.clip = playerAnim.idle;
        anim.Play();
	}

    void Update() {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        r = Input.GetAxis("Mouse X");

        Debug.Log("h=" + h.ToString());
        Debug.Log("v=" + v.ToString());

        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);

        tr.Translate(moveDir.normalized * moveSpeed * Time.deltaTime, Space.Self);

        tr.Rotate(Vector3.up * rotSpeed * Time.deltaTime * r);

        if(v >= 0.1f)
        {
            anim.CrossFade(playerAnim.runF.name, 0.3f);
        }else if(v <= -0.1f)
        {
            anim.CrossFade(playerAnim.runB.name, 0.3f);
        }else if(h >= 0.1f)
        {
            anim.CrossFade(playerAnim.runR.name, 0.3f);
        }else if(h <= -0.1f)
        {
            anim.CrossFade(playerAnim.runL.name, 0.3f);
        }else
        {
            anim.CrossFade(playerAnim.idle.name, 0.3f);
        }
    }
}


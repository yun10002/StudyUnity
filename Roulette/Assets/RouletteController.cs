using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; //ȸ�� �ӵ�

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Ŭ���� ȸ�� �ӵ� ����
        if (Input.GetMouseButtonDown(0))
            this.rotSpeed = 10;

        //ȸ�� �ӵ���ŭ �귿 ȸ��
        transform.Rotate(0, 0, this.rotSpeed);
        
        //�귿 ����
        this.rotSpeed *= 0.996f;
    }
}

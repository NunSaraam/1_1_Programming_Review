using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ydg_2025_05_15 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ���ڿ� str�� �־��� ��, str�� ����ϴ� �ڵ带 �ۼ��غ�����.
        string s = "Hello World!";
        Debug.Log(s);

        //���� a�� b�� �־����ϴ�. �� ���� �Է¹޾� ����� ���� ���� �������� ����ϴ� �ڵ带 �ۼ��� ������.
        int a = 4;
        int b = 5;
        
        Debug.Log(a);
        Debug.Log(b);

        //���ڿ� str�� ���� n�� �־����ϴ�. str�� n�� �ݺ��� ���ڿ��� ����� ����ϴ� �ڵ带 �ۼ��� ������.
        string sTtring = "strinG";

        int n = 5;

        for (int i = 1; i <= n; i++) 
            Debug.Log(sTtring);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

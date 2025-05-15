using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ydg_2025_05_15 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 문자열 str이 주어질 때, str을 출력하는 코드를 작성해보세요.
        string s = "Hello World!";
        Debug.Log(s);

        //정수 a와 b가 주어집니다. 각 수를 입력받아 입출력 예와 같은 형식으로 출력하는 코드를 작성해 보세요.
        int a = 4;
        int b = 5;
        
        Debug.Log(a);
        Debug.Log(b);

        //문자열 str과 정수 n이 주어집니다. str이 n번 반복된 문자열을 만들어 출력하는 코드를 작성해 보세요.
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

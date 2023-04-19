using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class Save : MonoBehaviour
{
    private StreamWriter sw;

    void Start()
    {
        sw = new StreamWriter(@"SaveData.csv", true, Encoding.GetEncoding("Shift_JIS"));
        string[] s1 = { "stage" };
        string s2 = string.Join(",", s1);
        sw.WriteLine(s2);

        s2 = string.Join(",", "stage1");
        sw.WriteLine(s2);
    }

    public void SaveData(string txt1)
    {
        string[] s1 = { txt1};
        string s2 = string.Join(",", s1);
        sw.WriteLine(s2);
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
          SaveData("stage1");
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            sw.Close();
        }

    }
}


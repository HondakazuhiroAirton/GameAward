using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class Save : MonoBehaviour
{
    private StreamWriter sa;

    void Start()
    {
        sa = new StreamWriter(@"save.csv", true, Encoding.GetEncoding("Shift_JIS"));
        string[] s1 = { "F", "J", "time" };
        string s2 = string.Join(",", s1);
        sa.WriteLine(s2);
    }

    public void SaveData(string txt1)
    {
        string[] s1 = { txt1};
        string s2 = string.Join(",", s1);
        sa.WriteLine(s2);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            sa.Close();
        }

    }
}

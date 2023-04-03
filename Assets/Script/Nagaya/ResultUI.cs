using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultUI : MonoBehaviour
{
    //クリア時に表示するUI
    [SerializeField]
    private GameObject resultUI;

    public GameObject Image;

    // Start is called before the first frame update
    void Start()
    {
        //Fadeの取得
        Image = GameObject.Find("Image");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("k"))
        {

            // パネルUIのアクティブ非アクティブを切り替え
            Active();



        }
        }

    public void Active()
    {
        //パネルUIのアクティブ、非アクティブを切り替え
        resultUI.SetActive(!resultUI.activeSelf);
    }
}

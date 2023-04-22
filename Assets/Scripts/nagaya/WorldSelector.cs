using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class WorldSelector : MonoBehaviour
{

    public Button World1;
    public Button World2;
    public Button World3;
    public Button World4;

    public GameObject Stage1;
    public GameObject Stage2;
    public GameObject Stage3;
    public GameObject Stage4;

    // Start is called before the first frame update
    void Start()
    {

       //最初から選択している状態
       World1.Select();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onButtonWorld1()
    {
        //ワールド１の中身を呼び出す
        Debug.Log("Pushed!");
        Stage1.SetActive(true);
 
    }

    public void onButtonWorld2()
    {
        Stage2.SetActive(true);
    }

    public void onButtonWorld3()
    {
        Stage3.SetActive(true);
    }

    public void onButtonWorld4()
    {
        Stage4.SetActive(true);
    }

    public void onButtonReturn()
    {
        SceneManager.LoadScene("Title(Proto)");
    }
}

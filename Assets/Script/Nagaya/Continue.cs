using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{

    //　ポーズした時に表示するUI
    [SerializeField]
    private GameObject continueUI;

    //ボタン設定
    private Button stageselect;
    private Button retry;
    private Button nextstage;


    // Start is called before the first frame update
    void Start()
    {

    }

    void Awake()
    {
        //ボタンの読み込み
        stageselect = GameObject.Find("ReturnSelect").GetComponent<Button>();
        retry = GameObject.Find("Retry").GetComponent<Button>();
        nextstage = GameObject.Find("NextStage").GetComponent<Button>();

        continueUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("v"))
        {

            // パネルUIのアクティブ非アクティブを切り替え
            Active();

            //ボタンが選択された状態になる
            retry.Select();      

            //　ポーズUIが表示されてる時は停止
            if (continueUI.activeSelf)
            {
                Time.timeScale = 0f;
                //　ポーズUIが表示されてなければ通常通り進行  
            }
            else
            {
                Time.timeScale = 1f;
            }

        }

        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }

    }

    public void ButtonStageSelect()
    {
        SceneManager.LoadScene("StageSelect");
    }

    public void ButtonRetry()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ButtonNextStage()
    {
        SceneManager.LoadScene("GameScene");
    }


   public void Active()
   {
       //パネルUIのアクティブ、非アクティブを切り替え
       continueUI.SetActive(!continueUI.activeSelf);
   }

}

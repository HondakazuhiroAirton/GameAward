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
        //ボタンの読み込み
        stageselect = GameObject.Find("StageSelect").GetComponent<Button>();
        retry = GameObject.Find("Retry").GetComponent<Button>();
        nextstage = GameObject.Find("NextStage").GetComponent<Button>();

        //ボタンが選択された状態になる
        retry.Select();


        continueUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("v"))
        {
           // SetActive();
        // パネルUIのアクティブ非アクティブを切り替え
        continueUI.SetActive(!continueUI.activeSelf);
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

//   public void SetActive()
//   {
//       //パネルUIのアクティブ、非アクティブを切り替え
//       continueUI.SetActive(!continueUI.activeSelf);
//   }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{

    public Button world;

    //�@�|�[�Y�������ɕ\������UI
    [SerializeField]
    private GameObject Stage1UI;
    public GameObject Sel;

    // ���̈ʒu�����Ă����ϐ�
    [SerializeField] private int NowPosition;
    



    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

    }

    public void onButtonStage1_1()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage1_2()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage1_3()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage1_4()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonStage1_5()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void onButtonCancel()
    {
        Sel.SetActive(true);
        world.Select();
        Stage1UI.SetActive(false);
    }
}

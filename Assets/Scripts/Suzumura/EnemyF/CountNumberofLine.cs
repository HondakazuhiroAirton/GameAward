using System;
using System.IO;
using System.Text;

public class CountNumberofLine
{
    // CSVファイルの行数を返す関数
    public static int Main(StageNo nextStageNo)
    {
        // 初期化
        string[] lines = File.ReadAllLines("Assets/ReSources/CSV/enemy11.csv");
        // NextStageの番号で読み込むファイルを分岐する
        switch (nextStageNo)
        {
            case StageNo.Stage1_1:
                lines = File.ReadAllLines("Assets/Resources/CSV/enemy11.csv");
                break;
            case StageNo.Stage1_2:
                lines = File.ReadAllLines("Assets/Resources/CSV/enemy12.csv");
                break;
            case StageNo.Stage1_3:
                lines = File.ReadAllLines("Assets/Resources/CSV/enemy13.csv");
                break;
            case StageNo.Stage1_4:
                lines = File.ReadAllLines("Assets/Resources/CSV/enemy14.csv");
                break;
            case StageNo.Stage1_5:
                lines = File.ReadAllLines("Assets/Resources/CSV/enemy15.csv");
                break;
            case StageNo.Stage2_1:
                lines = File.ReadAllLines("Assets/Resources/CSV/enemy21.csv");
                break;
            case StageNo.Stage2_2:
                lines = File.ReadAllLines("Assets/Resources/CSV/enemy22.csv");
                break;
            case StageNo.Stage2_3:
                lines = File.ReadAllLines("Assets/Resources/CSV/enemy23.csv");
                break;
            case StageNo.Stage2_4:
                lines = File.ReadAllLines("Assets/Resources/CSV/enemy24.csv");
                break;
            case StageNo.Stage2_5:
                lines = File.ReadAllLines("Assets/Resources/CSV/enemy25.csv");
                break;
            case StageNo.Stage3_1:
                lines = File.ReadAllLines("Assets/Resources/CSV/enemy31.csv");
                break;
            case StageNo.Stage3_2:
                lines = File.ReadAllLines("Assets/Resources/CSV/enemy32.csv");
                break;
            case StageNo.Stage3_3:
                lines = File.ReadAllLines("Assets/Resources/CSV/enemy33.csv");
                break;
            case StageNo.Stage3_4:
                lines = File.ReadAllLines("Assets/Resources/CSV/enemy34.csv");
                break;
            case StageNo.Stage3_5:
                lines = File.ReadAllLines("Assets/Resources/CSV/enemy35.csv");
                break;
            case StageNo.Stage4_1:
                lines = File.ReadAllLines("Assets/Resources/CSV/enemy41.csv");
                break;
            case StageNo.Stage4_2:
                lines = File.ReadAllLines("Assets/Resources/CSV/enemy42.csv");
                break;
            case StageNo.Stage4_3:
                lines = File.ReadAllLines("Assets/Resources/CSV/enemy43.csv");
                break;
            case StageNo.Stage4_4:
                lines = File.ReadAllLines("Assets/Resources/CSV/enemy44.csv");
                break;
            case StageNo.Stage4_5:
                lines = File.ReadAllLines("Assets/Resources/CSV/enemy45.csv");
                break;
        }
        return lines.Length - 1;    // ヘッダー分はひいておく
    }
}

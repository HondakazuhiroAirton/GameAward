using System;
using System.IO;
using System.Text;

public class CountNumberofLine
{
    // CSVファイルの行数を返す関数
    public static int Main(StageNo nextStageNo)
    {
        // 初期化
        string[] lines = File.ReadAllLines("GameAward_2023_Data/Resources/CSV/Enemy11.csv");
        // NextStageの番号で読み込むファイルを分岐する
        switch (nextStageNo)
        {
            case StageNo.Stage1_1:
                lines = File.ReadAllLines("GameAward_2023_Data/Resources/CSV/Enemy11.csv");
                break;
            case StageNo.Stage1_2:
                lines = File.ReadAllLines("GameAward_2023_Data/Resources/CSV/Enemy12.csv");
                break;
            case StageNo.Stage1_3:
                lines = File.ReadAllLines("GameAward_2023_Data/Resources/CSV/Enemy13.csv");
                break;
            case StageNo.Stage1_4:
                lines = File.ReadAllLines("GameAward_2023_Data/Resources/CSV/Enemy14.csv");
                break;
            case StageNo.Stage1_5:
                lines = File.ReadAllLines("GameAward_2023_Data/Resources/CSV/Enemy15.csv");
                break;
            case StageNo.Stage2_1:
                lines = File.ReadAllLines("GameAward_2023_Data/Resources/CSV/Enemy21.csv");
                break;
            case StageNo.Stage2_2:
                lines = File.ReadAllLines("GameAward_2023_Data/Resources/CSV/Enemy22.csv");
                break;
            case StageNo.Stage2_3:
                lines = File.ReadAllLines("GameAward_2023_Data/Resources/CSV/Enemy23.csv");
                break;
            case StageNo.Stage2_4:
                lines = File.ReadAllLines("GameAward_2023_Data/Resources/CSV/Enemy24.csv");
                break;
            case StageNo.Stage2_5:
                lines = File.ReadAllLines("GameAward_2023_Data/Resources/CSV/Enemy25.csv");
                break;
            case StageNo.Stage3_1:
                lines = File.ReadAllLines("GameAward_2023_Data/Resources/CSV/Enemy31.csv");
                break;
            case StageNo.Stage3_2:
                lines = File.ReadAllLines("GameAward_2023_Data/Resources/CSV/Enemy32.csv");
                break;
            case StageNo.Stage3_3:
                lines = File.ReadAllLines("GameAward_2023_Data/Resources/CSV/Enemy33.csv");
                break;
            case StageNo.Stage3_4:
                lines = File.ReadAllLines("GameAward_2023_Data/Resources/CSV/Enemy34.csv");
                break;
            case StageNo.Stage3_5:
                lines = File.ReadAllLines("GameAward_2023_Data/Resources/CSV/Enemy35.csv");
                break;
            case StageNo.Stage4_1:
                lines = File.ReadAllLines("GameAward_2023_Data/Resources/CSV/Enemy41.csv");
                break;
            case StageNo.Stage4_2:
                lines = File.ReadAllLines("GameAward_2023_Data/Resources/CSV/Enemy42.csv");
                break;
            case StageNo.Stage4_3:
                lines = File.ReadAllLines("GameAward_2023_Data/Resources/CSV/Enemy43.csv");
                break;
            case StageNo.Stage4_4:
                lines = File.ReadAllLines("GameAward_2023_Data/Resources/CSV/Enemy44.csv");
                break;
            case StageNo.Stage4_5:
                lines = File.ReadAllLines("GameAward_2023_Data/Resources/CSV/Enemy45.csv");
                break;
        }
        return lines.Length - 1;    // ヘッダー分はひいておく
    }
}

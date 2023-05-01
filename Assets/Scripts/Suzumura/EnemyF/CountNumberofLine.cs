using System;
using System.IO;
using System.Text;

public class CountNumberofLine
{
    // CSVファイルの行数を返す関数
    public static int Main(StageNo nextStageNo)
    {
        // 初期化
        string[] lines = File.ReadAllLines("Assets/Scenes/Suzumura/Resources/CSV/Enemy11.csv");
        // NextStageの番号で読み込むファイルを分岐する
        switch (nextStageNo)
        {
            case StageNo.Stage1_1:
                lines = File.ReadAllLines("Assets/Scenes/Suzumura/Resources/CSV/Enemy11.csv");
                break;
            case StageNo.Stage1_2:
                lines = File.ReadAllLines("Assets/Scenes/Suzumura/Resources/CSV/Enemy12.csv");
                break;
        }
        return lines.Length - 1;    // ヘッダー分はひいておく
    }
}

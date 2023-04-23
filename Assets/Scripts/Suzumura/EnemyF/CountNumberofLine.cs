using System;
using System.IO;
using System.Text;


public class CountNumberofLine
{
    public static int Main(StageNo nextStageNo)
    {
        string[] lines = File.ReadAllLines("Assets/Scenes/Suzumura/Resources/CSV/enemy2.csv");
        // csvファイルを読み込ませる
        // NextStageの番号で読み込むファイルを分岐する
        switch (nextStageNo)
        {
            case StageNo.Stage1_1:
                lines = File.ReadAllLines("Assets/Scenes/Suzumura/Resources/CSV/enemy2.csv");
                break;
            case StageNo.Stage1_2:
                lines = File.ReadAllLines("Assets/Scenes/Suzumura/Resources/CSV/enemy.csv");
                break;
        }
        return lines.Length - 1;
    }
}

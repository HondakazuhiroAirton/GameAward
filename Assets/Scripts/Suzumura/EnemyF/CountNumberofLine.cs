using System;
using System.IO;
using System.Text;


public class CountNumberofLine
{
    public static int Main(StageNo nextStageNo)
    {
        string[] lines = File.ReadAllLines("Assets/Scenes/Suzumura/Resources/CSV/enemy2.csv");
        // csv�t�@�C����ǂݍ��܂���
        // NextStage�̔ԍ��œǂݍ��ރt�@�C���𕪊򂷂�
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

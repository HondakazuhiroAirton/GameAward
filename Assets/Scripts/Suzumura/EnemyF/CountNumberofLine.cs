using System;
using System.IO;
using System.Text;

public class CountNumberofLine
{
    // CSV�t�@�C���̍s����Ԃ��֐�
    public static int Main(StageNo nextStageNo)
    {
        // ������
        string[] lines = File.ReadAllLines("Assets/Scenes/Suzumura/Resources/CSV/Enemy11.csv");
        // NextStage�̔ԍ��œǂݍ��ރt�@�C���𕪊򂷂�
        switch (nextStageNo)
        {
            case StageNo.Stage1_1:
                lines = File.ReadAllLines("Assets/Scenes/Suzumura/Resources/CSV/Enemy11.csv");
                break;
            case StageNo.Stage1_2:
                lines = File.ReadAllLines("Assets/Scenes/Suzumura/Resources/CSV/Enemy12.csv");
                break;
        }
        return lines.Length - 1;    // �w�b�_�[���͂Ђ��Ă���
    }
}

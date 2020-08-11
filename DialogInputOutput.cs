using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class DialogInputOutput
{
    public static void Acquaitance()
    {
        //-----------------------Объявление_переменных-----------------------------------------------------------------------------------------------------------------------
        string Name;
        string Answer;
        //-----------------------Манипуляции_с_переменными-------------------------------------------------------------------------------------------------------------------
        Name = Interaction.InputBox("What's your name?", "Acquaitance");
        Answer = "Very nice " + Name + ".";
        //-----------------------Ввод-Вывод----------------------------------------------------------------------------------------------------------------------------------
        MessageBox.Show(Answer, "Acquaitance", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
   
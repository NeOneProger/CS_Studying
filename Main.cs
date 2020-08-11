using System;
using System.Windows.Forms;
using static HelloWorld;
using static DialogOutput;
using static DialogInputOutput;
using static ConsoleInputOutput;
class Studying
{
    static void Main(string[] args)
    {
        HelloWorld.Message();
        DialogInputOutput.Acquaitance();
        ConsoleInputOutput.Acquaitance();
        ConsoleInputOutput.AgeCount();
        DialogOutput.TestOutput();
    }
}
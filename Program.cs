using System;
using System.Windows.Forms;

class Program
{
    [STAThread()]
    static void Main(string[] args)
    {
        Clipboard.Clear();
        Clipboard.SetText(Guid.NewGuid().ToString());
    }
}
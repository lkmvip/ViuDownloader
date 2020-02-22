using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ViuDownloader
{
    /* Console Output is a comsole simulator inside the form */
    class ConsoleOutput
    {
        private static RichTextBox box;
        private static StringBuilder buffer = new StringBuilder();
        private static string lastInput = "";
        private static List<Action> pendingOperations = new List<Action>();
        private static bool waitingForInput = false;

        public static void SetOut(ref RichTextBox textBox)
        {
            box = textBox;
            box.Multiline = true;
            box.KeyDown += Box_KeyDown;
            box.KeyPress += Box_KeyPress;
        }

        public static void Write(string text)
        {
            if(waitingForInput)
            {
                pendingOperations.Add(new Action(() => Write(text)));
                return;
            }
            if (box.InvokeRequired)
                box.Invoke(new Action(() => box.AppendText(text)));
            else
                box.AppendText(text);
        }

        public static void WriteLine(string text)
        {
            if (waitingForInput)
            {
                pendingOperations.Add(new Action(() =>WriteLine(text)));
                return;
            }
            if (box.InvokeRequired)
                box.Invoke(new Action(() => box.AppendText(text + "\n")));
            else
                box.AppendText(text + "\n");
        }

        public static void Clear()
        {
            if (waitingForInput)
            {
                pendingOperations.Add(Clear);
                return;
            }
            if (box.InvokeRequired)
                box.Invoke(new Action(() => box.ResetText()));
            else
                box.ResetText();
        }

        public static string ReadLine()
        {
            for (waitingForInput = true; waitingForInput;);
            return lastInput;
        }

        public static bool AskYN(string question)
        {
            if (box.InvokeRequired)
                box.Invoke(new Action(() => WriteLine(question)));
            else
                WriteLine(question);
            var line = ReadLine();
            return line == "y" || line == "Y";
        }

        private static void Box_KeyDown(object _, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lastInput = buffer.ToString();
                buffer.Clear();
                waitingForInput = false;
                foreach (var ops in pendingOperations)
                    ops();
                pendingOperations.Clear();
            }
        }

        private static void Box_KeyPress(object _, KeyPressEventArgs e)
        {
            if(e.KeyChar != (char)Keys.Enter)
                buffer.Append(e.KeyChar);
        }
    }
}

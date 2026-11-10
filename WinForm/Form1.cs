using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using task1;
using task2;
using task3;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btn_t1.Click += btn_t1_Click;
            btn_t2.Click += btn_t2_Click;
            btn_t3.Click += btn_t3_Click;
        }

        private void SetColor(Control ctrl, string text, Color color)
        {
            ctrl.ForeColor = color;
            ctrl.Text = text;
        }

        private void ShowError(string message, Control focusCtrl = null)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (focusCtrl != null)
            {
                focusCtrl.BackColor = Color.LightPink;
                focusCtrl.Focus();

                if (focusCtrl is TextBox tb)
                    tb.SelectAll();
            }
        }

        private void ClearError(Control ctrl)
        {
            if (ctrl != null)
                ctrl.BackColor = SystemColors.Window;
        }

        private bool TryReadNonEmpty(TextBox tb, string name, out string value)
        {
            value = (tb.Text ?? "").Trim();
            if (value.Length == 0)
            {
                ShowError($"Поле не должно быть пустым ({name})", tb);
                return false;
            }
            ClearError(tb);
            return true;
        }

        private void btn_t1_Click(object sender, EventArgs e)
        {
            if (!TryReadNonEmpty(tb_t1_in, "Выражение", out string expr)) return;

            string res = ClassTask1.SwapPlusMinus(expr);

            ClearError(tb_t1_in);
            SetColor(tb_t1_out, res, Color.DarkGreen);
        }

        private void btn_t2_Click(object sender, EventArgs e)
        {
            if (!TryReadNonEmpty(tb_t2_in, "Последовательность", out string input)) return;

            if (!ClassTask2.TryParseSequence(input, out string[] words, out string error))
            {
                ShowError(error, tb_t2_in);
                return;
            }
            ClearError(tb_t2_in);

            string last = words[words.Length - 1];
            string[] result = ClassTask2.GetRequiredWords(words);

            var sb = new StringBuilder();
            sb.AppendLine("Последнее слово: " + last);
            sb.AppendLine();

            if (result.Length == 0)
            {
                sb.AppendLine("Подходящих слов нет.");
            }
            else
            {
                sb.AppendLine("Подходящие слова:");
                foreach (string w in result)
                    sb.AppendLine(w);
            }

            SetColor(tb_t2_out, sb.ToString(), Color.DarkGreen);
        }

        private void btn_t3_Click(object sender, EventArgs e)
        {
            // тут можно разрешить пустую строку -> 0 слов
            string sentence = tb_t3_in.Text ?? "";

            int count = ClassTask3.CountWords(sentence);

            ClearError(tb_t3_in);
            SetColor(tb_t3_out, count.ToString(), Color.DarkGreen);
        }
    }
}
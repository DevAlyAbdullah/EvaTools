namespace EvaTools
{
    internal class Methods
    {
        public static void TextBoxEnterAndLeave(TextBox textBoxName, string textBoxText)
        {
            if (textBoxName.Text == textBoxText)
            {
                textBoxName.Text = "";
                textBoxName.ForeColor = Color.Black;
            }
            else if (textBoxName.Text == "")
            {
                textBoxName.Text = textBoxText;
                textBoxName.ForeColor = Color.Gray;
            }
        }
    }
}

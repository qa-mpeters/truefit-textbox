namespace truefit_textbox
{
    public partial class TrueFitTextBox : TextBox
    {
        public TrueFitTextBox()
        {
            BackColor = Color.Pink;
            ForeColor = Color.Black;
        }

        public bool HasDecimal { get; set; }
    }
}

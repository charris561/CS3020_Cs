namespace harrisCA2
{
    public partial class Form1 : Form
    {
        public TextBox[,] LetterArray = new TextBox[6, 5];
        public Button guessBtn = new Button();
        public Form1()
        {
            InitializeComponent();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.AutoSize = true;
            InstantiateArray();
            SetGuessButton();
        }

        private void InstantiateArray()
        {
            for (int row = 0; row < LetterArray.GetLength(0); row++)
            {
                for (int col = 0; col < LetterArray.GetLength(1); col++)
                { 
                    TextBox temp = new TextBox();
                    temp.Size = new Size(32, 32);
                    temp.MaxLength = 1;
                    temp.TabIndex = row * LetterArray.GetLength(1) + col;
                    temp.Location = new Point(col * temp.Size.Width, 48 + row * temp.Size.Height);
                    LetterArray[row, col] = temp;
                    this.Controls.Add(temp);
                }
            }
        }
        public void SetGuessButton()
        {
            guessBtn.Size = new Size(LetterArray[0, 0].Size.Width * LetterArray.GetLength(1), 48);
            guessBtn.Location = new Point(0, 48 + LetterArray[0, 0].Size.Height * LetterArray.GetLength(0));
            guessBtn.Text = "Guess";
            this.Controls.Add(guessBtn);
        }
    }
}
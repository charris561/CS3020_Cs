namespace charris4Minesweeper
{
    public partial class Form1 : Form
    {
        Cell[,] cells = new Cell[10,10];
        public Form1()
        {
            InitializeComponent();
            CreateGrid();
            CheckerboardButtons();
        }

        private void CreateGrid()
        {
            for (int row = 0; row < cells.GetLength(0); row++)
            {
                for (int col = 0; col < cells.GetLength(0); col++)
                {
                    cells[row, col] = new Cell();
                    cells[row, col].Button.Click += ButtonClickHandler;
                    cells[row, col].Location = new Point(col * cells[row, col].SizeOfCell, row * cells[row, col].SizeOfCell);
                    this.Controls.Add(cells[row, col]);
                }
            }
        }

        private void CheckerboardButtons()
        {
            for (int row = 0; row < cells.GetLength(0); row++)
            {
                for (int col = 0; col < cells.GetLength(0); col++)
                {
                    cells[row, col].Button.BackColor = ((row + col) % 2 == 0) ? Color.White : Color.Black;
                }
            }
        }
        public void ButtonClickHandler(object? sender, EventArgs e)
        {
            Color targetColor = ((Button)sender).BackColor;
            Random rand = new Random();
            Color newColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            ReplaceColor(targetColor, newColor);
        }
        private void ReplaceColor(Color targetColor, Color newColor)
        {
            for (int row = 0; row < cells.GetLength(0); row++)
            {
                for (int col = 0; col < cells.GetLength(0); col++)
                {
                    if (cells[row, col].Button.BackColor == targetColor)
                    { 
                        cells[row, col].Button.BackColor = newColor;
                    }
                }
            }
        }
    }
}
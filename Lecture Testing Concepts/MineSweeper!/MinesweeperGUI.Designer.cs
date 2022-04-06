namespace MineSweeper_
{
    partial class MinesweeperGUI : Form
    {
        Cell cells;

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

        #endregion

        public void CellClickHandler(object sender, EventArgs e)
        {

            Cell currentCell = (Cell)sender;
            Color targetColor = currentCell.BackColor;

            //check above
            if (currentCell.Row > 0)
            {
                if (targetColor == cells[currentCell.Row - 1, currentCell.Col - 1])
                {
                    Thread.Sleep(100);
                    cells[currentCell.Row - 1, currentCell.Col].PerformClick();
                }
            }
            if (currentCell.Col > 0)
            {
                if (targetColor == cells[currentCell.Row - 1, currentCell.Col - 1])
                {
                    Thread.Sleep(100);
                    cells[currentCell.Row - 1, currentCell.Col - 1].PerformClick();
                }
            }
            if (currentCell.Col < cells.GetLength(1) - 1)
            {
                if (targetColor == cells[currentCell.Row - 1, currentCell.Col - 1])
                {
                    Thread.Sleep(100);
                    cells[currentCell.Row - 1, currentCell.Col - 1].PerformClick();
                }
            }
        }
    }
}
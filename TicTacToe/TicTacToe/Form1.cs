using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace TicTacToe
{
    public partial class MainForm : Form
    {
        private Button[,] gridButtons;
        private bool isXTurn = true;
        private int gridSize;

        public MainForm()
        {
            InitializeComponent();
            btn3x3.Click += (sender, e) => InitializeGrid(3);
            btn5x5.Click += (sender, e) => InitializeGrid(5);
            btn7x7.Click += (sender, e) => InitializeGrid(7);
        }

        private void InitializeGrid(int size)
        {
            gridSize = size;
            ClearGrid();
            HideOtherControls();
            gridButtons = new Button[size, size];
            int buttonSize = 50;
            int spacing = 5;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    gridButtons[i, j] = new Button();
                    gridButtons[i, j].BackColor = Color.White;
                    gridButtons[i, j].ForeColor = Color.Black;
                    gridButtons[i, j].Size = new Size(buttonSize, buttonSize);
                    gridButtons[i, j].Location = new Point((buttonSize + spacing) * j, (buttonSize + spacing) * i);
                    gridButtons[i, j].Click += GridButton_Click;
                    gridButtons[i, j].Font = new Font("Arial", buttonSize / 3, FontStyle.Bold);
                    this.Controls.Add(gridButtons[i, j]);
                }
            }
        }

        private void GridButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (clickedButton.Text == "")
            {
                clickedButton.Text = isXTurn ? "X" : "O";
                isXTurn = !isXTurn;
                if (CheckForWinner())
                {
                    MessageBox.Show(clickedButton.Text + " kazandı!");
                    ResetGame();
                }
            }
        }

        private bool CheckForWinner()
        {
            // Yatay ve dikey kontrol
            for (int i = 0; i < gridSize; i++)
            {
                if (Enumerable.Range(0, gridSize - 2).Any(j => CheckRowCol(gridButtons[i, j].Text, gridButtons[i, j + 1].Text, gridButtons[i, j + 2].Text)) ||
                    Enumerable.Range(0, gridSize - 2).Any(j => CheckRowCol(gridButtons[j, i].Text, gridButtons[j + 1, i].Text, gridButtons[j + 2, i].Text)))
                    return true;
            }

            // Çapraz kontrol
            for (int i = 0; i <= gridSize - 3; i++)
            {
                for (int j = 0; j <= gridSize - 3; j++)
                {
                    if (CheckRowCol(gridButtons[i, j].Text, gridButtons[i + 1, j + 1].Text, gridButtons[i + 2, j + 2].Text) ||
                        CheckRowCol(gridButtons[i, j + 2].Text, gridButtons[i + 1, j + 1].Text, gridButtons[i + 2, j].Text))
                        return true;
                }
            }

            return false;
        }


        private bool CheckRowCol(string c1, string c2, string c3)
        {
            return (c1 != "" && c1 == c2 && c2 == c3);
        }

        private void ClearGrid()
        {
            if (gridButtons != null)
            {
                foreach (Button btn in gridButtons)
                    if (btn != null)
                        this.Controls.Remove(btn);
            }
        }

        private void HideOtherControls()
        {
            btn3x3.Visible = false;
            btn5x5.Visible = false;
            btn7x7.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        private void ResetGame()
        {
            ClearGrid();
            btn3x3.Visible = true;
            btn5x5.Visible = true;
            btn7x7.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
        }


        private void btn3x3_Click(object sender, EventArgs e)
        {
            InitializeGrid(3);
        }

        private void btn5x5_Click(object sender, EventArgs e)
        {
            InitializeGrid(5);
        }

        private void btn7x7_Click(object sender, EventArgs e)
        {
            InitializeGrid(7);
        }
    }
}

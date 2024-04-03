namespace X_and_O
{
  public partial class X_and_O : Form
  {
    Random rnd = new Random();
    int count;
    int i;
    int j;

    enum Symbol
    {
      None,
      X,
      O
    }

    public X_and_O()
    {
      InitializeComponent();
    }

    Symbol[,] Symbols =
    { {Symbol.None, Symbol.None, Symbol.None},
      {Symbol.None, Symbol.None, Symbol.None},
      {Symbol.None, Symbol.None, Symbol.None} };

    private void RestartButton_Click(object sender, EventArgs e)
    {
      Restart();
    }

    public void Restart()
    {
      for (int i = 0; i < 3; i++)
      {
        for (int j = 0; j < 3; j++)
        {
          Symbols[i, j] = Symbol.None;
        }
      }
      ButtonOne.Text = string.Empty;
      ButtonTwo.Text = string.Empty;
      ButtonThree.Text = string.Empty;
      ButtonFour.Text = string.Empty;
      ButtonFive.Text = string.Empty;
      ButtonSix.Text = string.Empty;
      ButtonSeven.Text = string.Empty;
      ButtonEight.Text = string.Empty;
      ButtonEleven.Text = string.Empty;
      count = 0;
    }

    private void ButtonOne_Click(object sender, EventArgs e)
    {
      if (Symbols[0, 0] == Symbol.None)
      {
        Symbols[0, 0] = Symbol.X;
        count++;
        BotMove();
        PrintButtonText();
      }
    }

    private void ButtonTwo_Click(object sender, EventArgs e)
    {
      if (Symbols[0, 1] == Symbol.None)
      {
        Symbols[0, 1] = Symbol.X;
        count++;
        BotMove();
        PrintButtonText();
      }
    }

    private void ButtonThree_Click(object sender, EventArgs e)
    {
      if (Symbols[0, 2] == Symbol.None)
      {
        Symbols[0, 2] = Symbol.X;
        count++;
        BotMove();
        PrintButtonText();
      }
    }

    private void ButtonFour_Click(object sender, EventArgs e)
    {
      if (Symbols[1, 0] == Symbol.None)
      {
        Symbols[1, 0] = Symbol.X;
        count++;
        BotMove();
        PrintButtonText();
      }
    }

    private void ButtonFive_Click(object sender, EventArgs e)
    {
      if (Symbols[1, 1] == Symbol.None)
      {
        Symbols[1, 1] = Symbol.X;
        count++;
        BotMove();
        PrintButtonText();
      }
    }

    private void ButtonSix_Click(object sender, EventArgs e)
    {
      if (Symbols[1, 2] == Symbol.None)
      {
        Symbols[1, 2] = Symbol.X;
        count++;
        BotMove();
        PrintButtonText();
      }
    }

    private void ButtonSeven_Click(object sender, EventArgs e)
    {
      if (Symbols[2, 0] == Symbol.None)
      {
        Symbols[2, 0] = Symbol.X;
        count++;
        BotMove();
        PrintButtonText();
      }
    }

    private void ButtonEight_Click(object sender, EventArgs e)
    {
      if (Symbols[2, 1] == Symbol.None)
      {
        Symbols[2, 1] = Symbol.X;
        count++;
        BotMove();
        PrintButtonText();
      }
    }

    private void ButtonEleven_Click(object sender, EventArgs e)
    {
      if (Symbols[2, 2] == Symbol.None)
      {
        Symbols[2, 2] = Symbol.X;
        count++;
        BotMove();
        PrintButtonText();
      }
    }

    public void BotMove()
    {
      if (count < 5)
      {
        do
        {
          i = rnd.Next(0, 3);
          j = rnd.Next(0, 3);
          if (Symbols[i, j] == Symbol.None)
          {
            Symbols[i, j] = Symbol.O;
            break;
          }
        } while (Symbols[i, j] != Symbol.None);
      }
    }

    public void PrintButtonText()
    {
      if (Symbols[0, 0] == Symbol.X)
      {
        ButtonOne.Text = "X";
      }
      if (Symbols[0, 1] == Symbol.X)
      {
        ButtonTwo.Text = "X";
      }
      if (Symbols[0, 2] == Symbol.X)
      {
        ButtonThree.Text = "X";
      }
      if (Symbols[1, 0] == Symbol.X)
      {
        ButtonFour.Text = "X";
      }
      if (Symbols[1, 1] == Symbol.X)
      {
        ButtonFive.Text = "X";
      }
      if (Symbols[1, 2] == Symbol.X)
      {
        ButtonSix.Text = "X";
      }
      if (Symbols[2, 0] == Symbol.X)
      {
        ButtonSeven.Text = "X";
      }
      if (Symbols[2, 1] == Symbol.X)
      {
        ButtonEight.Text = "X";
      }
      if (Symbols[2, 2] == Symbol.X)
      {
        ButtonEleven.Text = "X";
      }
      if (Symbols[0, 0] == Symbol.O)
      {
        ButtonOne.Text = "O";
      }
      if (Symbols[0, 1] == Symbol.O)
      {
        ButtonTwo.Text = "O";
      }
      if (Symbols[0, 2] == Symbol.O)
      {
        ButtonThree.Text = "O";
      }
      if (Symbols[1, 0] == Symbol.O)
      {
        ButtonFour.Text = "O";
      }
      if (Symbols[1, 1] == Symbol.O)
      {
        ButtonFive.Text = "O";
      }
      if (Symbols[1, 2] == Symbol.O)
      {
        ButtonSix.Text = "O";
      }
      if (Symbols[2, 0] == Symbol.O)
      {
        ButtonSeven.Text = "O";
      }
      if (Symbols[2, 1] == Symbol.O)
      {
        ButtonEight.Text = "O";
      }
      if (Symbols[2, 2] == Symbol.O)
      {
        ButtonEleven.Text = "O";
      }
    }
  }
}

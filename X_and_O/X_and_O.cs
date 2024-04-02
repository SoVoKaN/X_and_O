namespace X_and_O
{
  public partial class X_and_O : Form
  {
    int count;

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
    }

    private void ButtonOne_Click(object sender, EventArgs e)
    {
      if (Symbols[0, 0] == Symbol.None)
      {
        Symbols[0, 0] = Symbol.X;
        count++;
        ButtonOne.Text = "X";
      }
    }

    private void ButtonTwo_Click(object sender, EventArgs e)
    {
      if (Symbols[0, 1] == Symbol.None)
      {
        Symbols[0, 1] = Symbol.X;
        count++;
        ButtonTwo.Text = "X";
      }
    }

    private void ButtonThree_Click(object sender, EventArgs e)
    {
      if (Symbols[0, 2] == Symbol.None)
      {
        Symbols[0, 2] = Symbol.X;
        count++;
        ButtonThree.Text = "X";
      }
    }

    private void ButtonFour_Click(object sender, EventArgs e)
    {
      if (Symbols[1, 0] == Symbol.None)
      {
        Symbols[1, 0] = Symbol.X;
        count++;
        ButtonFour.Text = "X";
      }
    }

    private void ButtonFive_Click(object sender, EventArgs e)
    {
      if (Symbols[1, 1] == Symbol.None)
      {
        Symbols[1, 1] = Symbol.X;
        count++;
        ButtonFive.Text = "X";
      }
    }

    private void ButtonSix_Click(object sender, EventArgs e)
    {
      if (Symbols[1, 2] == Symbol.None)
      {
        Symbols[1, 2] = Symbol.X;
        count++;
        ButtonSix.Text = "X";
      }
    }

    private void ButtonSeven_Click(object sender, EventArgs e)
    {
      if (Symbols[2, 0] == Symbol.None)
      {
        Symbols[2, 0] = Symbol.X;
        count++;
        ButtonSeven.Text = "X";
      }
    }

    private void ButtonEight_Click(object sender, EventArgs e)
    {
      if (Symbols[2, 1] == Symbol.None)
      {
        Symbols[2, 1] = Symbol.X;
        count++;
        ButtonEight.Text = "X";
      }
    }

    private void ButtonEleven_Click(object sender, EventArgs e)
    {
      if (Symbols[2, 2] == Symbol.None)
      {
        Symbols[2, 2] = Symbol.X;
        count++;
        ButtonEleven.Text = "X";
      }
    }
  }
}

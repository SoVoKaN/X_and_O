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

      Buttons[0, 0] = ButtonOne;
      Buttons[0, 1] = ButtonTwo;
      Buttons[0, 2] = ButtonThree;
      Buttons[1, 0] = ButtonFour;
      Buttons[1, 1] = ButtonFive;
      Buttons[1, 2] = ButtonSix;
      Buttons[2, 0] = ButtonSeven;
      Buttons[2, 1] = ButtonEight;
      Buttons[2, 2] = ButtonNine;

      SymbolToString[Symbol.None] = string.Empty;
      SymbolToString[Symbol.X] = "X"; 
      SymbolToString[Symbol.O] = "O";
    }

    Symbol[,] Symbols =
    { {Symbol.None, Symbol.None, Symbol.None},
      {Symbol.None, Symbol.None, Symbol.None},
      {Symbol.None, Symbol.None, Symbol.None} };

    Button[,] Buttons = new Button[3, 3];

    Dictionary<Symbol, string> SymbolToString = new Dictionary<Symbol, string>();

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
          Buttons[i, j].Text = string.Empty;
        }
      }
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

    private void ButtonNine_Click(object sender, EventArgs e)
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
      for (int i = 0; i < 3; i++)
      {
        for (int j = 0; j < 3; j++)
        {
          Buttons[i, j].Text = SymbolToString[Symbols[i, j]];
        }
      }
    }
  }
}
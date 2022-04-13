using System;

namespace ConsoleApp3
{
  internal class Game
  {
    private Func<string> readLine;
    private Action writeLine;

    public Game()
    {
    }

    public Game(Func<string> readLine, Action writeLine)
    {
      this.readLine = readLine;
      this.writeLine = writeLine;
    }

    public void Play()
    {
      throw new NotImplementedException();
    }


  }
}
namespace ConsoleApp3
{
  public class TrieNode
  {

    private bool end = false;
    private static int MAX = 26;
    public TrieNode[] Children = new TrieNode[MAX];

    private int GetCharIndex(char c)
    {
      return c - 'a';
    }

    private TrieNode GetTrieNode(char c)
    {
      return Children[GetCharIndex(c)];
    }

    private void SetTrieNode(char c, TrieNode n)
    {
      Children[GetCharIndex(c)] = n;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="word"></param>
    /// <param name="index"></param>
    public void Add(string word, int index)
    {
      if (word == null)
        return;
      if (index == word.Length)
        return;
      char current = word[index];
      TrieNode child = GetTrieNode(current);
      if (child == null)
      {
        child = new TrieNode();
        SetTrieNode(current, child);
      }

      child.Add(word, index + 1);
    }

    public void Remove(string word)
    {

    }
    public void Print()
    {

    }

    public void AutoComplete()
    {

    }
  }
}

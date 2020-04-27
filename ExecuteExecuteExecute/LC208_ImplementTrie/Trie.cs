using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC208_ImplementTrie
{
  public class Trie
  {
    Node root;

    /** Initialize your data structure here. */
    public Trie()
    {
      root = new Node();
    }

    /** Inserts a word into the trie. */
    public void Insert(string word)
    {      
      Node cur = root;
      foreach (char c in word.ToLower())
      {
        if (!cur.ContainsKey(c))
        {
          cur.Add(c);
        }
        cur = cur.Next(c);
      }
      cur.SetEndOfWord();//
    }

    /** Returns if the word is in the trie. */
    public bool Search(string word)
    {
      Node cur = root;
      foreach (char c in word.ToLower())
      {
        if (!cur.ContainsKey(c))
          return false;
        cur = cur.Next(c);
      }
      return cur.IsEndOfWord();
    }

    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix)
    {
      Node cur = root;
      foreach (char c in prefix)
      {
        if (!cur.ContainsKey(c))
          return false;
        cur = cur.Next(c);
      }
      return true;

    }
  }

  public class Node
  {
    Node[] links;
    bool isEnd;
    int radix = 26;
    public Node()
    {
      links = new Node[radix];
    }
    // add
    // setendofword
    // bool IsEndOfWord
    // get
    // containskey
    // Next
    // GetKey

    public void Add(char c)
    {
      links[c - 'a'] = new Node();
    }
    public void SetEndOfWord()
    {
      isEnd = true;
    }
    public bool IsEndOfWord()
    {
      return isEnd;
    }
    public bool ContainsKey(char c)
    {
      return links[c - 'a'] != null;
    }
    public Node Next(char c)
    {
      return links[c - 'a'];
    }
      
  }

}

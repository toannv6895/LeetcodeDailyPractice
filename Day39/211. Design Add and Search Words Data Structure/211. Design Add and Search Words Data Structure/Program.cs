using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211.Design_Add_and_Search_Words_Data_Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class WordDictionary
    {
        private TrieNode root;
        public WordDictionary()
        {
            root = new TrieNode('*');
        }

        public void AddWord(string word)
        {
            var current = root;
            foreach (var c in word)
            {
                if (!current.Children.TryGetValue(c, out var childNode))
                    current.Children[c] = childNode = new TrieNode(c);
                current = childNode;
            }
            current.IsWord = true;
        }

        public bool Search(string word)
        {
            return SearchHelper(word, 0, root);
        }

        private bool SearchHelper(string word, int idx, TrieNode current)
        {
            if (idx >= word.Length)
            {
                return current.IsWord;
            }

            for (int i = idx; i < word.Length; i++)
            {
                var c = word[i];

                if (c == '.')
                {
                    bool found = false;

                    foreach (var child in current.Children)
                    {
                        found = found || SearchHelper(word, i + 1, child.Value);
                    }

                    return found;
                }
                else if (!current.Children.ContainsKey(c))
                {
                    return false;
                }

                current = current.Children[c];
            }

            return current.IsWord;
        }
    }

    public class TrieNode
    {
        public bool IsWord { get; set; }
        public Dictionary<char, TrieNode> Children { get; set; }

        public TrieNode(char key)
        {
            Children = new Dictionary<char, TrieNode>();
        }
    }
}

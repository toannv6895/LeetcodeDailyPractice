namespace _208_implement_trie_prefix_tree;
class Program
{
    static void Main(string[] args)
    {
        Trie trie = new Trie();

        string[] func = {"Trie", "insert", "search", "search", "startsWith", "insert", "search"};
        string[] words = {"", "apple", "apple", "app", "app", "app", "app"};

        for(int i = 1; i < func.Count(); i++){
            if(func[i] == "insert"){
                trie.insert(words[i]);
            }
            else if(func[i] == "search"){
                bool result = trie.search(words[i]);
                System.Console.WriteLine(result);
            }
            else if(func[i] == "startsWith"){
                bool result = trie.startsWith(words[i]);
                System.Console.WriteLine(result);
            }
        }

        Console.ReadLine();
    }
}

class Trie {
    HashSet<string> ht;

    public Trie() {
        ht = new HashSet<string>();
    }
    
    public void insert(String word) {
        ht.Add(word);
    }
    
    public bool search(String word) {
        return ht.Contains(word);
    }
    
    public bool startsWith(String prefix) {
        foreach (var q in ht)
        {
            if (q.StartsWith(prefix, StringComparison.Ordinal))
            {
                return true;
            }
        }
        return false;
    }
}

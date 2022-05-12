//Question Link:- https://leetcode.com/explore/learn/card/queue-stack/232/practical-application-stack/1392/
/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution 
{
    public Node CloneGraph(Node node) 
    {
        if(node == null)
        {
            return null;
        }
        Dictionary<Node,Node> dict = new Dictionary<Node, Node>();
        dict.Add(node, new Node(node.val));
        HelperDFS(node,dict);
        return dict[node];
    }
    
    private Node HelperDFS(Node node, Dictionary<Node,Node> dict)
    {
        if(node == null)
        {
            return node;
        }
        
        foreach(Node neighbour in  node.neighbors)
        {
            if(!dict.ContainsKey(neighbour))
            {
                dict.Add(neighbour,new Node(neighbour.val));
                HelperDFS(neighbour, dict);
            }
            dict[node].neighbors.Add(dict[neighbour]);
        }
        return node;
    }
    
}

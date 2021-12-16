using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
  public class Graph
  {
    private int Id = 0;
    public class Vertex
    {
      public int Id = 0;
      public Dictionary<string, int> neighbours = new Dictionary<string, int>();
      public LinkedList<Vertex> adjacent = new LinkedList<Vertex>();
      public Vertex(int id)
      {
        this.Id = id;
      }
    }

    public class Node
    {
      public int Id = 0;
      public LinkedList<Node> adjacent = new LinkedList<Node>();
      public Node(int id)
      {
        this.Id = id;
      }
    }
    private Dictionary<string, Vertex> vertices = new Dictionary<string, Vertex>();
    private Dictionary<int, Node> nodeLookUp = new Dictionary<int, Node>();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    private Node GetNode(int id)
    {
      return nodeLookUp.GetValueOrDefault(id);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="source"></param>
    /// <param name="destination"></param>
    private void AddEdge(int source, int destination)
    {
      Node s = GetNode(source);
      Node d = GetNode(destination);
      s.adjacent.AddLast(d);
    }


    public void addVertex(String vname)
    {
      Id++;
      Vertex v = new Vertex(Id);
      vertices.Add(vname, v);
    }

    public void addEdge(String vname1, String vname2, int cost)
    {
      Vertex v1; Vertex v2;
      vertices.TryGetValue(vname1, out v1);
      vertices.TryGetValue(vname2, out v2);

      if (v1 == null || v2 == null || v1.neighbours.ContainsKey(vname2))
        return;
      v1.neighbours.Add(vname2, cost);
      v2.neighbours.Add(vname1, cost);
    }

    public void display()
    {
      Console.WriteLine("--------------");
      List<string> keys = new List<string>(vertices.Keys);
      foreach (String key in keys)
      {
        Vertex vtx;
        vertices.TryGetValue(key, out vtx);
        string str = key + " -> " + string.Join("", vtx.neighbours);
        Console.WriteLine(str);
        Console.WriteLine();
      }
      Console.WriteLine("--------------");
    }

    public void removeEdge(String edge)
    {
      //if (edge == null)
      //  return;
      //Vertex e = vertices.get(edge);
      //vertices.remove(edge, e);

    }

    public bool DFS(string source, HashSet<string> memo, string searchItem)
    {
      if (source == searchItem)
        return true;
      if (memo.Contains(source))
        return false;
      memo.Add(source);
      foreach (Vertex v in vertices.Values)
      {
        return DFS(source, memo, searchItem);
      }
      return false;
    }

    public bool BFS(Vertex source, Vertex destination)
    {
      Queue<Vertex> nextToVisit = new Queue<Vertex>();
      HashSet<int> memo = new HashSet<int>();
      nextToVisit.Enqueue(source);
      while (nextToVisit.Count > 0)
      {
        var node = nextToVisit.Dequeue();
        if (node == destination)
          return true;
        if (memo.Contains(source.Id))
          continue;
        memo.Add(source.Id);
        foreach (var item in node.adjacent)
        {
          nextToVisit.Enqueue(item);
        }

      }
      return true;
    }
  }
}

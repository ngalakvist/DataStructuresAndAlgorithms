using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
  public class Graph
  {
    private class Vertex
    {
      public Dictionary<string, int> neighbours = new Dictionary<string, int>();
    }
    private Dictionary<string, Vertex> vertices = new Dictionary<string, Vertex>();

    public void addVertex(String vname)
    {
      Vertex v = new Vertex();
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

    public bool BFS(List<string> list, string source, string searchItem)
    {
      Queue<string> kö = new Queue<string>();
      HashSet<string> memo = new HashSet<string>();
      kö.Enqueue(list[0]);
      while (kö.Count > 0)
      {
        if (source == searchItem)
          return true;
        if (memo.Contains(source))
          continue;
        memo.Add(source);
      }
      return true;
    }
  }
}

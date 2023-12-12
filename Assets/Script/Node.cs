using UnityEngine;
using System.Collections;

public class Node : IHeapItem<Node>
{

    public bool Ground;
    public Vector3 worldPosition;
    public int gridX;
    public int gridY;

    public int gCost; // gCost is the distance from the starting node
    public int hCost; // hCost is the distance from the ending node
    public Node parent;
    int heapIndex;

    public Node(bool _Ground, Vector3 _worldPos, int _gridX, int _gridY)
    {
        Ground = _Ground;
        worldPosition = _worldPos;
        gridX = _gridX;
        gridY = _gridY;
    }

    public int fCost // fCost is the sum up of gCost and hCost
    {
        get
        {
            return gCost + hCost;
        }
    }

    public int HeapIndex
    {
        get
        {
            return heapIndex;
        }
        set
        {
            heapIndex = value;
        }
    }

    public int CompareTo(Node nodeToCompare)
    {
        int compare = fCost.CompareTo(nodeToCompare.fCost);
        if (compare == 0)
        {
            compare = hCost.CompareTo(nodeToCompare.hCost);
        }
        return -compare;
    }
}

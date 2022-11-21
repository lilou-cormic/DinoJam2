using Godot;
using System;
using System.Collections.Generic;
using System.Linq;

public class TunnelFactory : Node2D
{
    [Export] public PackedScene[] TunnelPrefabs;

    private static TunnelFactory _instance;

    private readonly Queue<int> _queue = new Queue<int>();

    private int _count = 0;

    private Random _random = new Random();

    public TunnelFactory()
    {
        _instance = this;
    }

    public static void InstantiateTunnel(Vector2 position)
    {
        Tunnel newNode = _instance.GetNextTunnel().Instance<Tunnel>();
        newNode.GlobalPosition = position;

        _instance.AddChild(newNode);
    }

    private PackedScene GetNextTunnel()
    {
        if (_queue.Count < 2)
            LoadQueue();

        _count++;

        if (_count % 5 == 0)
            GameManager.SpeedUp();

        int index = _queue.Dequeue();
        return TunnelPrefabs[index];
    }

    private void LoadQueue()
    {
        List<int> indices = GD.Range(Math.Min(_count + 3, TunnelPrefabs.Length)).ToList();

        int prev = _queue.Any() ? _queue.Peek() : 2;
        int i;

        while (indices.Count > 1)
        {
            i = _random.Next(0, indices.Count);

            if (i != prev)
            {
                _queue.Enqueue(indices[i]);

                indices.RemoveAt(i);

                prev = i;
            }
        }

        _queue.Enqueue(indices[0]);
    }
}
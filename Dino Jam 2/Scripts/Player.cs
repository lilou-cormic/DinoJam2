using Godot;
using System;
using System.Runtime.InteropServices;

public class Player : KinematicBody2D
{
    private CollisionShape2D collisionShape;

    private Vector2 velocity = Vector2.Zero;

    public override void _Ready()
    {
        collisionShape = GetChild<CollisionShape2D>(0);
    }

    public override void _PhysicsProcess(float delta)
    {
        velocity = Vector2.Zero;

        if (Input.IsActionPressed("fly"))
        {
            velocity += Vector2.Up * 300;
            GlobalRotationDegrees = -30;
        }
        else
        {
            velocity += Vector2.Down * 100;
            GlobalRotationDegrees = 0;
        }

        MoveAndSlide(velocity);
    }


}

using Godot;
using System;
using System.Runtime.InteropServices;

public class Player : KinematicBody2D
{
    private CollisionShape2D collisionShape;

    private float normalRotation;

    private Vector2 velocity = Vector2.Zero;

    public override void _Ready()
    {
        collisionShape = GetChild<CollisionShape2D>(0);

        normalRotation = GlobalRotationDegrees;
    }

    public override void _PhysicsProcess(float delta)
    {
        velocity = Vector2.Zero;

        if (Input.IsActionPressed("fly"))
        {
            velocity += Vector2.Up * 300;
            GlobalRotationDegrees = normalRotation - 30;
        }
        else
        {
            velocity += Vector2.Down * 100;
            GlobalRotationDegrees = normalRotation;
        }

        MoveAndSlide(velocity);
    }


}

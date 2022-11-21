public class DestroyHorizontal : MoveHorizontal
{
    protected override void ManageReachedLimit()
    {
        QueueFree();
    }
}
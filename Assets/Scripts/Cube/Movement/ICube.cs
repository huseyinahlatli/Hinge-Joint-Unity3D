namespace Cube
{
    public interface ICube
    {
        float Horizontal { get; set; }
        float Vertical { get; set; }
        float Speed { get; set; }

        void Movement();
    }
}


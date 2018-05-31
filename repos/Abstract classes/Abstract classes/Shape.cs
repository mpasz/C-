namespace Abstract_classes
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            System.Console.WriteLine("Shape Copied into clipboard");
        }

        public void Select()
        {
            System.Console.WriteLine("Select shape");
        }
        
    }
}

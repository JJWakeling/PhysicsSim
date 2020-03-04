using Model;

namespace ModelImplementation
{
    public class Rectangle : IRectangle
    {
        private readonly double minX, maxX, minY, maxY;

        public Rectangle(double minX, double maxX, double minY, double maxY)
        {
            this.minX = minX;
            this.maxX = maxX;
            this.minY = minY;
            this.maxY = maxY;
        }

        public IRectangle[] HeightwisePartition(int partitions)
        {
            double partitionHeight = (maxY - minY) / (double)partitions;
            IRectangle[] subRectangles = new IRectangle[partitions];

            for (int i = 0; i < partitions; i++)
            {
                subRectangles[i] = new Rectangle(minX, maxX, minY + i * partitionHeight, minY + (i + 1) * partitionHeight);
            }

            return subRectangles;
        }

        public IRectangle[] WidthwisePartition(int partitions)
        {
            double partitionWidth = (maxX - minX) / (double)partitions;
            IRectangle[] subRectangles = new IRectangle[partitions];

            for (int i = 0; i < partitions; i++)
            {
                subRectangles[i] = new Rectangle(minX + i * partitionWidth, minX + (i + 1) * partitionWidth, minY, maxY);
            }

            return subRectangles;
        }
    }
}

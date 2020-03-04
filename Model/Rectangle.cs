
namespace Model
{
    public interface IRectangle
    {
        IRectangle[] WidthwisePartition(int partitions);

        IRectangle[] HeightwisePartition(int partitions);
    }
}

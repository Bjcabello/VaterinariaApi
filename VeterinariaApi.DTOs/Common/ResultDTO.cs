
namespace VeterinariaApi.DTOs.Common
{
    public class ResultDTO<T>
    {
        public string Message { get; set; } = null!;
        public string MessageException { get; set; } =  null!;
        public Boolean IsSuccess { get; set; }
        public T Item { get; set; } = default!;
        public List<T> Data { get; set; } = new List<T>();

    }
}

namespace Application.Base
{
    public class Result<T>
    {
        public int Page { get; set; }
        public int Qtd { get; set; }
        public int Total { get; set; }
        public ICollection<T> Data { get; set; }

    }
}

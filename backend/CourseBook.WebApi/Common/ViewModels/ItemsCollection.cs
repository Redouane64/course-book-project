namespace CourseBook.WebApi.Common.ViewModels
{
    public class ItemsCollection<T>
    {
        public ItemsCollection(T[] items)
        {
            Items = items;
        }

        public T[] Items { get; }
    }
}

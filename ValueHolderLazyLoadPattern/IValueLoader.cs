namespace ValueHolderLazyLoadPattern
{
    public interface IValueLoader<T>
    {
        T Load();
    }
}
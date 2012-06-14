namespace ProjectEuler.Core
{
    internal static class ItemTypeExtensions
    {
        internal static int GetNumber<T>(this IItemType itemType) where T : BaseAttribute
        {
            T[] attributes = (T[]) itemType.GetType().GetCustomAttributes(typeof(T), true);
            return attributes[0].Number;
        }
    }
}

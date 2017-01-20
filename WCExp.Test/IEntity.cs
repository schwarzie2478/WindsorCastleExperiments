namespace WCExp.Test
{
    public  interface IEntity<TKey>
    {
        TKey Key { get; set; }
    }
}
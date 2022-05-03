namespace Generic;

public class Nullable<T> where T : struct
{
    private readonly object _value;

    public Nullable()
    {
    }

    public Nullable(T value)
    {
        _value = value;
    }

    public bool IsNull => _value == null;

    public T GetDefaultOrNull()
    {
        if (!IsNull)
        {
            return (T) _value;
        }

        return default;
    }
}
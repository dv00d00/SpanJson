﻿namespace SpanJson
{
    public interface IJsonFormatter
    {
    }

    public interface IJsonFormatter<T, in TResolver> : IJsonFormatter
        where TResolver : IJsonFormatterResolver<TResolver>, new()
    {
        void Serialize(ref JsonWriter writer, T value);
        T Deserialize(ref JsonReader reader);
    }
}
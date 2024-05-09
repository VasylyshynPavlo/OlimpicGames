using Newtonsoft.Json;

namespace OlimpicDb.Data
{
    public class ParseStringToIntConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(int);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            int i;
            if (Int32.TryParse(value, out i))
            {
                return i;
            }
            // якщо конвертація не вдалася, повернемо 0 або будь-яке інше значення за замовчуванням
            return 0;
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            serializer.Serialize(writer, untypedValue.ToString());
        }
    }
}

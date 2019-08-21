using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Nota.Alchemy
{

    public class Ingredient : IEquatable<Ingredient>
    {
        public Ingredient(string name, uint order, IEnumerable<string> propertys, AlchemKey alchemieKey)
        {
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.Order = order;
            this.Propertys = propertys?.ToImmutableHashSet() ?? throw new ArgumentNullException(nameof(propertys));
            this.AlchemieKey = alchemieKey;
        }

        public string Name { get; }
        public uint Order { get; }

        public ImmutableHashSet<string> Propertys { get; }

        public AlchemKey AlchemieKey { get; }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Ingredient);
        }

        public bool Equals(Ingredient other)
        {
            return other != null &&
                   this.Name == other.Name &&
                   this.Order == other.Order &&
                   EqualityComparer<ImmutableHashSet<string>>.Default.Equals(this.Propertys, other.Propertys) &&
                   EqualityComparer<AlchemKey>.Default.Equals(this.AlchemieKey, other.AlchemieKey);
        }

        public override int GetHashCode()
        {
            var hashCode = -325981096;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Name);
            hashCode = hashCode * -1521134295 + this.Order.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<ImmutableHashSet<string>>.Default.GetHashCode(this.Propertys);
            hashCode = hashCode * -1521134295 + EqualityComparer<AlchemKey>.Default.GetHashCode(this.AlchemieKey);
            return hashCode;
        }

        public static bool operator ==(Ingredient left, Ingredient right)
        {
            return EqualityComparer<Ingredient>.Default.Equals(left, right);
        }

        public static bool operator !=(Ingredient left, Ingredient right)
        {
            return !(left == right);
        }
    }


    [TypeConverter(typeof(IngredientProcessingConverter))]
    public class IngredientProcessing : IEquatable<IngredientProcessing>
    {

        [DataContract]
        public class Serelizer
        {
            [DataMember]
            public string Name { get; set; }
            [DataMember]
            public int[] NewOrder { get; set; }
            [DataMember]
            public string[] SupportedIngredientPropertys { get; set; }
        }

        public override string ToString()
        {
            return Serelize();
        }

        public string Serelize()
        {
            var instance = new Serelizer()
            {
                Name = this.Name,
                NewOrder = this.NewOrder.ToArray(),
                SupportedIngredientPropertys = this.SupportedIngredientPropertys.OrderBy(x => x).ToArray()
            };

            var serelizer = new DataContractSerializer(typeof(Serelizer));
            using (var stream = new MemoryStream())
            using (var xmlWriter = System.Xml.XmlWriter.Create(stream))
            {
                serelizer.WriteObject(stream, instance);
                return System.Net.WebUtility.HtmlEncode(Encoding.UTF8.GetString(stream.ToArray()));
            }
        }

        public static IngredientProcessing DeSerelize(string input)
        {

            var serelizer = new DataContractSerializer(typeof(Serelizer));
            var stringbuilder = new StringBuilder();
            using (var stringReader = new StringReader(System.Net.WebUtility.HtmlDecode(input)))
            using (var xmlReader = System.Xml.XmlReader.Create(stringReader))
            {
                var instance = (Serelizer)serelizer.ReadObject(xmlReader);
                return new IngredientProcessing(instance.Name, instance.NewOrder, instance.SupportedIngredientPropertys);
            }
        }

        public ImmutableHashSet<string> SupportedIngredientPropertys { get; }

        public string Name { get; }

        public ImmutableArray<int> NewOrder { get; }

        internal AlchemKey Process(AlchemKey alchemieKey)
        {
            var firstPart = new AlchemPack(Get(this.NewOrder[0]), Get(this.NewOrder[1]), Get(this.NewOrder[2]), Get(this.NewOrder[3]));
            var secondPart = new AlchemPack(Get(this.NewOrder[4]), Get(this.NewOrder[5]), Get(this.NewOrder[6]), Get(this.NewOrder[7]));
            var thirdPart = new AlchemPack(Get(this.NewOrder[8]), Get(this.NewOrder[9]), Get(this.NewOrder[10]), Get(this.NewOrder[11]));

            return new AlchemKey(firstPart, secondPart, thirdPart);


            AlchemieDigit Get(int i)
            {
                if (i < 4)
                    return alchemieKey[0][i];
                else if (i < 8)
                    return alchemieKey[1][i - 4];
                else if (i < 12)
                    return alchemieKey[2][i - 8];
                throw new ArgumentOutOfRangeException(nameof(i), i, "must be between 0 and 11 (inclusive)");
            }

        }


        public IngredientProcessing(string name, int newOrder1, int newOrder2, int newOrder3, int newOrder4, int newOrder5, int newOrder6, int newOrder7, int newOrder8, int newOrder9, int newOrder10, int newOrder11, int newOrder12, IEnumerable<string> supportedIngredientPropertys)
        : this(name, new int[] { newOrder1, newOrder2, newOrder3, newOrder4, newOrder5, newOrder6, newOrder7, newOrder8, newOrder9, newOrder10, newOrder11, newOrder12 }, supportedIngredientPropertys) { }

        public IngredientProcessing(string name, int newOrder1, int newOrder2, int newOrder3, int newOrder4, int newOrder5, int newOrder6, int newOrder7, int newOrder8, int newOrder9, int newOrder10, int newOrder11, int newOrder12, params string[] supportedIngredientPropertys)
: this(name, new int[] { newOrder1, newOrder2, newOrder3, newOrder4, newOrder5, newOrder6, newOrder7, newOrder8, newOrder9, newOrder10, newOrder11, newOrder12 }, supportedIngredientPropertys) { }

        public IngredientProcessing(string name, IEnumerable<int> newOrder, IEnumerable<string> supportedIngredientPropertys)
        {
            this.SupportedIngredientPropertys = supportedIngredientPropertys?.ToImmutableHashSet() ?? throw new ArgumentNullException(nameof(supportedIngredientPropertys));
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.NewOrder = newOrder?.ToImmutableArray() ?? throw new ArgumentNullException(nameof(newOrder));
            if (this.NewOrder.Length != 4 * 3)
                throw new ArgumentException($"Must be exactly {4 * 3} elements were {this.NewOrder.Length}");
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as IngredientProcessing);
        }

        public bool Equals(IngredientProcessing other)
        {
            return other != null &&
                   EqualityComparer<ImmutableHashSet<string>>.Default.Equals(this.SupportedIngredientPropertys, other.SupportedIngredientPropertys) &&
                   this.Name == other.Name &&
                   this.NewOrder.Equals(other.NewOrder);
        }

        public override int GetHashCode()
        {
            var hashCode = -1598233379;
            hashCode = hashCode * -1521134295 + EqualityComparer<ImmutableHashSet<string>>.Default.GetHashCode(this.SupportedIngredientPropertys);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<ImmutableArray<int>>.Default.GetHashCode(this.NewOrder);
            return hashCode;
        }


        public static bool operator ==(IngredientProcessing left, IngredientProcessing right)
        {
            return EqualityComparer<IngredientProcessing>.Default.Equals(left, right);
        }

        public static bool operator !=(IngredientProcessing left, IngredientProcessing right)
        {
            return !(left == right);
        }
    }

}

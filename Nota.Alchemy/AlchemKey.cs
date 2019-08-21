using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Nota.Alchemy
{
    public struct AlchemKey : IEnumerable<AlchemPack>
    {
        private readonly AlchemPack digit1;
        private readonly AlchemPack digit2;
        private readonly AlchemPack digit3;


        public AlchemPack this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return this.digit1;

                    case 1:
                        return this.digit2;

                    case 2:
                        return this.digit3;


                    default:
                        throw new ArgumentOutOfRangeException(nameof(index), "Maximum index allowed is 3");
                }
            }
        }

        public AlchemKey(params AlchemPack[] enumerable) : this(enumerable as IEnumerable<AlchemPack>) { }
        public AlchemKey(IEnumerable<AlchemPack> enumerable) : this()
        {
            int index = 0;
            foreach (var item in enumerable)
            {

                switch (index)
                {
                    case 0:
                        this.digit1 = item;
                        break;

                    case 1:
                        this.digit2 = item;
                        break;

                    case 2:
                        this.digit3 = item;
                        break;

                    default:
                        throw new ArgumentException("To many Elements");
                }

                index++;
            }
            if (index < 3)
                throw new ArgumentException("Not enogh Elements");

        }

        public IEnumerator<AlchemPack> GetEnumerator()
        {
            yield return this.digit1;
            yield return this.digit2;
            yield return this.digit3;

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            return $"{this.digit1} {this.digit2} {this.digit3}";
        }

        public static AlchemKey operator +(AlchemKey x, AlchemKey y)
        {
            return new AlchemKey(x.Zip(y, (x1, x2) => x1 + x2));
        }


    }
}

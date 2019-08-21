using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Nota.Alchemy
{
    public struct AlchemPack : IEnumerable<AlchemieDigit>
    {
        private readonly AlchemieDigit digit1;
        private readonly AlchemieDigit digit2;
        private readonly AlchemieDigit digit3;
        private readonly AlchemieDigit digit4;

        public AlchemieDigit this[int index]
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

                    case 3:
                        return this.digit4;

                    default:
                        throw new ArgumentOutOfRangeException(nameof(index), "Maximum index allowed is 3");
                }
            }
        }

        public AlchemPack(AlchemieDigit first, AlchemieDigit seccond, AlchemieDigit thrid, AlchemieDigit forth) : this(new AlchemieDigit[] { first, seccond, thrid, forth }) { }
        public AlchemPack(IEnumerable<AlchemieDigit> enumerable) : this()
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

                    case 3:
                        this.digit4 = item;
                        break;

                    default:
                        throw new ArgumentException("To many Elements");
                }

                index++;
            }
            if (index < 4)
                throw new ArgumentException("Not enogh Elements");

        }

        public int Value
        {
            get => this.digit1.Value + this.digit2.Value + this.digit3.Value + this.digit4.Value;
        }

        public IEnumerator<AlchemieDigit> GetEnumerator()
        {
            yield return this.digit1;
            yield return this.digit2;
            yield return this.digit3;
            yield return this.digit4;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }


        public override string ToString()
        {
            return $"{this.digit1}{this.digit2}{this.digit3}{this.digit4}";
        }

        public static AlchemPack operator +(AlchemPack x, AlchemPack y)
        {
            return new AlchemPack(x.Zip(y, (x1, x2) => x1 + x2));
        }


    }
}

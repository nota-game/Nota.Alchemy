using System;

namespace Nota.Alchemy
{
    public struct AlchemieDigit
    {
        private readonly byte value;

        private const byte EXCLUSIVE_MAX = 16;

        public int Value
        {
            get
            {
                switch (this.value)
                {
                    case 0:
                        return 0;
                    case 1:
                        return 1;
                    case 2:
                        return 1;
                    case 3:
                        return 2;
                    case 4:
                        return 1;
                    case 5:
                        return 2;
                    case 6:
                        return 2;
                    case 7:
                        return 3;
                    case 8:
                        return 1;
                    case 9:
                        return 2;
                    case 10:
                        return 2;
                    case 11:
                        return 3;
                    case 12:
                        return 2;
                    case 13:
                        return 3;
                    case 14:
                        return 3;
                    case 15:
                        return 4;

                    default:
                        throw new InvalidOperationException("Should not happen.");
                }

            }
        }


        private AlchemieDigit(byte value)
        {
            if (value >= EXCLUSIVE_MAX)
                throw new ArgumentException($"Value {value} was to big", nameof(value));
            this.value = value;
        }

        public override string ToString()
        {
            return $"{value:X1}";
        }

        public static implicit operator AlchemieDigit(int value) => new AlchemieDigit((byte)value);
        public static AlchemieDigit operator +(AlchemieDigit x, AlchemieDigit y)
        {
            return new AlchemieDigit((byte)((x.value + y.value) % EXCLUSIVE_MAX));
        }
    }
}

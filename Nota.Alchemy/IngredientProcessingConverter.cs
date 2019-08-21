using System;
using System.ComponentModel;
using System.Globalization;

namespace Nota.Alchemy
{
    internal class IngredientProcessingConverter : TypeConverter
    {


        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string s)
            {
                System.Diagnostics.Debug.WriteLine($"Deserelize \"{s}\"");
                if (s == string.Empty)
                    return null;
                return IngredientProcessing.DeSerelize(s);
            }

            return base.ConvertFrom(context, culture, value);
        }



        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
        }



        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (value is null && destinationType == typeof(string))
            {
                System.Diagnostics.Debug.WriteLine($"Serelize \"\"");

                return string.Empty;
            }
            if (value is IngredientProcessing ingredientProcessing && destinationType == typeof(string))
            {

                var v = ingredientProcessing.Serelize();
                System.Diagnostics.Debug.WriteLine($"Serelize \"{v}\"");

                return v;
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }

    }
}
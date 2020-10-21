using System;
using System.Globalization;

namespace dateTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sbyteValue = 127; // -128 to 127
;           byte byteValue = 255; // 0 to 255
            long longValue = 2147483648L; // recomendado colocar o "simbolo" do tipo da variável no final do valor
            bool boolValue = true;
            char charValue = 'F'; // aceita apenas 1 caracter
            char charUnicodeValue = '\u03B2'; // código unicode de 1 caracter, precisa colocar \u e depois o código unicode
            float floatValue = 4.54321f; // recomendado colocar o "simbolo" do tipo da variável no final do valor
            double doubleValue = 4.5;
            string stringValue = "Bruno Costa"; // string é uma cadeia de caracteres imutavel
            object objectValue = "Teste"; // object é um tipo genérico, ele aceita qualquer coisa

            // alguns tipos de dados tem um atributo dentro de seu objeto chamado MinValue e MaxValue

            Console.WriteLine(sbyteValue);
            Console.WriteLine(byteValue);
            Console.WriteLine(longValue);
            Console.WriteLine(boolValue);
            Console.WriteLine(charValue);
            Console.WriteLine(charUnicodeValue);
            Console.WriteLine(floatValue);
            Console.WriteLine(floatValue.ToString("F2")); // mostra apenas 2 casas decimais e arredonda valores
            Console.WriteLine(floatValue.ToString("F3", CultureInfo.InvariantCulture)); // remove a formatação da cultura de quem está usando
            Console.WriteLine(doubleValue);
            Console.WriteLine(stringValue);
            Console.WriteLine(objectValue);
        }
    }
}

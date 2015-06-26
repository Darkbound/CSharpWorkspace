namespace CoolStuffInCsharp.Extensions
{
    using System;
    using System.Text;

    public static class StringBuilderExtension
    {
        public static StringBuilder Substring(this StringBuilder sb, int startIndex)
        {
            StringBuilder substring = new StringBuilder();

            try
            {
                if (startIndex >= sb.Length)
                {
                    throw new IndexOutOfRangeException();
                }

                for (int i = startIndex; i < sb.Length; i++)
                {
                    substring.Append(sb[i]);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.Write("startIndex is greater than the length of the string\n{0}", e);
            }

            return substring;
        }

        public static StringBuilder Substring(this StringBuilder sb, int startIndex, int length)
        {
            StringBuilder substring = new StringBuilder();

            try
            {
                for (int i = startIndex; i < startIndex + length; i++)
                {
                    substring.Append(sb[i]);
                }

                return substring;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.Write("startIndex is either greater than the length of the string" +
                        "\nor startIndex+length don't reffer to an element within the bounds of the string" +
                        "\n{0}", e);
            }

            return null;
        }
    }
}

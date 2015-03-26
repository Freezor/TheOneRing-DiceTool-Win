#region Using Directives

using System;

#endregion

namespace OneRing_DiceRoll
{
    internal class Log
    {
        /// <summary>
        ///     The CSV File Writer to Write the messages Into
        /// </summary>
        private static readonly CsvWriter CsvFileWriter = new CsvWriter("log.csv");

        /// <summary>
        ///     Write a Message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="tag">Tag must be the Class name and/or the Method Name</param>
        /// <param name="type"></param>
        public static void Write(object message, String tag, DiceType type)
        {
            WriteIntoCsv(message.ToString(), type, tag);
        }

        public static void WriteInfo(object message, String tag)
        {
            WriteIntoCsvInfo(message.ToString(), tag);
        }

        private static void WriteIntoCsv(String message, DiceType type, String tag)
        {
            CsvFileWriter.WriteNewRow(type, DateTime.Now.ToString("dd.MM.yyyy | HH:mm:ss "), message, tag);
        }

        private static void WriteIntoCsvInfo(String message, String tag)
        {
            CsvFileWriter.WriteNewInfoRow(DateTime.Now.ToString("dd.MM.yyyy | HH:mm:ss "), message, tag);
        }
    }
}
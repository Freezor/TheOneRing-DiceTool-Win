#region Using Directives

using System;
using System.IO;
using System.Text;

#endregion

namespace OneRing_DiceRoll
{
    public enum DiceType
    {
        HeroDice,
        AchievementDice
    }

    internal class CsvWriter
    {
        /// <summary>
        ///     The _file of the VSR Writer
        /// </summary>
        private readonly String _file;

        /// <summary>
        ///     Initializes a new instance of the <see cref="CsvFileWriter" /> class.
        /// </summary>
        /// <param name="file">The file.</param>
        public CsvWriter(string file)
        {
            _file = file;
        }

        /// <summary>
        ///     Writes the new row for the logging csv.
        /// </summary>
        /// <param name="type">The type of the Information</param>
        /// <param name="time">The System time.</param>
        /// <param name="message">The message.</param>
        /// <param name="tag">The Tag</param>
        public void WriteNewRow(DiceType type, string time, string message, string tag)
        {
            using (var streamWriter = new StreamWriter(_file, true))
            {
                // the ";" is needed for a new column to be written into
                var builder = new StringBuilder();
                builder.Append(type);
                builder.Append(";");
                builder.Append(tag);
                builder.Append(";");
                builder.Append(time);
                builder.Append(";");
                //Checks if in the message is any char to be replaces
                if (message.IndexOfAny(new[] {'"', ','}) != -1)
                    builder.AppendFormat("\"{0}\"", message.Replace("\"", "\"\""));
                else
                    builder.Append(message);
                streamWriter.WriteLine(builder);
                //Flush Writer at the End to close
                streamWriter.Flush();
            }
        }

        /// <summary>
        ///     Writes the new row.
        /// </summary>
        /// <param name="time">The time.</param>
        /// <param name="message">The message.</param>
        /// <param name="tag">The tag.</param>
        public void WriteNewInfoRow(string time, string message, string tag)
        {
            using (var streamWriter = new StreamWriter(_file, true))
            {
                // the ";" is needed for a new column to be written into
                var builder = new StringBuilder();
                builder.Append("Info");
                builder.Append(";");
                builder.Append(tag);
                builder.Append(";");
                builder.Append(time);
                builder.Append(";");
                //Checks if in the message is any char to be replaces
                if (message.IndexOfAny(new[] {'"', ','}) != -1)
                    builder.AppendFormat("\"{0}\"", message.Replace("\"", "\"\""));
                else
                    builder.Append(message);
                streamWriter.WriteLine(builder);
                //Flush Writer at the End to close
                streamWriter.Flush();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace tech_titans
{
    public class Event
    {
        public string EventID { get; private set; }
        public string EventName { get; private set; }
        public string EventDescription { get; private set; }
        public string EventTime { get; private set; }
        public string EventDate { get; private set; }
        public string EventLocation { get; private set; }
        public string EventImg { get; private set; } // stored file name, e.g. "cdy001.jpg"

        public Event(string eventID, string eventName, string eventDescription,
            string eventTime, string eventDate, string eventLocation, string eventImg)
        {
            EventID = eventID;
            EventName = eventName;
            EventDescription = eventDescription;
            EventTime = eventTime;
            EventDate = eventDate;
            EventLocation = eventLocation;
            EventImg = eventImg;
        }

        public string GetEventDetails()
        {
            return $"{EventName}{Environment.NewLine}" +
                   $"{EventDate} | {EventTime}{Environment.NewLine}" +
                   $"{EventLocation}{Environment.NewLine}{Environment.NewLine}" +
                   $"{EventDescription}";
        }

        /// <summary>
        /// Reads the CSV file and returns the Event matching the given ID, or null if not found.
        /// CSV row format: eventID,eventName,eventDescription,eventTime,eventDate,eventLocation,eventImg
        /// Wrap any field containing a comma (e.g. the description) in double quotes.
        /// </summary>
        public static Event SelectEvent(string eventID, string csvFilePath)
        {
            string[] lines = File.ReadAllLines(csvFilePath);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line) ||
                    line.StartsWith("eventID,", StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                string[] data = SplitCsvLine(line);

                if (data.Length < 7)
                {
                    continue;
                }

                string csvEventID = data[0].Trim();

                if (csvEventID.Equals(eventID, StringComparison.OrdinalIgnoreCase))
                {
                    return new Event(
                        csvEventID,
                        data[1].Trim(),
                        data[2].Trim(),
                        data[3].Trim(),
                        data[4].Trim(),
                        data[5].Trim(),
                        data[6].Trim());
                }
            }

            return null;
        }

        // Splits a CSV line, respecting double-quoted fields that may contain commas
        // (needed because eventDescription is free text and will likely contain them).
        private static string[] SplitCsvLine(string line)
        {
            // Normalize smart/curly quotes (common when a CSV gets edited in Word, Notes, etc.)
            line = line.Replace('\u201C', '"').Replace('\u201D', '"');

            var fields = new List<string>();
            var current = new StringBuilder();
            bool inQuotes = false;

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];

                if (inQuotes)
                {
                    if (c == '"')
                    {
                        if (i + 1 < line.Length && line[i + 1] == '"')
                        {
                            current.Append('"');
                            i++;
                        }
                        else
                        {
                            inQuotes = false;
                        }
                    }
                    else
                    {
                        current.Append(c);
                    }
                }
                else
                {
                    if (c == '"')
                    {
                        inQuotes = true;
                    }
                    else if (c == ',')
                    {
                        fields.Add(current.ToString());
                        current.Clear();
                    }
                    else
                    {
                        current.Append(c);
                    }
                }
            }

            fields.Add(current.ToString());
            return fields.ToArray();
        }
    }
}
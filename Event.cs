using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace tech_titans
{
    public class Event
    {
        // Event properties
        public string EventID { get; private set; }
        public string EventName { get; private set; }
        public string EventDescription { get; private set; }
        public string EventTime { get; private set; }
        public string EventDate { get; private set; }
        public string EventLocation { get; private set; }
        public string EventImg { get; private set; }

        // Price of one ticket
        public int EventPrice { get; private set; }


        // Constructor
        public Event(
            string eventID,
            string eventName,
            string eventDescription,
            string eventTime,
            string eventDate,
            string eventLocation,
            string eventImg,
            int eventPrice)
        {
            EventID = eventID;
            EventName = eventName;
            EventDescription = eventDescription;
            EventTime = eventTime;
            EventDate = eventDate;
            EventLocation = eventLocation;
            EventImg = eventImg;
            EventPrice = eventPrice;
        }


        // Returns event details as text
        public string GetEventDetails()
        {
            return $"{EventName}{Environment.NewLine}" +
                   $"{EventDate} | {EventTime}{Environment.NewLine}" +
                   $"{EventLocation}{Environment.NewLine}" +
                   $"Price: {EventPrice} NZD{Environment.NewLine}{Environment.NewLine}" +
                   $"{EventDescription}";
        }


        // Finds one event from events.csv using event ID
        public static Event SelectEvent(
            string eventID,
            string csvFilePath)
        {
            string[] lines = File.ReadAllLines(csvFilePath);

            foreach (string line in lines)
            {
                // Skip empty lines and header
                if (string.IsNullOrWhiteSpace(line) ||
                    line.StartsWith(
                        "eventID,",
                        StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }


                // Split CSV row
                string[] data = SplitCsvLine(line);


                // We now expect 8 fields
                if (data.Length < 8)
                {
                    continue;
                }


                string csvEventID = data[0].Trim();


                // Check if event ID matches
                if (csvEventID.Equals(
                    eventID,
                    StringComparison.OrdinalIgnoreCase))
                {
                    int price = 0;

                    int.TryParse(
                        data[7].Trim(),
                        out price
                    );


                    return new Event(
                        csvEventID,
                        data[1].Trim(),
                        data[2].Trim(),
                        data[3].Trim(),
                        data[4].Trim(),
                        data[5].Trim(),
                        data[6].Trim(),
                        price
                    );
                }
            }


            // Event not found
            return null;
        }


        // Splits CSV correctly even if
        // description contains commas
        private static string[] SplitCsvLine(string line)
        {
            // Replace curly quotes with normal quotes
            line = line
                .Replace('\u201C', '"')
                .Replace('\u201D', '"');


            List<string> fields =
                new List<string>();

            StringBuilder current =
                new StringBuilder();

            bool inQuotes = false;


            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];


                if (inQuotes)
                {
                    if (c == '"')
                    {
                        // Double quote inside quoted text
                        if (i + 1 < line.Length &&
                            line[i + 1] == '"')
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
                        fields.Add(
                            current.ToString()
                        );

                        current.Clear();
                    }
                    else
                    {
                        current.Append(c);
                    }
                }
            }


            // Add final field
            fields.Add(
                current.ToString()
            );


            return fields.ToArray();
        }
    }
}
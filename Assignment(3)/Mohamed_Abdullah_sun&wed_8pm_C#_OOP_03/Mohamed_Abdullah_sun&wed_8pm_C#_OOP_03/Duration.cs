using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Abdullah_sun_wed_8pm_C__OOP_03
{
    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        // Constructor for Hours, Minutes, Seconds
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            Normalize();
        }

        // Constructor for total seconds
        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
            Normalize();
        }

        // Normalize the time so that Minutes and Seconds are within normal bounds
        private void Normalize()
        {
            if (Seconds >= 60)
            {
                Minutes += Seconds / 60;
                Seconds %= 60;
            }

            if (Minutes >= 60)
            {
                Hours += Minutes / 60;
                Minutes %= 60;
            }

            if (Seconds < 0)
            {
                Minutes -= 1 + (-Seconds / 60);
                Seconds = 60 + (Seconds % 60);
            }

            if (Minutes < 0)
            {
                Hours -= 1 + (-Minutes / 60);
                Minutes = 60 + (Minutes % 60);
            }

            // Handle the case where normalization might lead to negative hours
            if (Hours < 0)
            {
                Hours = 0;
                Minutes = 0;
                Seconds = 0;
            }
        }

        // Override ToString method
        public override string ToString()
        {
            string result = "";
            if (Hours > 0) result += $"Hours: {Hours}, ";
            if (Minutes > 0 || Hours > 0) result += $"Minutes: {Minutes}, ";
            result += $"Seconds: {Seconds}";

            return result.TrimEnd(',', ' ');
        }

        // Override Equals method
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Duration other = (Duration)obj;
            return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
        }

        // Override GetHashCode method
        public override int GetHashCode()
        {
            return (Hours, Minutes, Seconds).GetHashCode();
        }

        // Operator overload for +
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
        }

        // Operator overload for + with seconds (int)
        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(d.Hours, d.Minutes, d.Seconds + seconds);
        }

        public static Duration operator +(int seconds, Duration d)
        {
            return d + seconds;
        }

        // Operator overload for -
        public static Duration operator -(Duration d1, Duration d2)
        {
            int totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalSeconds2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            return new Duration(totalSeconds1 - totalSeconds2);
        }

        // Operator overload for ++ (pre-increment)
        public static Duration operator ++(Duration d)
        {
            return new Duration(d.Hours, d.Minutes + 1, d.Seconds);
        }

        // Operator overload for -- (pre-decrement)
        public static Duration operator --(Duration d)
        {
            return new Duration(d.Hours, d.Minutes - 1, d.Seconds);
        }

        // Operator overload for >
        public static bool operator >(Duration d1, Duration d2)
        {
            return (d1.Hours > d2.Hours) ||
                   (d1.Hours == d2.Hours && d1.Minutes > d2.Minutes) ||
                   (d1.Hours == d2.Hours && d1.Minutes == d2.Minutes && d1.Seconds > d2.Seconds);
        }

        // Operator overload for <
        public static bool operator <(Duration d1, Duration d2)
        {
            return (d1.Hours < d2.Hours) ||
                   (d1.Hours == d2.Hours && d1.Minutes < d2.Minutes) ||
                   (d1.Hours == d2.Hours && d1.Minutes == d2.Minutes && d1.Seconds < d2.Seconds);
        }

        // Operator overload for >=
        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1 > d2 || d1.Equals(d2);
        }

        // Operator overload for <=
        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1 < d2 || d1.Equals(d2);
        }

        // Implicit conversion to bool
        public static implicit operator bool(Duration d)
        {
            return d.Hours != 0 || d.Minutes != 0 || d.Seconds != 0;
        }

        // Explicit conversion to DateTime
        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
        }
    }
}

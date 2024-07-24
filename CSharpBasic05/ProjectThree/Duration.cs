using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic05.ProjectThree
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }

        public int Seconds { get; set; }

        public Duration()
        {

        }
        public Duration(int _x , int _z , int _y) 
        {
            Hours = _x;
            Minutes = _z;
            Seconds = _y;
        }
        public Duration(int _x)
        {
                Hours = _x / 3600;
                _x %= 3600;
                Minutes =_x/60;
                _x %= 60;
                Seconds = _x;
        }

        public override string ToString()
        {
            if(Hours != 0)
            return $"Hours: {Hours} , Minutes : {Minutes} , Seconds : {Seconds}";
            else 
            return $"Minutes : {Minutes} , Seconds : {Seconds}";
        }

        public override bool Equals(object? obj)
        {
            Duration duration = (Duration)obj;

            return ((this?.Hours == duration?.Hours) && (this?.Minutes == duration?.Minutes) && (this?.Seconds == duration?.Seconds));
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static Duration operator + (Duration left , Duration right)
        {
            return new Duration()
            {
                Hours = left.Hours + right.Hours,
                Minutes = left.Minutes + right.Minutes,
                Seconds = left.Seconds + right.Seconds
            };
        }
        public static Duration operator - (Duration left, Duration right)
        {
            return new Duration()
            {
                Hours = left.Hours - right.Hours,
                Minutes = left.Minutes - right.Minutes,
                Seconds = left.Seconds - right.Seconds
            };
        }
        public static Duration operator +(Duration left, int Second)
        {
            Duration right = new Duration(Second);

            return new Duration()
            {
                Hours = left.Hours + right.Hours,
                Minutes = left.Minutes + right.Minutes,
                Seconds = left.Seconds + right.Seconds
            };
        }
        public static Duration operator +(int Second, Duration right)
        {
            Duration left = new Duration(Second);

            return new Duration()
            {
                Hours = left.Hours + right.Hours,
                Minutes = left.Minutes + right.Minutes,
                Seconds = left.Seconds + right.Seconds
            };
        }

        public static Duration operator ++(Duration duration) 
        {
            return new Duration()
            {
                Hours = duration.Hours,
                Minutes = duration.Minutes + 1,
                Seconds = duration.Seconds
            };
        }
        public static Duration operator --(Duration duration)
        {
            return new Duration()
            {
                Hours = duration.Hours,
                Minutes = duration.Minutes - 1,
                Seconds = duration.Seconds
            };
        }

        public static bool operator > (Duration left, Duration right)
        {
            if (left.Hours == right.Hours) 
                if (left.Minutes == right.Minutes)
                    return left.Seconds > right.Seconds;
            if (left.Hours == right.Hours)
                    return left.Minutes > right.Minutes;
            return left.Hours > right.Hours;
        }
        public static bool operator <(Duration left, Duration right)
        {
            if (left.Hours == right.Hours)
                if (left.Minutes == right.Minutes)
                    return left.Seconds < right.Seconds;
            if (left.Hours == right.Hours)
                return left.Minutes < right.Minutes;
            return left.Hours < right.Hours;
        }
        public static bool operator >=(Duration left, Duration right)
        {
            if (left.Hours == right.Hours)
                if (left.Minutes == right.Minutes)
                    return left.Seconds >= right.Seconds;
            if (left.Hours == right.Hours)
                return left.Minutes > right.Minutes;
            return left.Hours > right.Hours;
        }
        public static bool operator <=(Duration left, Duration right)
        {
            if (left.Hours == right.Hours)
                if (left.Minutes == right.Minutes)
                    return left.Seconds <= right.Seconds;
            if (left.Hours == right.Hours)
                return left.Minutes < right.Minutes;
            return left.Hours < right.Hours;
        }

        public static bool operator true (Duration duration)
        {
            return duration != null;
        }
        public static bool operator false (Duration duration)
        {
            return duration == null;
        }

        public static  explicit operator DateTime (Duration duration)
        {
            DateTime currentDate = DateTime.Today;
            return new DateTime(duration.Hours, duration.Minutes, duration.Seconds);
            
        }
    }
}

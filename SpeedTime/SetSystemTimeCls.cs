using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace SpeedTime
{
    namespace BlueFairy
    {
        /// <summary>
        /// SetSystemTimeCls 的摘要说明。
        /// </summary>
        public class SetSystemTimeCls
        {
            public SetSystemTimeCls()
            {

            }

            [StructLayout(LayoutKind.Sequential)]
            public class SystemTime
            {
                public ushort year;
                public ushort month;
                public ushort dayofweek;
                public ushort day;
                public ushort hour;
                public ushort minute;
                public ushort second;
                public ushort milliseconds;
            }

            [DllImport("kernel32")]
            public static extern void GetSystemTime(ref SystemTime stinfo);

            [DllImport("Kernel32.dll")]
            private static extern Boolean SetSystemTime([In, Out] SystemTime st);

            public static bool SetSysTime(DateTime newdatetime)
            {
                newdatetime -= TimeZone.CurrentTimeZone.GetUtcOffset(newdatetime);
                SystemTime st = new SystemTime();
                st.year = Convert.ToUInt16(newdatetime.Year);
                st.month = Convert.ToUInt16(newdatetime.Month);
                st.day = Convert.ToUInt16(newdatetime.Day);
                st.dayofweek = Convert.ToUInt16(newdatetime.DayOfWeek);
                st.hour = Convert.ToUInt16(newdatetime.Hour);
                st.minute = Convert.ToUInt16(newdatetime.Minute);
                st.second = Convert.ToUInt16(newdatetime.Second);
                st.milliseconds = Convert.ToUInt16(newdatetime.Millisecond);

                return SetSystemTime(st);
            }

        }
    }
}

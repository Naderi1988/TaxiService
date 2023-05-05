using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWork
{
  public  class PersianDate
    {
        public static string Topersian(DateTime t)
        {
            PersianCalendar pc = new PersianCalendar();
            var m = pc.GetMonth(t).ToString().Length < 2 ? "0" + pc.GetMonth(t).ToString() : pc.GetMonth(t).ToString();
            var d = pc.GetDayOfMonth(t).ToString().Length < 2 ? "0" + pc.GetDayOfMonth(t).ToString() : pc.GetDayOfMonth(t).ToString();
            return $"{pc.GetYear(t).ToString()}/{m}/{d}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FrameWork
{
   public class RegularExpression
    {
     public   Regex persionLetterRegex = new Regex(@"^[\u0600-\u06FF]+$");
     public   Regex englishLetterRegex = new Regex(@"^[\a-zA-Z]+$");
     public   Regex numberRegex = new Regex(@"^[\0-9]+$");
     public   Regex persionLetterNumberRegex = new Regex(@"^[\0-9-آ-ی]+$");
     public   Regex englishLetterNumberRegex = new Regex(@"^[\0-9a-zA-Z]+$");
    }
}

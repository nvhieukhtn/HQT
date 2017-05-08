using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQT.Core.Model
{
    public class Status
    {
        public static StatusProperties GetStatusProperty(DateTime from, DateTime to)
        {
            var now = DateTime.Now;
            if (from <= now  && now <= to)
                return new StatusProperties("Processing", "Processing", Color.ForestGreen);
            if (now <= from)
                return new StatusProperties("Not started", "NotStarted", Color.DarkGray);
            return new StatusProperties("Expiration", "Expiration", Color.Red);
        }
    }
}

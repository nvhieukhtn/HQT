using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace HQT.Core.Model
{
    public class StatusProperties
    {
        public string Description { get; set; }
        public Color StatusColor { get; set; }
        public string Name { get; set; }

        public StatusProperties(string description, string name, Color color)
        {
            Description = description;
            Name = name;
            StatusColor = color;
        }
    }
}

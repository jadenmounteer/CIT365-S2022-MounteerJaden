using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Mounteer
{

    enum DesktopMaterial
    {
        laminate,
        oak,
        rosewood,
        veneer,
        pine
    }

    internal class Desk
    {
        // Fields
        private double width;
        private double depth;
        private int numberOfDrawers;

        // TODO Include desktop surface material here as type enum
        private DesktopMaterial desktopMaterial;

        // Properties
        public double Width { get { return width; } set { width = value; } }
        public double Depth { get { return depth; } set { depth = value; } }
        public int NumberOfDrawers { get { return numberOfDrawers; } set { numberOfDrawers = value; } }

        // Constructor
        public Desk()
        {
            
        }

    }
}

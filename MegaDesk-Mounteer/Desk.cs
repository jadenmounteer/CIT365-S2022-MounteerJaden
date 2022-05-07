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
        private DesktopMaterial desktopMaterial;

        // Properties
        public double Width { get { return width; } set { width = value; } }
        public double Depth { get { return depth; } set { depth = value; } }
        public int NumberOfDrawers { get { return numberOfDrawers; } set { numberOfDrawers = value; } }

        // Constraints
        const double MAX_WIDTH = 94;
        const double MIN_WIDTH = 24;
        const double MAX_DEPTH = 48;
        const double MIN_DEPTH = 12;

        // Constructor
        public Desk(double width, double depth, int numberOfDrawers) 
        {
            this.Width = width;
            this.Depth = depth;
            this.NumberOfDrawers = numberOfDrawers;
        }

    }
}

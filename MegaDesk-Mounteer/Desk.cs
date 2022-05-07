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

    public class Desk
    {
        // Fields
        private int width;
        private int depth;
        private int numberOfDrawers;
        public string DesktopMaterial;

        // Properties
        public int Width { get { return width; } set { width = value; } }
        public int Depth { get { return depth; } set { depth = value; } }
        public int NumberOfDrawers { get { return numberOfDrawers; } set { numberOfDrawers = value; } }

        // Constraints
        const double MAX_WIDTH = 94;
        const double MIN_WIDTH = 24;
        const double MAX_DEPTH = 48;
        const double MIN_DEPTH = 12;

        // Constructor
        public Desk(int width, int depth, int numberOfDrawers, string desktopMaterial) 
        {
            this.Width = width;
            this.Depth = depth;
            this.NumberOfDrawers = numberOfDrawers;
            this.DesktopMaterial = desktopMaterial;
        }

        public int GetSize()
        {
            return this.Width * this.Depth;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk___Lilly
{
    public enum DesktopMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }
    
    public class Desk
    {

        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public int NumDrawers { get; set; }
        public DesktopMaterial Material { get; set; }
    }
}

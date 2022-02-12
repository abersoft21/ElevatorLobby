using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorLobbySolution
{
    class Program
    {
        static void Main(string[] args)
        {
            // So we need to create an elevator application.
            // This will be built to be freely configurable and extensible
            // from a design viewpoint, probably best to go from outside-in approach and use DI.

            // So we want to centre around the configuration loading then the UI.
            // foreach elevator in the collection create a form or UserControl, and give it it's own controller.
            // the interface of our controllers can be implemented by many controller types;
            // We may want an A&E service style - strict ordering 
            // Or an eco-lift which reorders its requests to the nearest floors
            // Or residential style - reordering new calls during moving is done in its current direction, calls from passed floors are added on return to the 'end'
        }
    }
}

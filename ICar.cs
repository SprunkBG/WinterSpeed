using System;
using System.Collections.Generic;
using System.Text;

namespace CarSpeed
{
    interface ICar
    {

        string tires { get; set; }
        string transmission { get; set; }
        double weight { get; set; }

        int Check4x4Transmisson();

    }
}

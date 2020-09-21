using System;
using System.Collections.Generic;
using System.Text;

namespace WorkwithInterface
{
    interface IFood
    {
        /// <summary>
        /// Name of the food
        /// </summary>
        string Name { get; }
        /// <summary>
        /// Digestion time
        /// </summary>
        int Time { get; }

        int Calories { get; } 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="calories">cerealrations of man</param>
        /// <returns></returns>
        bool Permisson(int calories);


    }
}

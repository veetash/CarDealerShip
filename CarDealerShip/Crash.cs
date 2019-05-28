using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip
{
    /// <summary>
    /// Авария
    /// </summary>
    public class Crash
    {
        public string Description { get; set; }
        public DateTime Date { get; set; }
        /// <summary>
        /// Серьёзная ли авария. Серьёзная, если есть значительные повреждения.
        /// Несерьёзная - мелкое ДТП
        /// </summary>
        public bool IsSerious { get; set; }

        public override string ToString()
        {
            var serious = "Мелкое";
            if (IsSerious)
                serious = "Серьёзное";
            return Date.ToShortDateString() + " (" + serious + ")" + " - " + Description;
        }
    }
}

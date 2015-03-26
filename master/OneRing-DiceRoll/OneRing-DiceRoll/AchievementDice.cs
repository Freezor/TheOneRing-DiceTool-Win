#region Using Directives

using System.Windows.Forms;

#endregion

namespace OneRing_DiceRoll
{
    internal class AchievementDice : Dice.Dice
    {
        public AchievementDice(PictureBox pb, int id)
            : base(pb, 6)
        {
            DiceId = id;
        }

        /// <summary>
        ///     Gets the dice identifier.
        /// </summary>
        /// <value>
        ///     The dice identifier.
        /// </value>
        public int DiceId { get; private set; }
    }
}
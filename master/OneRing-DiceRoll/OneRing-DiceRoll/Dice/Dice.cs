#region Using Directives

using System;
using System.Windows.Forms;

#endregion

namespace OneRing_DiceRoll.Dice
{
    internal class Dice
    {
        /// <summary>
        ///     The _max value
        /// </summary>
        private readonly int _maxValue;

        /// <summary>
        ///     The dice box
        /// </summary>
        public PictureBox DiceBox;

        /// <summary>
        ///     The _dice random
        /// </summary>
        private Random _diceRandom;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Dice" /> class.
        /// </summary>
        /// <param name="pb">The pb.</param>
        /// <param name="max">The maximum.</param>
        public Dice(PictureBox pb, int max)
        {
            _maxValue = max;
            int seed = new Random().Next();
            _diceRandom = new Random(seed);
            DiceBox = pb;
            LastValue = 1;
        }

        /// <summary>
        ///     Gets the last value.
        /// </summary>
        /// <value>
        ///     The last value.
        /// </value>
        public int LastValue { get; private set; }

        /// <summary>
        ///     Throws the dice.
        /// </summary>
        /// <returns></returns>
        public int ThrowDice()
        {
            LastValue = _diceRandom.Next(1, _maxValue + 1);
            return LastValue;
        }

        /// <summary>
        ///     Initializes the random.
        /// </summary>
        public void InitRandom(int seed)
        {
            _diceRandom = new Random(seed);
        }
    }
}
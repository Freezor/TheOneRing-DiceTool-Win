#region Using Directives

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

#endregion

namespace OneRing_DiceRoll
{
    public partial class MainForm : Form
    {
        private readonly List<AchievementDice> _achievementDiceList;

        private readonly Dice.Dice _heroDice;
        private readonly Random _initialRand;
        private int _countAchievingDice;
        private CsvWriter _logCsvWriter;

        public MainForm()
        {
            _initialRand = new Random(new Random().Next());
            InitializeComponent();

            _logCsvWriter = new CsvWriter("log.csv");

            _achievementDiceList = new List<AchievementDice>
            {
                new AchievementDice(achievDice1, 1),
                new AchievementDice(achievDice2, 2),
                new AchievementDice(achievDice3, 3),
                new AchievementDice(achievDice4, 4),
                new AchievementDice(achievDice5, 5),
                new AchievementDice(achievDice6, 6)
            };
            _countAchievingDice = 0;

            _heroDice = new Dice.Dice(pbHeroDice, 12);

            UpdateMaxDice();
            UpdateImages();
        }

        private void bAddDice_Click(object sender, EventArgs e)
        {
            foreach (var dice in _achievementDiceList.Where(dice => dice.DiceBox.Visible == false))
            {
                dice.DiceBox.Visible = true;
                _countAchievingDice++;
                Log.WriteInfo("Add Dice Number" + _countAchievingDice + " to Roll", "Add Dice");
                lDiceCount.Text = _countAchievingDice.ToString(CultureInfo.InvariantCulture);
                dice.InitRandom(_initialRand.Next());
                UpdateMaxDice();
                UpdateImages();
                return;
            }
        }

        /// <summary>
        ///     Handles the Click event of the bRemoveDice control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void bRemoveDice_Click(object sender, EventArgs e)
        {
            foreach (var dice in _achievementDiceList.Where(dice => dice.DiceId == _countAchievingDice))
            {
                dice.DiceBox.Visible = false;
                Log.WriteInfo("Remove Dice Number" + _countAchievingDice + " from Roll", "Remove Dice");
                _countAchievingDice--;
                lDiceCount.Text = _countAchievingDice.ToString(CultureInfo.InvariantCulture);
                UpdateMaxDice();
                return;
            }
        }

        /// <summary>
        ///     Handles the Click event of the bRollDice control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void bRollDice_Click(object sender, EventArgs e)
        {
            var tengwa = 0;
            var sum = 0;
            var rune = "";

            //Throw dice for each active dice
            foreach (var erg in from dice in _achievementDiceList where dice.DiceBox.Visible select dice.ThrowDice())
            {
                Log.Write(erg.ToString(CultureInfo.InvariantCulture), "Roll", DiceType.AchievementDice);
                sum += erg;
                if (erg != 6) continue;
                tengwa++;
                Log.WriteInfo("New Tengwa sign: " + tengwa, "Roll");
            }

            tbTengwa.Text = tengwa.ToString(CultureInfo.InvariantCulture);

            var ergHero = _heroDice.ThrowDice();
            Log.Write(ergHero.ToString(CultureInfo.InvariantCulture), "Roll", DiceType.HeroDice);

            //Set the name of the rune if rolled
            if (ergHero == 11) rune = "Eye of Saurons";
            if (ergHero == 12) rune = "Gandalf Rune";

            tbRune.Text = rune;

            sum += ergHero;

            int actval = 0;
            if (!tbRolledValue.Text.Equals(""))
            {
                actval = Convert.ToInt32(tbRolledValue.Text);
            }
            //If the actual value is the same as the last roll try again
            if (sum == actval)
            {
                bRollDice_Click(sender, e);
                Log.WriteInfo("Sum of dice is same as before" + sum + "|" + actval, "roll");
            }
            else
            {
                tbRolledValue.Text = sum.ToString(CultureInfo.InvariantCulture);
            }

            UpdateImages();

            ShowResult(sum);
        }

        /// <summary>
        ///     Shows the result.
        /// </summary>
        private void ShowResult(int sum)
        {
            //Check the roll result
            var achiev = 0;
            achiev = tbAchievingValue.Text.Equals("") ? 0 : Convert.ToInt32(tbAchievingValue.Text);
            var tengwa = Convert.ToInt32(tbTengwa.Text);
            var resultString = "";

            if (sum > achiev)
            {
                if (tengwa == 1)
                {
                    resultString = "Good Success";
                    Log.WriteInfo("Dice got a good Success", "Result");
                }
                else if (tengwa > 1)
                {
                    resultString = "Extreme Success";
                    Log.WriteInfo("Dice got a extreme Success", "Result");
                }
                resultString = "Success";
                Log.WriteInfo("Dice got a Success", "Result");
            }
            else if (sum < achiev)
            {
                resultString = "Failure";
                Log.WriteInfo("Dice got a Failure", "Result");
            }

            tbResult.Text = resultString;
        }

        /// <summary>
        ///     Updates the images.
        /// </summary>
        private void UpdateImages()
        {
            var path = Directory.GetCurrentDirectory();

            //Change the image for each active dice for the rand avlue
            foreach (AchievementDice dice in _achievementDiceList)
            {
                if (dice.DiceBox.Visible)
                {
                    int value = dice.LastValue;
                    switch (value)
                    {
                        case 1:
                            dice.DiceBox.Image = Image.FromFile(@"Images\Achieve\1.png");
                            break;
                        case 2:
                            dice.DiceBox.Image = Image.FromFile(@"Images\Achieve\2.png");
                            break;
                        case 3:
                            dice.DiceBox.Image = Image.FromFile(@"Images\Achieve\3.png");
                            break;
                        case 4:
                            dice.DiceBox.Image = Image.FromFile(@"Images\Achieve\4.png");
                            break;
                        case 5:
                            dice.DiceBox.Image = Image.FromFile(@"Images\Achieve\5.png");
                            break;
                        case 6:
                            dice.DiceBox.Image = Image.FromFile(@"Images\Achieve\6.png");
                            break;
                        default:
                            dice.DiceBox.Image = Image.FromFile(@"Images\Achieve\1.png");
                            break;
                    }
                }
            }

            int hvalue = _heroDice.LastValue;
            switch (hvalue)
            {
                case 1:
                    _heroDice.DiceBox.Image = Image.FromFile(@"Images\Hero\1.png");
                    break;
                case 2:
                    _heroDice.DiceBox.Image = Image.FromFile(@"Images\Hero\2.png");
                    break;
                case 3:
                    _heroDice.DiceBox.Image = Image.FromFile(@"Images\Hero\3.png");
                    break;
                case 4:
                    _heroDice.DiceBox.Image = Image.FromFile(@"Images\Hero\4.png");
                    break;
                case 5:
                    _heroDice.DiceBox.Image = Image.FromFile(@"Images\Hero\5.png");
                    break;
                case 6:
                    _heroDice.DiceBox.Image = Image.FromFile(@"Images\Hero\6.png");
                    break;
                case 7:
                    _heroDice.DiceBox.Image = Image.FromFile(@"Images\Hero\7.png");
                    break;
                case 8:
                    _heroDice.DiceBox.Image = Image.FromFile(@"Images\Hero\8.png");
                    break;
                case 9:
                    _heroDice.DiceBox.Image = Image.FromFile(@"Images\Hero\9.png");
                    break;
                case 10:
                    _heroDice.DiceBox.Image = Image.FromFile(@"Images\Hero\10.png");
                    break;
                case 11:
                    _heroDice.DiceBox.Image = Image.FromFile(@"Images\Hero\11.png");
                    break;
                case 12:
                    _heroDice.DiceBox.Image = Image.FromFile(@"Images\Hero\12.png");
                    break;
                default:
                    _heroDice.DiceBox.Image = Image.FromFile(@"Images\Hero\1.png");
                    break;
            }
        }

        /// <summary>
        ///     Updates the maximum dice amount.
        /// </summary>
        private void UpdateMaxDice()
        {
            //Max Dice value. 10 For d12 value 11 & 12 are reserved
            int maxDice = 10 +
                          _achievementDiceList.Where(achievementDice => achievementDice.DiceBox.Visible)
                              .Sum(achievementDice => 6);

            Log.WriteInfo("Update max Dice Count to " + maxDice, "Dice Update");

            tbMaxDice.Text = maxDice.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        ///     Handles the Click event of the bInitRandoms control.
        ///     Initialise alle Dice
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void bInitRandoms_Click(object sender, EventArgs e)
        {
            foreach (var dice in _achievementDiceList)
            {
                dice.InitRandom(_initialRand.Next());
            }
            _heroDice.InitRandom(_initialRand.Next());
        }
    }
}
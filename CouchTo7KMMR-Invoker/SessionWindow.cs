using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CouchTo7KMMR_Invoker
{
    public partial class SessionWindow : Form
    {
        Int32 ticks = 0;
        Int32 score = 0;
        /* Session settings */
        Int32 sessionLength;
        Dictionary<Spells, Spells[]> spellComponents;
        List<Spells> spells;
        Dictionary<Spells, char> hotkeyMapping;
        bool requireInvokeClick, requireSkillClick;
        Random rand;
        /* Training session */
        bool trainingInSession = false;
        Queue<char> keySequence;
        public SessionWindow(List<Spells> enabledSpells, Int32 sessionLength, bool requireInvokeClick, bool requireSkillClick,
            Dictionary<Spells, Spells[]> spellComponents, Dictionary<Spells, char> hotkeyMapping)
        {
            InitializeComponent();
            this.spells = enabledSpells;
            this.sessionLength = sessionLength;
            this.spellComponents = spellComponents;
            this.hotkeyMapping = hotkeyMapping;
            this.requireInvokeClick = requireInvokeClick;
            this.requireSkillClick = requireSkillClick;
            this.keySequence = new Queue<char>();
            this.rand = new Random();
        }

        private void timeElapsedTimer_Tick(object sender, EventArgs e)
        {
            this.timeElapsedLabel.Text = "Time Elapsed: " + ticks.ToString();
            this.ticks++;
            if (ticks == this.sessionLength)
            {
                timeElapsedLabel.Text = "Time Elapsed: " + ticks.ToString() + ", Session Ended.";
                ticks = 0;
                this.timeElapsedTimer.Stop();
                trainingInSession = false;
            }
        }

        private bool TrainingInstance(Spells spell)
        {
            string spellName = spell.ToString();
            char firstComponent = hotkeyMapping[spellComponents[spell][0]];
            char secondComponent = hotkeyMapping[spellComponents[spell][1]];
            char thirdComponent = hotkeyMapping[spellComponents[spell][2]];
            this.invokeLabel.Text = spellName;
            this.firstKeyLabel.Text = firstComponent.ToString();
            this.secondKeyLabel.Text = secondComponent.ToString();
            this.thirdKeyLabel.Text = thirdComponent.ToString();
            this.firstKeyLabel.ForeColor = Color.Red;
            this.secondKeyLabel.ForeColor = Color.Red;
            this.thirdKeyLabel.ForeColor = Color.Red;
            /* Queue items */
            this.keySequence.Enqueue(firstComponent);
            this.keySequence.Enqueue(secondComponent);
            this.keySequence.Enqueue(thirdComponent);

            if (this.requireInvokeClick)
            {
                this.fourthKeyLabel.ForeColor = Color.Red;
                this.fourthKeyLabel.Text = hotkeyMapping[Spells.Invoke].ToString();
                this.keySequence.Enqueue(hotkeyMapping[Spells.Invoke]);
            }
            if (this.requireSkillClick)
            {
                this.fifthKeyLabel.ForeColor = Color.Red;
                this.fifthKeyLabel.Text = hotkeyMapping[spell].ToString();
                this.keySequence.Enqueue(hotkeyMapping[spell]);
            }
            return true;
        } 

        private void startButton_Click(object sender, EventArgs e)
        {
            score = 0;
            this.timeElapsedTimer.Start();
            trainingInSession = true;
            while (keySequence.Count != 0) { keySequence.Dequeue(); }
            TrainingInstance(GetRandomSpell());
        }

        private void SessionWindow_Load(object sender, EventArgs e)
        {

        }

        private Spells GetRandomSpell()
        {
            return this.spells[rand.Next(this.spells.Count)];
        }
        public void onKeyPress(object sender, KeyEventArgs e)
        {
            if (!trainingInSession) return;
            char nextKey = this.keySequence.Peek();
            if (String.Compare(nextKey.ToString(), e.KeyData.ToString(), true) == 0)
            {
                this.keySequence.Dequeue();
                int maxkeys = 3;
                if (this.requireSkillClick) { maxkeys++; }
                if (this.requireInvokeClick) { maxkeys++; }
                if (this.keySequence.Count == maxkeys - 1)
                {
                    this.firstKeyLabel.ForeColor = Color.Green;
                }
                if (this.keySequence.Count == maxkeys - 2)
                {
                    this.secondKeyLabel.ForeColor = Color.Green;
                }
                if (this.keySequence.Count == maxkeys - 3)
                {
                    this.thirdKeyLabel.ForeColor = Color.Green;
                }
                if (this.keySequence.Count == maxkeys - 4)
                {
                    if (this.requireSkillClick)
                    {
                        this.fourthKeyLabel.ForeColor = Color.Green;
                    }
                }
                if (this.keySequence.Count == 0 && trainingInSession)
                {
                    this.score++;
                    this.scoreLabel.Text = "Score: " + this.score.ToString();
                    TrainingInstance(GetRandomSpell());
                }
            }
        }
    }
}

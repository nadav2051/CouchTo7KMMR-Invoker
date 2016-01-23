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
    public enum Spells
    {
        Quas = 0,
        Wex,
        Exort,
        Invoke,
        ColdSnap,
        GhostWalk,
        IceWall,
        EMP,
        Tornado,
        Alacrity,
        SunStrike,
        ForgeSpirit,
        ChaosMeteor,
        DeafeningBlast,
        MaximumSpells
    }


    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            setLegacyHotkeys();
        }

        private void setLegacyHotkeys()
        {
            this.quasHotkeyLabel.Text = "Q";
            this.wexHotkeyLabel.Text = "W";
            this.exortHotkeyLabel.Text = "E";
            this.invokeHotkeyLabel.Text = "R";
            this.coldsnapHotkeyLabel.Text = "Y";
            this.ghostwalkHotkeyLabel.Text = "V";
            this.icewallHotkeyLabel.Text = "W";
            this.empHotkeyLabel.Text = "C";
            this.tornadoHotkeyLabel.Text = "X";
            this.alacrityHotkeyLabel.Text = "Z";
            this.sunstrikeHotkeyLabel.Text = "T";
            this.forgespiritHotkeyLabel.Text = "F";
            this.chaosmeteorHotkeyLabel.Text = "D";
            this.deafeningblastHotkeyLabel.Text = "B";

        }

        #region Bind Hotkey Buttons
        private void quasSetHotkeyButton_Click(object sender, EventArgs e)
        {
            hotkeyLogger(quasHotkeyLabel);
        }

        private void wexSetHotkeyButton_Click(object sender, EventArgs e)
        {
            hotkeyLogger(wexHotkeyLabel);
        }

        private void exortSetHotkeyButton_Click(object sender, EventArgs e)
        {
            hotkeyLogger(exortHotkeyLabel);
        }

        private void invokeSetHotkeyButton_Click(object sender, EventArgs e)
        {
            hotkeyLogger(invokeHotkeyLabel);
        }

        private void coldsnapSetHotkeyButton_Click(object sender, EventArgs e)
        {
            hotkeyLogger(coldsnapHotkeyLabel);
        }

        private void ghostwalkSetHotkeyButton_Click(object sender, EventArgs e)
        {
            hotkeyLogger(ghostwalkHotkeyLabel);
        }

        private void icewallSetHotkeyButton_Click(object sender, EventArgs e)
        {
            hotkeyLogger(icewallHotkeyLabel);
        }

        private void empSetHotkeyButton_Click(object sender, EventArgs e)
        {
            hotkeyLogger(empHotkeyLabel);
        }
        private void tornadoSetHotkeyButton_Click(object sender, EventArgs e)
        {
            hotkeyLogger(tornadoHotkeyLabel);
        }

        private void alacritySetHotkeyButton_Click(object sender, EventArgs e)
        {
            hotkeyLogger(alacrityHotkeyLabel);
        }

        private void sunstrikeSetHotkeyButton_Click(object sender, EventArgs e)
        {
            hotkeyLogger(sunstrikeHotkeyLabel);
        }

        private void forgespiritSetHotkeyButton_Click(object sender, EventArgs e)
        {
            hotkeyLogger(forgespiritHotkeyLabel);
        }

        private void chaosmeteorSetHotkeyButton_Click(object sender, EventArgs e)
        {
            hotkeyLogger(chaosmeteorHotkeyLabel);
        }

        private void deafeningblastSetHotkeyButton_Click(object sender, EventArgs e)
        {
            hotkeyLogger(deafeningblastHotkeyLabel);
        }

        #endregion

        private void hotkeyLogger(TextBox targetTextbox)
        {
            HotkeyCapture keyListener = new HotkeyCapture(targetTextbox);
            keyListener.Show();
        }

        private void startSession_Click(object sender, EventArgs e)
        {
            /* These two are hard-coded into since I don't really think valve is going to change those components any time soon. */
            Dictionary<Spells, Spells[]> spellComponents = fetchSpellsComponents();
            Dictionary<Spells, char> mapping = fetchHotkeyMapping();
            List<Spells> enabledSpells = fetchEnabledSpells();

            Int32 sessionLength = Int32.Parse(this.sessionLengthTextbox.Text);
            bool requireInvokeClick = this.requireInvocationEnabledCheckbox.Checked;
            bool requireSkillClick = this.requireSkillEnabledCheckbox.Checked;
            SessionWindow session = new SessionWindow(enabledSpells, sessionLength, requireInvokeClick, requireSkillClick, spellComponents, mapping);
            session.Show();
        }

        private Dictionary<Spells, char> fetchHotkeyMapping()
        {
            Dictionary < Spells, char> mapping = new Dictionary<Spells, char>();
            mapping.Add(Spells.Quas, this.quasHotkeyLabel.Text[0]);
            mapping.Add(Spells.Wex, this.wexHotkeyLabel.Text[0]);
            mapping.Add(Spells.Exort, this.exortHotkeyLabel.Text[0]);
            mapping.Add(Spells.Invoke, this.invokeHotkeyLabel.Text[0]);
            mapping.Add(Spells.ColdSnap, this.coldsnapHotkeyLabel.Text[0]);
            mapping.Add(Spells.GhostWalk, this.ghostwalkHotkeyLabel.Text[0]);
            mapping.Add(Spells.IceWall, this.icewallHotkeyLabel.Text[0]);
            mapping.Add(Spells.EMP, this.empHotkeyLabel.Text[0]);
            mapping.Add(Spells.Tornado, this.tornadoHotkeyLabel.Text[0]);
            mapping.Add(Spells.Alacrity, this.alacrityHotkeyLabel.Text[0]);
            mapping.Add(Spells.SunStrike, this.sunstrikeHotkeyLabel.Text[0]);
            mapping.Add(Spells.ForgeSpirit, this.forgespiritHotkeyLabel.Text[0]);
            mapping.Add(Spells.ChaosMeteor, this.chaosmeteorHotkeyLabel.Text[0]);
            mapping.Add(Spells.DeafeningBlast, this.deafeningblastHotkeyLabel.Text[0]);
            return mapping;
        }
        private Dictionary<Spells, Spells[]> fetchSpellsComponents()
        {
            Dictionary < Spells, Spells[]> spellComps = new Dictionary<Spells, Spells[]> ();
            /* Add spells components to array. */
            spellComps.Add(Spells.ColdSnap, new Spells[] { Spells.Quas, Spells.Quas, Spells.Quas });
            spellComps.Add(Spells.GhostWalk, new Spells[] { Spells.Quas, Spells.Quas, Spells.Wex });
            spellComps.Add(Spells.IceWall, new Spells[] { Spells.Quas, Spells.Quas, Spells.Exort });
            spellComps.Add(Spells.EMP, new Spells[] { Spells.Wex, Spells.Wex, Spells.Wex });
            spellComps.Add(Spells.Tornado, new Spells[] { Spells.Wex, Spells.Wex, Spells.Quas });
            spellComps.Add(Spells.Alacrity, new Spells[] { Spells.Quas, Spells.Quas, Spells.Exort });
            spellComps.Add(Spells.SunStrike, new Spells[] { Spells.Exort, Spells.Exort, Spells.Exort });
            spellComps.Add(Spells.ForgeSpirit, new Spells[] { Spells.Exort, Spells.Exort, Spells.Quas });
            spellComps.Add(Spells.ChaosMeteor, new Spells[] { Spells.Exort, Spells.Exort, Spells.Wex });
            spellComps.Add(Spells.DeafeningBlast, new Spells[] { Spells.Quas, Spells.Wex, Spells.Exort });
            return spellComps;
        }
        private List<Spells> fetchEnabledSpells()
        {
            List<Spells> spells = new List<Spells>();
            /* Add enabled spells to array. */
            if (coldsnapEnabledCheckbox.Checked) { spells.Add(Spells.ColdSnap); }
            if (ghostwalkEnabledCheckbox.Checked) { spells.Add(Spells.GhostWalk); }
            if (icewallEnabledCheckbox.Checked) { spells.Add(Spells.IceWall); }
            if (empEnabledCheckbox.Checked) { spells.Add(Spells.EMP); }
            if (tornadoEnabledCheckbox.Checked) { spells.Add(Spells.Tornado); }
            if (alacrityEnabledCheckbox.Checked) { spells.Add(Spells.Alacrity); }
            if (sunstrikeEnabledCheckbox.Checked) { spells.Add(Spells.SunStrike); }
            if (forgespiritEnabledCheckbox.Checked) { spells.Add(Spells.ForgeSpirit); }
            if (chaosmeteorEnabledCheckbox.Checked) { spells.Add(Spells.ChaosMeteor); }
            if (deafeningblastEnabledCheckbox.Checked) { spells.Add(Spells.DeafeningBlast); }
            return spells;
        }
    }
}

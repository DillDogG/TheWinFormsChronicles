using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLogic.GameLogic.Character;
using GameLogic.GameLogic.dialogue;

namespace GameLogic
{
    public partial class Form2 : Form
    {
        private NonPlayerCharacter npc;
        private Response topResponse;
        private Response botResponse;
        public Form2()
        {
            InitializeComponent();
        }

        public void setDialogue(NonPlayerCharacter npc)
        {
            this.npc = npc;
            label1.Text = npc.name;
            NPCResponse.Text = npc.dialogue.dialogueStart.responseText;
            //oneKey = npc.dialogue.dialogueStart.dialogueOptions.First().Key;
            topResponse = npc.dialogue.dialogueStart;
            //twoKey = npc.dialogue.dialogueStart.dialogueOptions.Last().Key;
            Option1.Text = topResponse.dialogueOptions.First().Key;
            Option2.Text = topResponse.dialogueOptions.Last().Key;
            //Option2.Text = twoKey;
        }

        private void Option1_Click(object sender, EventArgs e)
        {
            if (Option1.Text == "Start fight") { Globals.formManager.OpenBattlePage(5); Close(); return; }
            if (Option1.Text == "Start fight small") { Globals.formManager.OpenBattlePage(1); Close(); return; }
            //oneKey = npc.dialogue.dialogueStart.dialogueOptions.;
            topResponse = topResponse.dialogueOptions.First().Value;
            NPCResponse.Text = topResponse.responseText;
            Option1.Text = topResponse.dialogueOptions.First().Key;
            Option2.Text = topResponse.dialogueOptions.Last().Key;
            //Option2.Text = npc.dialogue.dialogueStart.dialogueOptions.Last().Key;
        }

        private void Option2_Click(object sender, EventArgs e)
        {
            if (Option2.Text == "Start fight") { Globals.formManager.OpenBattlePage(5, false); Close(); return; }
            if (Option2.Text == "Start fight small") { Globals.formManager.OpenBattlePage(1, false); Close(); return; }
            topResponse = topResponse.dialogueOptions.Last().Value;
            NPCResponse.Text = topResponse.responseText;
            Option1.Text = topResponse.dialogueOptions.First().Key;
            Option2.Text = topResponse.dialogueOptions.Last().Key;
        }
    }
}

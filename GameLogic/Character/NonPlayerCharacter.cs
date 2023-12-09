using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLogic.GameLogic.dialogue;

namespace GameLogic.GameLogic.Character
{
    public class NonPlayerCharacter : Character {
        public string name;
        public Dialogue dialogue { get; set; }
        public NonPlayerCharacter(string name)
        {
            this.name = name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWinFormsChronicles.GameLogic.dialogue
{
    public class Response
    {
        public string responseText { get; set; }
        public Dictionary<string, Response> dialogueOptions { get; set; } = new Dictionary<string, Response> { };
    }
}

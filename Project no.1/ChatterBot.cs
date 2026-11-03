using System;
using System.Collections.Generic;
using System.Text;

namespace Project_no._1
{
    public class ChatterBot
    {
        private string name;
        protected string[] statements;
        Random rand;
        public ChatterBot(string name, string[] statements)
        {
            this.name = name;
            this.statements = new string[statements.Length];
            for(int i = 0; i < statements.Length; i++)
            {
                this.statements[i] = statements[i];
            }
            rand = new Random();
        }
        public string GetName() { return this.name; }
        public virtual string ReplyTo(string statement) { return this.statements[rand.Next(this.statements.Length)]; }


    }
}

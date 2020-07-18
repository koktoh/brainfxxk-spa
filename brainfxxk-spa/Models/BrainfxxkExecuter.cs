using BFCore.Config;
using BFCore.Execute;

namespace BrainfxxkSpa.Models
{
    public class BrainfxxkExecuter : ExecuterBase
    {
        public string Output { get; private set; } = string.Empty;

        public BrainfxxkExecuter(CommonConfig config, BFCommandConfig commandConfig) : base(config, commandConfig) { }

        protected override void Read()
        {
        }

        protected override void Write()
        {
            this.Output += (char)this._memory[this._index];
        }
    }
}

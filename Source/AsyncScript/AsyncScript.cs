using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Text;
using System.Threading.Tasks;
using SiliconStudio.Core.Mathematics;
using SiliconStudio.Xenko.Engine;

namespace $rootnamespace$
{
	public class $safeitemrootname$ : AsyncScript
    {        
        public override async Task Execute()
        {
            // The initialization code should come here, if necessary

            while (Game.IsRunning) // loop until the game ends (optional depending on the script)
            {
                

                // Do some stuff

                await Script.NextFrame(); // wait for the next frame (optional depending on the script)
            }
        }
    }
}

using System;

namespace CSharpDrill11
{
    class HiddenMathVoidedParams
    {
        public void TrashCompactor(int eatenInteger, int displayedInteger)
        {
            eatenInteger *= 0;
            Console.WriteLine("Your first paramater has been obliterated. The second paramater was: " + displayedInteger);
        }
    }
}

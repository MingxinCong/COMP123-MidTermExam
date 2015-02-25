using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_MidTermExam
{
    /**
    * <summary>
    * This class is a subclass of the LottoGame abstract superclass
    * </summary>
    * 
    * @class LottoMax
    */
    public class LottoMax : LottoGame, IGenerateLottoNumbers
    {
        /**
         * <summary>
         * This constructor does not take any parameters but satisfies the
         * base constructor requirements by send the elementNumber and setSize
         * </summary>
         * 
         * @constructor
         */
        public LottoMax()
            :base(7,49)
        {
            
        }

        // CREATE the public GenerateLottoNumbers method here ----------------
        /*
         * generate all the lotto numbers and print out them in the console
         */
        public void GenerateLottoNumbers()
        {
            for(int i = 0; i < ElementNumber; i++)
            {
                PickElements();
                Console.WriteLine($"Ticket  {i + 1}: {this}");
            }
        }
    }
}
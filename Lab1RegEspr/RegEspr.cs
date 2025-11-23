using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab1RegEspr
{
    class RegEspr
    {
        /// <summary>
        /// l'espressione regolare da utilizzare
        /// </summary>
        private string regex;

        /// <summary>
        /// Getter and Setter for "regex" field
        /// </summary>
        public string Regex { get => regex; set => regex = value; }

        public RegEspr()
        {
        }

        /// <summary>
        /// Parametrized constructor to initialize regex
        /// </summary>
        /// <param name="regex">l'espressione regolare da utilizzare</param>
        public RegEspr(string regex)
        {
            this.Regex = regex;
        }

        /**
         * Metodo che restituisce se una stringa matcha con una espressione regolare
         * 
         */
        /// <summary>
        /// Metodo che restituisce se una stringa matcha con una espressione regolare 
        /// </summary>
        /// <param name="input">la stringa su cui verificare il match</param>

        /// <returns>ritorna la stringa "match" o "mismatch"</returns>
        public string CheckMatch(string input)
        {
            string res;
            Match results = System.Text.RegularExpressions.Regex.Match(input, regex);
            if (results.Success)
            {
                res = "match";
            }
            else
            {
                res = "mismatch";
            }
            return res;
        }
    }
}

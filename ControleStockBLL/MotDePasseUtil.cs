using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ControleStockBLL
{
    /// <summary>
    /// Classe permettant le hachage la vérification de validé à partir de PBKDF2
    /// </summary>
    public static class MotDePasseUtil
    {
        /// <summary>
        /// Realise le hashage du mot de passe et le renvoie sous forme de tableau
        /// </summary>
        /// <param name="mdp">Mot de passe à transformé</param>
        /// <param name="sel">Sel de sécurisation du mot de passe</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="FormatException"></exception>
        /// <returns>Hash du mot de passe</returns>
        private static byte[] HashageMdp(string mdp, string sel)
        {
            byte[] mdpHash = null;
            using (Rfc2898DeriveBytes hashBytes = new Rfc2898DeriveBytes(sel + mdp, Convert.FromBase64String(sel), 10000))
            {
                mdpHash = hashBytes.GetBytes(70);
            }
            return mdpHash;
        }

        /// <summary>
        /// Permet de réaliser la vérification du mot de passe
        /// </summary>
        /// <param name="mdpSaisie">Mot de passe saisie</param>
        /// <param name="selBD">Sel de sécurisation du mot de passe</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="FormatException"></exception>
        /// <returns>retourne le hash du mot de passe de vérification</returns>
        public static string GenerationMdpVerif(string mdpSaisie, string selBD)
        {
            return Convert.ToBase64String(HashageMdp(mdpSaisie, selBD));
        }

        /// <summary>
        /// Permet de généré le hast du mot de passe avec un sel aléatoire
        /// </summary>
        /// <param name="mdpSaisie"></param>
        /// <param name="mdpHash"></param>
        /// <param name="sel"></param>
        /// <exception cref="CryptographicException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="FormatException"></exception>
        public static void GenerationMdpHash(string mdpSaisie, out string mdpHash, out string sel)
        {
            //variable
            mdpHash = null;
            sel = null;

            //génération du sel
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] bytes = new byte[16];
                rng.GetBytes(bytes);
                sel = Convert.ToBase64String(bytes);
            }

            //génération mdpHash
            mdpHash = Convert.ToBase64String(HashageMdp(mdpSaisie, sel));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleStockBLL
{
    /// <summary>
    /// Classe permettant l'affichage de messageBox pour l'utilisateur
    /// </summary>
    public static class Logger
    {
        /// <summary>
        /// Log a utlisé pour la gestion des erreurs
        /// </summary>
        /// <param name="message">message personnalisé</param>
        public static void LogErreur(string message)
        {
            MessageBox.Show(
                "Une erreur s'est produite :\n" + message,
                "Erreur",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
        }

        /// <summary>
        /// Log a utilisé pour la gestion des erreurs avec le message d'erreur de l'Exception
        /// </summary>
        /// <param name="ex">exception</param>
        /// <param name="message">message personnalisé</param>
        public static void LogErreur(this Exception ex, string message = null)
        {
            MessageBox.Show(
                "Une erreur s'est produite :\n" + message + "\nInformation sur l'exception :\n" + ex.Message,
                "Erreur",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
        }

        /// <summary>
        /// Log a utlisé pour la gestion des alertes (données invalides, accès refusés...)
        /// </summary>
        /// <param name="message">message personnalisé</param>
        public static void LogAttention(string message)
        {
            MessageBox.Show(
                message,
                "Attention",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
        }

        /// <summary>
        /// Log a utlisé pour fournir des informations (succès d'une demande...
        /// </summary>
        /// <param name="message">message personnalisé</param>
        public static void LogInformation(string message)
        {
            MessageBox.Show(
                message,
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }
    }
}

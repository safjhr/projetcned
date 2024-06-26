﻿using System;
using CD1.DAL;
using CD1.modele;

namespace CD1.controller
{ 
        /// <summary>
        /// Contrôleur de connexion controleur
        /// </summary>
        public class connexioncontroller
        {
            /// <summary>
            /// objet d'accès aux opérations possibles sur responsable
            /// </summary>
            private readonly ResponsableAccess responsableAccess;

            /// <summary>
            /// Récupère l'acces aux données
            /// </summary>
            public connexioncontroller()
            {
                responsableAccess = new ResponsableAccess();
            }

            /// <summary>
            /// Vérifie la connexion
            /// </summary>
            /// <param name="responsable">objet contenant les informations de connexion</param>
            /// <returns> vrai si les informations de connexion sont correctes</returns>
            public Boolean Controleconnexion(Responsable responsable)
            {
                return responsableAccess.ControleConnexion(responsable);
            }

        }
    
}


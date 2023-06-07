using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBonus_Props.TopSecret
{
    internal class MessageSecret
    {
        private string _sender; //_sender peut être facilement identifié comme un champs : il s'agit juste d'une variable permettant de stocker une information (pas de GET ou de SET)

        public string Message { get; private set; }
        public string Receiver { get; private set; }

        public string Sender {
            //GET : Permet de récupérer une valeur stockée en mémoire
            //Private : Je ne veux pas que la donnée soit récupérable hors contexte de la class "MessageSecret"
            //Notre message se doit d'être anonyme
            private get {
                return _sender; //GET demande l'utilisation d'un return
                                //_sender est la variable (champs) choisi pour stocker la valeur
            }
            //SET : Permet de sauvegarder une valeur dans une variable
            //      On veut pouvoir contrôler les informations entrantes
            set { _sender = value; }    //SET utilise le mot-clé "value" pour désigner la nouvelle valeur de la variable
        }

        public MessageSecret MessageBefore { get; private set; }

        public MessageSecret Answer(string message)
        {
            MessageSecret reponse = new MessageSecret();
            reponse.Message = message;
            //Quand on répond à un message, le destinataire du message est l'envoyeur de la réponse
            reponse.Sender = this.Receiver;
            //Quand on attend une réponse à son message, on est l'envoyeur du message et le destinataire de la réponse
            reponse.Receiver = this.Sender;
            //Pour garder un historique des messages, nous lions notre message dans la réponse
            reponse.MessageBefore = this;
            return reponse;
        }

        public void Write(string sender, string receiver, string message)
        {
            this.Sender = sender;
            this.Receiver = receiver;
            this.Message = message;
        }
    }
}

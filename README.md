# Logiciel d'enregistrement de clients

### Description
Afin de mieux comprendre l'interaction entre un programme C# et une base de donnée. J'ai réalisé ce programme permettant d'enregistrer le nom, 
le prénom et l'adresse mail d'une personne pour ensuite les stocker en base de données ou dans un fichier texte.

### Lancer le projet
1. Vous devez créer une base de données en local à partir du fichier "Database.sql"
  1. Nom du serveur : localhost
  2. Nom de l'utilisateur : root
  3. Mot de passe : root
  4. Nom de la database : MyClients
2. Telecharger le projet, puis lancer l'application depuis le fichier "clientRegister" présent dans le chemin d'accès suivant : 
/clientRegister/bin/Debug/net6.0-windows/clientRegister.exe

# Résumé du projet

| Fonctionnalité             | Disponibilité | Commentaire                                   | 
| ------------------- | -- | ---------------------------------------- | 
| Récupérer et vérifier l'exactitude des données | ✅             | |
| Permettre le stockage des informations dans un fichier texte | ✅             | |
| Permettre le stockage des informations dans une base de donnée | ✅            | |
| Liaison du programme avec une base de donnée avec l'extension MySql.Data | ✅            | |
| Vérification de la disponibilité du serveur avant toute interaction | ✅            | |
| Prise en compte des normes de sécurité lors de la création des requêtes SQL | ✅            | |

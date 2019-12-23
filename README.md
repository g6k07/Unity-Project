# Unity-Project
 Importer et utiliser des services d'analytics et de monetization sous Unity.

Projet Unity
## Description :
 Le but de ce projet est d’intégrer les services d’analytics et de monétization dans un projet Unity.

## Environnement technique :  
 Unity, Game Analytics et Facebook Analytics 

## Temps de réalisation : 
 6h dont 2h pour l’implémentation et les tests et 4h pour la formation et la mise en place de l’environnement technique.

## Etapes de réalisation :
 * Formation et installation de l’environnement Unity.
 * Intégration des services de Game Analytics, Facebook Analytics, Unity Analytics et Unity Ads.
 * Création des 2 scènes du projet Unity.
 * Implémentation des scripts pour l’envoi des custom events vers les différents services d’analytics intégrés.
 * Implémentation du script pour l’ajout de vidéos publicitaires de type rewarded et interstitial.

## Choix techniques / architecturaux :
 * Partie Analytics :
    * Définition d’une interface générique d’envoi d’event IAnalyticsInterface. 
    * Développement de 3 classes GAImpl, FAImpl et UAImpl qui implémentent cette interface. Elles sont attachées respectivement aux GameObjects GameAnalyticsObject, FacebookAnalyticsObject et UnityAnalyticsObject tagged « srv_analytics ».
    * Implémentation d’un script SendEvtOnClick.cs appelé par la fonction OnClick des 3 Components Button_evt_paramsless, Button_evt_params et Button_evt_full. Il est en charge de la gestion des envois des différents type d’events vers les différents services d’analytics intégrés.

 * Partie Monetization :
    * Implémentation d’un script AdsButton.cs attaché au 2 Components Button_display_interstitial et Button_display_rewarded. Il est en charge d’indiquer le chargement et l’affichage d’un contenu publicitaire de type interstitial et rewarded.

## Difficultés rencontrées :
* Réalisation des tests pour la réception des events par le service Facebook analytics.
* Compilation du projet Unity pour la target plateform Android.


using MonoSAMFramework.Portable.Localization;
using MonoSAMFramework.Portable.LogProtocol;
using MonoSAMFramework.Portable.Network.Multiplayer;

namespace GridDominance.Shared.Resources
{
	public static class L10NImpl
	{
		public const int STR_SSB_ABOUT              = 00;
		public const int STR_SSB_ACCOUNT            = 01;
		public const int STR_SSB_HIGHSCORE          = 02;
		public const int STR_SSB_MUTE               = 03;
		public const int STR_SSB_EFFECTS            = 04;
		public const int STR_SSB_LANGUAGE           = 69;
		public const int STR_SSB_MUSIC              = 111;

		public const int STR_HSP_GLOBALRANKING      = 05;
		public const int STR_HSP_MULTIPLAYERRANKING = 167;
		public const int STR_HSP_RANKINGFOR         = 06;

		public const int STR_TAB_NAME               = 07;
		public const int STR_TAB_POINTS             = 08;
		public const int STR_TAB_TIME               = 09;

		public const int STR_FAP_ACCOUNT            = 10;
		public const int STR_FAP_USERNAME           = 11;
		public const int STR_FAP_SCORE              = 78;
		public const int STR_FAP_CHANGEPW           = 12;
		public const int STR_FAP_LOGOUT             = 93;
		public const int STR_FAP_WARN1              = 94;
		public const int STR_FAP_WARN2              = 95;
		public const int STR_FAP_LOGOUT_SUCESS      = 96;

		public const int STR_CPP_CHANGEPW           = 13;
		public const int STR_CPP_USERNAME           = 14;
		public const int STR_CPP_NEWPW              = 15;
		public const int STR_CPP_CHANGE             = 16;
		public const int STR_CPP_CHANGING           = 17;
		public const int STR_CPP_CHANGED            = 18;
		public const int STR_CPP_COMERR             = 19;
		public const int STR_CPP_AUTHERR            = 20;
		public const int STR_CPP_CHANGEERR          = 21;

		public const int STR_ATTRIBUTIONS           = 22;
		public const int STR_UNLOCK                 = 85;

		public const int STR_AAP_HEADER             = 23;
		public const int STR_AAP_USERNAME           = 24;
		public const int STR_AAP_PASSWORD           = 25;
		public const int STR_AAP_CREATEACCOUNT      = 26;
		public const int STR_AAP_LOGIN              = 27;
		public const int STR_AAP_LOGGINGIN          = 28;
		public const int STR_AAP_WRONGPW            = 29;
		public const int STR_AAP_USERNOTFOUND       = 30;
		public const int STR_AAP_NOCOM              = 31;
		public const int STR_AAP_LOGINSUCCESS       = 32;
		public const int STR_AAP_NOLOGIN            = 33;
		public const int STR_AAP_ACCCREATING        = 34;
		public const int STR_AAP_ACCCREATED         = 35;
		public const int STR_AAP_USERTAKEN          = 36;
		public const int STR_AAP_ALREADYCREATED     = 37;
		public const int STR_AAP_AUTHERROR          = 38;
		public const int STR_AAP_COULDNOTCREATE     = 39;

		public const int STR_PAUS_RESUME            = 40;
		public const int STR_PAUS_RESTART           = 41;
		public const int STR_PAUS_EXIT              = 42;

		public const int STR_HSP_LEVEL              = 43;
		public const int STR_HSP_POINTS             = 44;
		public const int STR_HSP_MPPOINTS           = 160;
		public const int STR_HSP_PROGRESS           = 45;
		public const int STR_HSP_BACK               = 46;
		public const int STR_HSP_NEXT               = 47;
		public const int STR_HSP_AGAIN              = 48;
		public const int STR_HSP_TUTORIAL           = 49;
		public const int STR_HSP_GETSTARTED         = 50;
		public const int STR_HSP_CONERROR           = 65;
		public const int STR_HSP_NEWGAME            = 158;
		public const int STR_HSP_RANDOMGAME         = 159;

		public const int STR_DIFF_0                 = 51;
		public const int STR_DIFF_1                 = 52;
		public const int STR_DIFF_2                 = 53;
		public const int STR_DIFF_3                 = 54;

		public const int STR_TUT_INFO1              = 79;
		public const int STR_TUT_INFO2              = 55;
		public const int STR_TUT_INFO3              = 56;
		public const int STR_TUT_INFO4              = 57;
		public const int STR_TUT_INFO5              = 58;
		public const int STR_TUT_INFO6              = 59;
		public const int STR_TUT_INFO7              = 60;
		public const int STR_TUT_INFO8              = 61;

		public const int STR_API_CONERR             = 62;
		public const int STR_API_COMERR             = 63;

		public const int STR_GLOB_EXITTOAST         = 64;
		public const int STR_GLOB_UNLOCKTOAST1      = 66;
		public const int STR_GLOB_UNLOCKTOAST2      = 67;
		public const int STR_GLOB_UNLOCKTOAST3      = 68;
		public const int STR_GLOB_LEVELLOCK         = 70;
		public const int STR_GLOB_WORLDLOCK         = 71;
		public const int STR_GLOB_OVERWORLD         = 75;
		public const int STR_GLOB_WAITFORSERVER     = 76;
		public const int STR_GLOB_UNLOCKSUCCESS     = 86;

		public const int STR_WORLD_TUTORIAL         = 77;
		public const int STR_WORLD_W1               = 80;
		public const int STR_WORLD_W2               = 81;
		public const int STR_WORLD_W3               = 92;
		public const int STR_WORLD_W4               = 103;
		public const int STR_WORLD_MULTIPLAYER      = 114;
		public const int STR_WORLD_SINGLEPLAYER     = 178;

		public const int STR_INF_YOU                = 72;
		public const int STR_INF_GLOBAL             = 73;
		public const int STR_INF_HIGHSCORE          = 74;

		public const int STR_IAB_TESTERR            = 82;
		public const int STR_IAB_TESTNOCONN         = 83;
		public const int STR_IAB_TESTINPROGRESS     = 84;

		public const int STR_IAB_BUYERR             = 88;
		public const int STR_IAB_BUYNOCONN          = 89;
		public const int STR_IAB_BUYNOTREADY        = 90;
		public const int STR_IAB_BUYSUCESS          = 91;

		public const int STR_PREV_BUYNOW            = 87;
		public const int STR_PREV_FINISHWORLD       = 108;
		public const int STR_PREV_OR                = 109;
		public const int STR_PREV_MISS_TOAST        = 110;

		public const int STR_HINT_001               = 97;
		public const int STR_HINT_002               = 98;
		public const int STR_HINT_003               = 99;
		public const int STR_HINT_004               = 100;
		public const int STR_HINT_005               = 101;
		public const int STR_HINT_006               = 102;
		public const int STR_HINT_007               = 112;
		public const int STR_HINT_008               = 113;
		public const int STR_HINT_009               = 173;
		public const int STR_HINT_010               = 176;
		public const int STR_HINT_011               = 177;

		public const int STR_INFOTOAST_1            = 104;
		public const int STR_INFOTOAST_2            = 105;
		public const int STR_INFOTOAST_3            = 106;
		public const int STR_INFOTOAST_4            = 107;

		public const int STR_MP_TIMEOUT             = 115;
		public const int STR_MP_TIMEOUT_USER        = 116;
		public const int STR_MP_NOTINLOBBY          = 117;
		public const int STR_MP_SESSIONNOTFOUND     = 118;
		public const int STR_MP_AUTHFAILED          = 119;
		public const int STR_MP_LOBBYFULL           = 120;
		public const int STR_MP_VERSIONMISMATCH     = 121;
		public const int STR_MP_LEVELNOTFOUND       = 122;
		public const int STR_MP_LEVELMISMATCH       = 123;
		public const int STR_MP_USERDISCONNECT      = 124;
		public const int STR_MP_SERVERDISCONNECT    = 125;
		public const int STR_MP_INTERNAL            = 161;
		public const int STR_MP_BTADAPTERNULL       = 162;
		public const int STR_MP_BTADAPTERPERMDENIED = 168;
		public const int STR_MP_BTDISABLED          = 163;
		public const int STR_MP_DIRECTCONNLOST      = 164;
		public const int STR_MP_DIRECTCONNFAIL      = 165;
		public const int STR_MP_TOAST_CONN_TRY      = 170;
		public const int STR_MP_TOAST_CONN_FAIL     = 171;
		public const int STR_MP_TOAST_CONN_SUCC     = 172;

		public const int STR_MENU_CANCEL            = 138;
		public const int STR_MENU_DISCONNECT        = 147;

		public const int STR_MENU_CAP_MULTIPLAYER   = 126;
		public const int STR_MENU_CAP_LOBBY         = 127;
		public const int STR_MENU_CAP_CGAME_PROX    = 128;
		public const int STR_MENU_CAP_CGAME_P2P     = 169;
		public const int STR_MENU_CAP_AUTH          = 136;
		public const int STR_MENU_CAP_SEARCH        = 166;
		public const int STR_MENU_MP_JOIN           = 132;
		public const int STR_MENU_MP_HOST           = 133;
		public const int STR_MENU_MP_START          = 149;
		public const int STR_MENU_MP_ONLINE         = 135;
		public const int STR_MENU_MP_LOCAL          = 134;
		public const int STR_MENU_MP_CREATE         = 137;
		public const int STR_MENU_MP_GAMESPEED      = 139;
		public const int STR_MENU_MP_MUSIC          = 140;
		public const int STR_MENU_MP_LOBBYINFO      = 141;
		public const int STR_MENU_MP_LOBBY_USER     = 142;
		public const int STR_MENU_MP_LOBBY_USER_FMT = 148;
		public const int STR_MENU_MP_LOBBY_LEVEL    = 143;
		public const int STR_MENU_MP_LOBBY_MUSIC    = 144;
		public const int STR_MENU_MP_LOBBY_SPEED    = 145;
		public const int STR_MENU_MP_LOBBY_PING     = 146;
		public const int STR_MENU_MP_LOBBY_COLOR    = 157;

		public const int STR_MP_ONLINE              = 129;
		public const int STR_MP_OFFLINE             = 130;
		public const int STR_MP_CONNECTING          = 131;

		public const int STR_FRAC_N0                = 150;
		public const int STR_FRAC_P1                = 151;
		public const int STR_FRAC_A2                = 152;
		public const int STR_FRAC_A3                = 153;
		public const int STR_FRAC_A4                = 154;
		public const int STR_FRAC_A5                = 155;
		public const int STR_FRAC_A6                = 156;

		public const int STR_ENDGAME_1              = 174;
		public const int STR_ENDGAME_2              = 175;

		public const int STR_ACCOUNT_REMINDER       = 179;
		public const int STR_BTN_YES                = 180;
		public const int STR_BTN_NO                 = 181;

		private const int TEXT_COUNT = 182; // = next idx

		public static void Init(int lang)
		{
			L10N.Init(lang, TEXT_COUNT);

			L10N.Add(STR_SSB_ABOUT,              "Informazioni",                                                                                                                                   "Info",                                                                                                                                "Info");
			L10N.Add(STR_SSB_ACCOUNT,            "Account",                                                                                                                                 "Benutzerkonto",                                                                                                                       "Compte");
			L10N.Add(STR_SSB_HIGHSCORE,          "Classifica",                                                                                                                               "Bestenliste",                                                                                                                         "Tableau d'honneur");
			L10N.Add(STR_SSB_MUTE,               "Muto",                                                                                                                                    "Stumm",                                                                                                                               "Muet");
			L10N.Add(STR_SSB_EFFECTS,            "Effetti",                                                                                                                                 "Effekte",                                                                                                                             "Effet");
			L10N.Add(STR_SSB_MUSIC,              "Musica",                                                                                                                                   "Musik",                                                                                                                               "Musique");
			L10N.Add(STR_HSP_GLOBALRANKING,      "Classifica Globale",                                                                                                                          "Bestenliste",                                                                                                                         "Classement globale");
			L10N.Add(STR_HSP_MULTIPLAYERRANKING, "Multiplayer",                                                                                                                             "Mehrspieler",                                                                                                                         "Multijoueur");
			L10N.Add(STR_HSP_RANKINGFOR,         "Classifica per \"{0}\"",                                                                                                                     "Bestenliste für \"{0}\"",                                                                                                             "Classement pour \"{0}\"");
			L10N.Add(STR_TAB_NAME,               "Nome",                                                                                                                                    "Name",                                                                                                                                "Nom");
			L10N.Add(STR_TAB_POINTS,             "Punti",                                                                                                                                  "Punkte",                                                                                                                              "Points");
			L10N.Add(STR_TAB_TIME,               "Tempo Totale",                                                                                                                              "Gesamtzeit",                                                                                                                          "Temps total");
			L10N.Add(STR_FAP_ACCOUNT,            "Account",                                                                                                                                 "Benutzerkonto",                                                                                                                       "Compte d'utilisateur");
			L10N.Add(STR_FAP_USERNAME,           "Username:",                                                                                                                               "Benutzername:",                                                                                                                       "Nom d'utilisateur");
			L10N.Add(STR_FAP_SCORE,              "Points:",                                                                                                                                 "Punkte:",                                                                                                                             "Points");
			L10N.Add(STR_FAP_CHANGEPW,           "Cambia Password",                                                                                                                         "Passwort ändern",                                                                                                                     "Mot de passe");
			L10N.Add(STR_FAP_LOGOUT,             "Esci",                                                                                                                                  "Ausloggen",                                                                                                                           "Déconnecter");
			L10N.Add(STR_FAP_WARN1,              "Questo cancellerà tutti i dati locali. Premi di nuovo per uscire.",                                                                                 "Dies löscht alle lokalen Daten. Nochmal drücken zum ausloggen.",                                                                      "Cette opération efface toutes les données locales. Appuyez à nouveau pour vous déconnecter.");
			L10N.Add(STR_FAP_WARN2,              "Sei sicuro di voler uscire?",                                                                                                "Wirklich vom Serverkonto abmelden?",                                                                                                  "Êtes-vous vraiment sûr de vouloir vous déconnecter?");
			L10N.Add(STR_FAP_LOGOUT_SUCESS,      "Uscito dall'account",                                                                                                                 "Lokaler Benutzer wurde abgemeldet.",                                                                                                  "Déconnecté du compte");
			L10N.Add(STR_CPP_CHANGEPW,           "Cambia Password",                                                                                                                         "Passwort ändern",                                                                                                                     "Changer mot de passe");
			L10N.Add(STR_CPP_USERNAME,           "Username:",                                                                                                                               "Benutzername:",                                                                                                                       "Nom d'utilisateur");
			L10N.Add(STR_CPP_NEWPW,              "Nuova Password",                                                                                                                            "Neues Passwort",                                                                                                                      "Noveau mot de passe");
			L10N.Add(STR_CPP_CHANGE,             "Cambia",                                                                                                                                  "Ändern",                                                                                                                              "Changer mot de passe");
			L10N.Add(STR_CPP_CHANGING,           "Cambiando la password",                                                                                                                       "Passwort wird geändert",                                                                                                              "Changement du mot de passe ");
			L10N.Add(STR_CPP_CHANGED,            "Password cambiata",                                                                                                                        "Passwort geändert",                                                                                                                   "Mot de passe est changé");
			L10N.Add(STR_CPP_COMERR,             "Impossibile comunicare con il server",                                                                                                       "Kommunikation mit Server ist gestört",                                                                                                "La communication avec le serveur est perturbé");
			L10N.Add(STR_CPP_AUTHERR,            "Errore di autenticazione",                                                                                                                    "Authentifizierung fehlgeschlagen",                                                                                                    "Erreur d'authentification");
			L10N.Add(STR_CPP_CHANGEERR,          "Impossibile cambiare password",                                                                                                              "Passwort konnte nicht geändert werden",                                                                                               "Mot de passe ne peut pas être modifié");
			L10N.Add(STR_ATTRIBUTIONS,           "Attribuzioni",                                                                                                                            "Lizenzen",                                                                                                                            "Licences");
			L10N.Add(STR_AAP_HEADER,             "Iscriviti / Accedi",                                                                                                                        "Anmelden / Registrieren",                                                                                                             "Se connecter");
			L10N.Add(STR_AAP_USERNAME,           "Username",                                                                                                                                "Benutzername",                                                                                                                        "Nom d'utilisateur");
			L10N.Add(STR_AAP_PASSWORD,           "Password",                                                                                                                                "Passwort",                                                                                                                            "Mot de passe");
			L10N.Add(STR_AAP_CREATEACCOUNT,      "Crea Account",                                                                                                                          "Registrieren",                                                                                                                        "Registrer");
			L10N.Add(STR_AAP_LOGIN,              "Accedi",                                                                                                                                   "Anmelden",                                                                                                                            "S'inscrire");
			L10N.Add(STR_AAP_LOGGINGIN,          "Accedendo",                                                                                                                              "Wird angemeldet",                                                                                                                     "Est enregistré");
			L10N.Add(STR_AAP_WRONGPW,            "Password sbagliata",                                                                                                                          "Falsches Passwort",                                                                                                                   "Mot de passe incorrect");
			L10N.Add(STR_AAP_USERNOTFOUND,       "Utente non trovato",                                                                                                                          "Benutzer nicht gefunden",                                                                                                             "Utilisateur introuvable");
			L10N.Add(STR_AAP_NOCOM,              "Impossibile comunicare con il server",                                                                                                       "Konnte nicht mit Server kommunizieren",                                                                                               "La communication avec le serveur est perturbé");
			L10N.Add(STR_AAP_LOGINSUCCESS,       "Accesso completo",                                                                                                                  "Benutzer erfolgreich angemeldet",                                                                                                     "Connecté avec succès");
			L10N.Add(STR_AAP_NOLOGIN,            "Impossibile accedere",                                                                                                                         "Anmeldung fehlgeschlagen",                                                                                                            "Échec de la connexion");
			L10N.Add(STR_AAP_ACCCREATING,        "Creando l'account",                                                                                                                        "Konto wird erstellt",                                                                                                                 "Création du compte");
			L10N.Add(STR_AAP_ACCCREATED,         "Account creato",                                                                                                                         "Konto erfolgreich erstellt",                                                                                                          "Compte créé");
			L10N.Add(STR_AAP_USERTAKEN,          "Username già in uso",                                                                                                                  "Benutzername bereits vergeben",                                                                                                       "Nom d'utilisateur déjà pris");
			L10N.Add(STR_AAP_ALREADYCREATED,     "Account già creato",                                                                                                                 "Konto bereits erstellt",                                                                                                              "Compte déjà créé");
			L10N.Add(STR_AAP_AUTHERROR,          "Errore di autenticazione",                                                                                                                    "Authentifizierungsfehler",                                                                                                            "Erreur d'authentification");
			L10N.Add(STR_AAP_COULDNOTCREATE,     "Impossibile creare account",                                                                                                                "Konto konnte nicht erstellt werden",                                                                                                  "Impossible de créer compte");
			L10N.Add(STR_PAUS_RESUME,            "CONTINUA",                                                                                                                                  "WEITER",                                                                                                                              "REPRENDRE");
			L10N.Add(STR_PAUS_RESTART,           "RICOMINCIA",                                                                                                                                 "NEU STARTEN",                                                                                                                         "REDÉMARRER");
			L10N.Add(STR_PAUS_EXIT,              "ESCI",                                                                                                                                    "BEENDEN",                                                                                                                             "TERMINER");
			L10N.Add(STR_HSP_LEVEL,              "Livello",                                                                                                                                   "Level",                                                                                                                               "Niveau");
			L10N.Add(STR_HSP_POINTS,             "Punti",                                                                                                                                  "Punkte",                                                                                                                              "Ponts");
			L10N.Add(STR_HSP_PROGRESS,           "Progresso",                                                                                                                                "Fortschritt",                                                                                                                         "Progrès");
			L10N.Add(STR_HSP_BACK,               "Indietro",                                                                                                                                    "Zurück",                                                                                                                              "De retour");
			L10N.Add(STR_HSP_NEXT,               "Avanti",                                                                                                                                    "Weiter",                                                                                                                              "Prochain");
			L10N.Add(STR_HSP_AGAIN,              "Ripeti",                                                                                                                                   "Wiederholen",                                                                                                                         "Répéter");
			L10N.Add(STR_HSP_TUTORIAL,           "Tutorial",                                                                                                                                "Tutorial",                                                                                                                            "Tutorial");
			L10N.Add(STR_HSP_GETSTARTED,         "Iniziamo",                                                                                                                       "Los gehts",                                                                                                                           "C'est parti");
			L10N.Add(STR_HSP_CONERROR,           "Impossibile connettersi al server della classifica",                                                                                                   "Kommunikation mit Server fehlgeschlagen",                                                                                             "Impossible de se connecter au serveur highscore");
			L10N.Add(STR_DIFF_0,                 "Facile",                                                                                                                                    "Leicht",                                                                                                                              "Facile");
			L10N.Add(STR_DIFF_1,                 "Normale",                                                                                                                                  "Normal",                                                                                                                              "Normal");
			L10N.Add(STR_DIFF_2,                 "Difficile",                                                                                                                                    "Schwer",                                                                                                                              "Difficile");
			L10N.Add(STR_DIFF_3,                 "Estremo",                                                                                                                                 "Extrem",                                                                                                                              "Extrême");
			L10N.Add(STR_TUT_INFO1,              "Trascina per ruotare i tuoi cannoni",                                                                                                         "Drücke und Ziehe um deine Kanonen zu drehen",                                                                                         "Tirer pour tourner tes canons");
			L10N.Add(STR_TUT_INFO2,              "Spara fino a che non diventa il tuo cannone",                                                                                                   "Schieße bis die feindliche Kanone dir gehört",                                                                                        "Abattre jusque le canon ennemi est à toi");
			L10N.Add(STR_TUT_INFO3,              "Ora cattura il prossimo cannone",                                                                                                             "Erobere nun die nächste Einheit",                                                                                                     "Captiver le prochain canon");
			L10N.Add(STR_TUT_INFO4,              "Continua a sparare al primo cannone per aumentare la cadenza di fuoco",                                                                             "Schieß auf deine eigene Kanone um ihre Feuerrate zu erhöhen",                                                                         "Gardez le tir au premier canon pour augmenter sa cadence de tir");
			L10N.Add(STR_TUT_INFO5,              "Il nemico ha conquistato un cannone. Attaccalo!",                                                                                            "Der Gegner hat eine Einheit erobert, greif ihn an!",                                                                                  "L'enemi a conquis  un canon. Attaque.");
			L10N.Add(STR_TUT_INFO6,              "Accellera il gioco con i pulsanti in basso a sinistra.",                                                                                          "Mit dem Knopf unten links kannst du die Spielgeschwindigkeit erhöhen",                                                                "Accélérez le jeu avec le bouton en bas à gauche.");
			L10N.Add(STR_TUT_INFO7,              "Ora cattura il prossimo cannone",                                                                                                             "Erobere jetzt die nächste Einheit",                                                                                                   "Maintenant capturez le prochain canon");
			L10N.Add(STR_TUT_INFO8,              "Vinci il gioco catturando tutti i cannoni nemici",                                                                                             "Gewinne die Schlacht indem du alle Einheiten eroberst",                                                                               "Gagnez le jeu en capturant tous les canons ennemis");
			L10N.Add(STR_API_CONERR,             "Impossibile connettersi al server della classifica",                                                                                                   "Verbindung mit Highscore Server fehlgeschlagen",                                                                                      "Impossible de se connecter au serveur Highscore");
			L10N.Add(STR_API_COMERR,             "Impossibile comunicare al server della classifica",                                                                                             "Kommunikation mit Highscore Server fehlgeschlagen",                                                                                   "Impossible de communiquer avec le serveur highscore");
			L10N.Add(STR_GLOB_EXITTOAST,         "Clicca di nuovo per uscire dal gioco",                                                                                                                "Drücke nochmal \"Zurück\" um das Spiel zu beenden",                                                                                   "Cliquez de noouveau pour quitter le jeu");
			L10N.Add(STR_GLOB_UNLOCKTOAST1,      "Clicca due volte per sbloccare",                                                                                                          "Noch zweimal drücken um die Welt freizuschalten",                                                                                     "Cliquez deux fois plus pour débloquer");
			L10N.Add(STR_GLOB_UNLOCKTOAST2,      "Clicca di nuovo per sbloccare",                                                                                                                   "Nochmal drücken um die Welt freizuschalten",                                                                                          "Cliquez de nouvea pour quitter le jeu");
			L10N.Add(STR_GLOB_UNLOCKTOAST3,      "Mondo sbloccato",                                                                                                                          "Welt freigeschaltet",                                                                                                                 "Monde débloqué");
			L10N.Add(STR_GLOB_WORLDLOCK,         "Mondo bloccato",                                                                                                                            "Welt noch nicht freigespielt",                                                                                                        "Monde bloqué");
			L10N.Add(STR_GLOB_LEVELLOCK,         "Livello bloccato",                                                                                                                            "Level noch nicht freigespielt",                                                                                                       "Niveau bloqué");
			L10N.Add(STR_INF_YOU,                "Tu",                                                                                                                                     "Du",                                                                                                                                  "Toi");
			L10N.Add(STR_INF_GLOBAL,             "Statistiche",                                                                                                                                   "Total",                                                                                                                               "Global");
			L10N.Add(STR_INF_HIGHSCORE,          "Highscore",                                                                                                                               "Bestzeit",                                                                                                                            "Highscore");
			L10N.Add(STR_GLOB_OVERWORLD,         "Overworld",                                                                                                                               "Übersicht",                                                                                                                           "L'aperçu");
			L10N.Add(STR_GLOB_WAITFORSERVER,     "Contattando il server",                                                                                                                       "Server wird kontaktiert",                                                                                                             "Contacter le serveur");
			L10N.Add(STR_WORLD_TUTORIAL,         "Tutorial",                                                                                                                                "Tutorial",                                                                                                                            "Didacticiel");
			L10N.Add(STR_SSB_LANGUAGE,           "Linguaggio",                                                                                                                                "Sprache",                                                                                                                             "Longue");
			L10N.Add(STR_WORLD_W1,               "Base",                                                                                                                                   "Grundlagen",                                                                                                                          "Niveau base");
			L10N.Add(STR_WORLD_W2,               "Professionale",                                                                                                                            "Fortgeschritten",                                                                                                                     "Niveau avancé");
			L10N.Add(STR_WORLD_W3,               "Futuristico",                                                                                                                              "Futuristisch",                                                                                                                        "Futuriste");
			L10N.Add(STR_WORLD_W4,               "Svago",                                                                                                                                 "Spielzeugkiste",                                                                                                                      "Coffre à jouets");
			L10N.Add(STR_WORLD_MULTIPLAYER,      "Multiplayer",                                                                                                                             "Mehrspieler",                                                                                                                         "Multijoueur");
			L10N.Add(STR_WORLD_SINGLEPLAYER,     "Singleplayer",                                                                                                                            "Einzelspieler",                                                                                                                       "Seul joueur");
			L10N.Add(STR_IAB_TESTERR,            "Impossibile connettersi ai servizi Google Play",                                                                                                "Fehler beim Versuch mit Google Play zu verbinden",                                                                                    "Erreurde connexion avec Google Play services");
			L10N.Add(STR_IAB_TESTNOCONN,         "Nessuna connessione ai servizi Google Play",                                                                                                   "Keine Verbindung zu Google Play services",                                                                                            "Pas de connexion avec Google Play services");
			L10N.Add(STR_IAB_TESTINPROGRESS,     "Pagamento in lavorazione",                                                                                                                     "Zahlung wird verarbeitet",                                                                                                            "Paiement en cours");
			L10N.Add(STR_UNLOCK,                 "Codice Promozionale",                                                                                                                          "Promo Code",                                                                                                                          "Code promotionnel");
			L10N.Add(STR_GLOB_UNLOCKSUCCESS,     "Congratulazioni, hai acquistato la versione completa!",                                                                                                          "Spiel wurde zur Vollversion aufgewertet",                                                                                             "Mise à niveau du jeu en version complète!");
			L10N.Add(STR_PREV_BUYNOW,            "Sblocca ora",                                                                                                                              "Jetzt freischalten",                                                                                                                  "Débloquer maintenant");
			L10N.Add(STR_IAB_BUYERR,             "Impossibile connettersi ai servizi Google Play",                                                                                                "Fehler beim Versuch mit Google Play zu verbinden",                                                                                    "Erreurde connexion avec Google Play services");
			L10N.Add(STR_IAB_BUYNOCONN,          "Nessuna connessione ai servizi Google Play",                                                                                                   "Keine Verbindung zu Google Play services",                                                                                            "Pas de connexion avec Google Play services");
			L10N.Add(STR_IAB_BUYNOTREADY,        "Connessione ai servizi Google Play non pronta",                                                                                            "Verbindung zu Google Play services nicht bereit",                                                                                     "La connexion aux services Google Play n'est pas prête");
			L10N.Add(STR_IAB_BUYSUCESS,          "Mondo acquistato!",                                                                                                            "Levelpack wurde erfolgreich erworben",                                                                                                "Le monde a acheté avec succès");
			L10N.Add(STR_HINT_001,               "Consiglio: Spara per vincere!",                                                                                                                "Tipp: Versuche auf die andere Kanone zu schiessen",                                                                                   "Allusion: tirez des trucs pour gagner!");
			L10N.Add(STR_HINT_002,               "Cannone più grande",                                                                                                                           "Größere Kanone",                                                                                                                      "Plus grands canons");
			L10N.Add(STR_HINT_003,               "Più potenza",                                                                                                                              "Mehr Schaden",                                                                                                                        "Plus d'énergie");
			L10N.Add(STR_HINT_004,               "I buchi neri attraggono i tuoi proiettili",                                                                                                        "Schwarze Löcher saugen deine Kugeln ein",                                                                                             "Les trous noirs attirent vos balles");
			L10N.Add(STR_HINT_005,               "Laser!",                                                                                                                                 "Laser!",                                                                                                                              "Lasers!");
			L10N.Add(STR_HINT_006,               "Prova a trascinare la mappa",                                                                                                             "Versuche mal die Karte zu verschieben",                                                                                               "Essayez de faire glisser la carte autour");
			L10N.Add(STR_HINT_007,               "Cosina veloce entra,",                                                                                                                   "Speedy thing goes in,",                                                                                                               "Speedy thing goes in,");
			L10N.Add(STR_HINT_008,               "cosina veloce esce.",                                                                                                                 "speedy thing comes out.",                                                                                                             "speedy thing comes out.");
			L10N.Add(STR_HINT_009,               "Alcuni cannoni collegano e basta",                                                                                                                 "Manche Kanonen leiten nur weiter",                                                                                                    "Certains canons relèvent");
			L10N.Add(STR_HINT_010,               "Gli scudi",                                                                                                                             "Schilde können",                                                                                                                      "Les écus peuvent");
			L10N.Add(STR_HINT_011,               "ti proteggono",                                                                                                                             "dich beschützen",                                                                                                                     "protégez-vous");
			L10N.Add(STR_INFOTOAST_1,            "Il tuo tempo migliore è {0}",                                                                                                                   "Deine Bestzeit ist {0}",                                                                                                              "Votre meilleur temps est {0}");
			L10N.Add(STR_INFOTOAST_2,            "Il tempo assoluto migliore è {0}",                                                                                                             "Die globale Bestzeit ist {0}",                                                                                                        "Le meilleur temps global est {0}");
			L10N.Add(STR_INFOTOAST_3,            "{0} utenti hanno completato questo livello in {1}",                                                                                              "{0} Spieler haben dieses Level auf {1} geschafft",                                                                                    "{0} utilisateurs ont complété ce niveau sur {1}");
			L10N.Add(STR_INFOTOAST_4,            "Non hai completato questo livello in {0}",                                                                                                "Du hast dieses Level auf {0} noch nicht geschafft",                                                                                   "Vous n'avez pas terminé ce niveau sur {0}");
			L10N.Add(STR_PREV_FINISHWORLD,       "Finisci il mondo {0}",                                                                                                                        "Welt {0}",                                                                                                                            "Terminer Monde {0}");
			L10N.Add(STR_PREV_OR,                "oppure",                                                                                                                                      "ODER",                                                                                                                                "OU");
			L10N.Add(STR_PREV_MISS_TOAST,        "Ti mancano {0} punti per sbloccare il mondo {1}",                                                                                          "Dir fehlen noch {0} Punkte um Welt {1} freizuschalten",                                                                               "Vous manquez de {0} points pour débloquer le monde {1}");
			L10N.Add(STR_MP_TIMEOUT,             "Timeout - Connessione al server persa",                                                                                                     "Timeout - Verbindung zu server verloren",                                                                                             "Timeout - Connexion au serveur perdu");
			L10N.Add(STR_MP_TIMEOUT_USER,        "Timeout - Connection all'utente [{0}] persa",                                                                                                 "Timeout - Verbindung zu Spieler [{0}] verloren",                                                                                      "Timeout - Connexion à l'utilisateur [{0}] perdu");
			L10N.Add(STR_MP_NOTINLOBBY,          "Non fai parte di questa sessione",                                                                                                          "Du bist kein Teilnehmer dieser Sitzung",                                                                                              "Vous ne faites pas partie de cette session");
			L10N.Add(STR_MP_SESSIONNOTFOUND,     "Nessuna sessione trovata su questo server",                                                                                                             "Sitzung konnte auf dem Server nicht gefunden werden",                                                                                 "Session sur le serveur pas trouvé");
			L10N.Add(STR_MP_AUTHFAILED,          "Autenticazione sul server fallita",                                                                                                       "Authentifizierung auf Server fehlgeschlagen",                                                                                         "L'authentification sur serveur a échoué");
			L10N.Add(STR_MP_LOBBYFULL,           "La lobby del server è piena",                                                                                                                    "Serverlobby ist voll",                                                                                                                "Le lobby du serveur est plein");
			L10N.Add(STR_MP_VERSIONMISMATCH,     "Il server ha una versione diversa del gioco ({0})",                                                                                               "Serverversion unterscheidet sich von lokaler Version ({0})",                                                                          "Le serveur a une version de jeu différente({0})");
			L10N.Add(STR_MP_LEVELNOTFOUND,       "Impossibile trovare il livello nel server sul telefono",                                                                                                     "Level konnte lokal nicht gefunden werden",                                                                                            "Impossible de trouver le niveau de serveur localement");
			L10N.Add(STR_MP_LEVELMISMATCH,       "Il server ha una versione diversa del livello",                                                                                                   "Level auf dem Server unterscheidet sich von lokaler Version",                                                                         "Le serveur a une version de niveau différente");
			L10N.Add(STR_MP_USERDISCONNECT,      "L'utente {0} si è disconnesso",                                                                                                               "Der Benutzer {0} hat die Verbindung getrennt",                                                                                        "L'utilisateur {0} s'est déconnecté");
			L10N.Add(STR_MP_SERVERDISCONNECT,    "Il server ha chiuso questa sessione",                                                                                                          "Spiel wurde vom Server geschlossen",                                                                                                  "Le serveur a fermé cette session");
			L10N.Add(STR_MP_INTERNAL,            "Problema intero di multiplayer",                                                                                                              "Interner Fehler im Mehrspielermodul",                                                                                                 "Error interal au module multiplayer");
			L10N.Add(STR_MP_BTADAPTERNULL,       "Nessun apparecchio bluetooth trovato",                                                                                                             "Bluetooth Hardware nicht gefunden",                                                                                                   "Bluetooth n'a pas été trouvé");
			L10N.Add(STR_MP_BTADAPTERPERMDENIED, "Permessi bluetooth disattivati",                                                                                                            "Bluetooth Berechtigung wurde nicht gewährt",                                                                                          "Absence d'autorisation de bluetooth");
			L10N.Add(STR_MP_BTDISABLED,          "Bluetooth disattivatp",                                                                                                                   "Bluetooth ist deaktiviert",                                                                                                           "Connexion Bluetooth deactivé");
			L10N.Add(STR_MP_DIRECTCONNFAIL,      "Connessione Bluetooth fallita",                                                                                                             "Bluetooth Verbindungsaufbau fehlgeschlagen",                                                                                          "Connexion Bluetooth échoué");
			L10N.Add(STR_MP_DIRECTCONNLOST,      "Connessione Bluetooth persa",                                                                                                               "Bluetooth Verbindung verloren",                                                                                                       "Connexion Bluetooth perdu");
			L10N.Add(STR_MENU_CAP_MULTIPLAYER,   "Multiplayer",                                                                                                                             "Mehrspieler",                                                                                                                         "Multijoueur");
			L10N.Add(STR_MENU_CAP_LOBBY,         "Multiplayer Lobby",                                                                                                                       "Lobby",                                                                                                                               "Online Lobby");
			L10N.Add(STR_MENU_CAP_CGAME_PROX,    "Crea una partita Online",                                                                                                                      "Onlinespiel erstellen",                                                                                                               "Creer un jeu en ligne");
			L10N.Add(STR_MENU_CAP_CGAME_P2P,     "Crea una partita Local",                                                                                                                       "Lokales Spiel erstellen",                                                                                                             "Creer un jeu local");
			L10N.Add(STR_MENU_CAP_SEARCH,        "Cerca dispostivi locali",                                                                                                                "Suche nach lokalem Spiel",                                                                                                            "Cherchez des périphériques locaux");
			L10N.Add(STR_MP_ONLINE,              "Online",                                                                                                                                  "Online",                                                                                                                              "En ligne");
			L10N.Add(STR_MP_OFFLINE,             "Offline",                                                                                                                                 "Offline",                                                                                                                             "Hors ligne");
			L10N.Add(STR_MP_CONNECTING,          "Connessione",                                                                                                                              "Verbinden",                                                                                                                           "Connecter");
			L10N.Add(STR_MENU_MP_JOIN,           "Partecipa",                                                                                                                                    "Beitreten",                                                                                                                           "Joindre");
			L10N.Add(STR_MENU_MP_HOST,           "Ospita",                                                                                                                                    "Erstellen",                                                                                                                           "Rédiger");
			L10N.Add(STR_MENU_MP_CREATE,         "Crea",                                                                                                                                  "Start",                                                                                                                               "Créer");
			L10N.Add(STR_MENU_CANCEL,            "Cancella",                                                                                                                                  "Abbrechen",                                                                                                                           "Abandonner");
			L10N.Add(STR_MENU_DISCONNECT,        "Disconnetti",                                                                                                                              "Verbindung trennen",                                                                                                                  "Déconnecter");
			L10N.Add(STR_MENU_MP_LOCAL,          "Locale (Bluetooth)",                                                                                                                       "Lokal (Bluetooth)",                                                                                                                   "Local (Bluetooth)");
			L10N.Add(STR_MENU_MP_ONLINE,         "Online (UDP/IP)",                                                                                                                         "Internet (UDP/IP)",                                                                                                                   "En ligne (UDP/IP)");
			L10N.Add(STR_MENU_CAP_AUTH,          "Inserisci codice lobby",                                                                                                                        "Lobby Code eingeben",                                                                                                                 "Entrer lobby code");
			L10N.Add(STR_MENU_MP_GAMESPEED,      "Velocità gioco:",                                                                                                                             "Spielgeschwindigkeit:",                                                                                                               "La vitesse du jeux");
			L10N.Add(STR_MENU_MP_MUSIC,          "Musica:",                                                                                                                       "Hintergrundmusik:",                                                                                                                   "Musique de fond");
			L10N.Add(STR_MENU_MP_LOBBYINFO,      "Inserire questo codice su un altro telefono per unirsi alla sessione.",                                                                                  "Gib diesen Code auf einem anderen Smartphone ein, um diesem Spiel beizutreten",                                                       "Entrez ce code sur un autre smartphone pour rejoindre ce jeu");
			L10N.Add(STR_MENU_MP_LOBBY_USER,     "Utenti:",                                                                                                                                  "Mitspieler:",                                                                                                                         "Coéquipier:");
			L10N.Add(STR_MENU_MP_LOBBY_USER_FMT, "Utenti: {0}",                                                                                                                              "Mitspieler: {0}",                                                                                                                     "Coéquipier: {0}");
			L10N.Add(STR_MENU_MP_LOBBY_LEVEL,    "Livello:",                                                                                                                                  "Level:",                                                                                                                              "Level:");
			L10N.Add(STR_MENU_MP_LOBBY_MUSIC,    "Musica:",                                                                                                                       "Hintergrundmusik:",                                                                                                                   "Musique de fond:");
			L10N.Add(STR_MENU_MP_LOBBY_SPEED,    "Velocità gioco:",                                                                                                                             "Spielgeschwindigkeit:",                                                                                                               "La vitesse de jeu");
			L10N.Add(STR_MENU_MP_LOBBY_PING,     "Ping",                                                                                                                                    "Ping",                                                                                                                                "Ping");
			L10N.Add(STR_MENU_MP_START,          "Inizia",                                                                                                                                   "Start",                                                                                                                               "Démarrage");
			L10N.Add(STR_FRAC_N0,                "Grigio",                                                                                                                                    "Gray",                                                                                                                                "Gris");
			L10N.Add(STR_FRAC_P1,                "Verde",                                                                                                                                   "Grün",                                                                                                                                "Vert");
			L10N.Add(STR_FRAC_A2,                "Rosso",                                                                                                                                     "Rot",                                                                                                                                 "Rouge");
			L10N.Add(STR_FRAC_A3,                "Blu",                                                                                                                                    "Blau",                                                                                                                                "Bleu");
			L10N.Add(STR_FRAC_A4,                "Viola",                                                                                                                                  "Lila",                                                                                                                                "Violet");
			L10N.Add(STR_FRAC_A5,                "Arancione",                                                                                                                                  "Orange",                                                                                                                              "Orange");
			L10N.Add(STR_FRAC_A6,                "Turchese",                                                                                                                                    "BlauGrün",                                                                                                                            "Vert bleu");
			L10N.Add(STR_MENU_MP_LOBBY_COLOR,    "Colore",                                                                                                                                   "Farbe",                                                                                                                               "Couleur");
			L10N.Add(STR_HSP_NEWGAME,            "Nuova partita",                                                                                                                                "Neues Spiel",                                                                                                                         "Nouveau jeu");
			L10N.Add(STR_HSP_RANDOMGAME,         "Livello casuale",                                                                                                                            "Zufälliges Level",                                                                                                                    "Niveau aléatoire");
			L10N.Add(STR_HSP_MPPOINTS,           "Punteggio Multiplayer",                                                                                                                       "Mehrspieler Punkte",                                                                                                                  "Multiplayer score");
			L10N.Add(STR_MP_TOAST_CONN_TRY,      "Connessione a '{0}'",                                                                                                                     "Verbinden mit '{0}'",                                                                                                                 "Connecter à '{0}'");
			L10N.Add(STR_MP_TOAST_CONN_FAIL,     "Connessione a '{0}' fallita",                                                                                                              "Verbindung mit '{0}' fehlgeschlagen",                                                                                                 "Connexion avec '{0}' est échoué");
			L10N.Add(STR_MP_TOAST_CONN_SUCC,     "Connessione a '{0}'",                                                                                                                      "Verbunden mit '{0}'",                                                                                                                 "Connecté avec '{0}'");
			L10N.Add(STR_ENDGAME_1,              "GRAZIE PER",                                                                                                                              "THANKS FOR",                                                                                                                          "THANKS FOR");
			L10N.Add(STR_ENDGAME_2,              "AVER GIOCATO",                                                                                                                                 "PLAYING",                                                                                                                             "PLAYING");
			L10N.Add(STR_ACCOUNT_REMINDER,       "Puoi creare un account per far apparire il tuo nome nella classifica e per salvare i tuoi dati online.\nVuoi creare un'account?", "Du kannst einen Onlineaccount anlegen um deinen Namen im Highscore zu sehen und deine Punkte zu sichern.\n Account jetzt erstellen?", "Vous pouvez créer un compte pour afficher votre nom dans les meilleurs scores et sauvegarder vos points en ligne.\nVoulez - vous créer un compte maintenant?");
			L10N.Add(STR_BTN_YES,                "Si",                                                                                                                                     "OK",                                                                                                                                  "OK");
			L10N.Add(STR_BTN_NO,                 "No",                                                                                                                                      "Nein",                                                                                                                                "Aucun");

#if DEBUG
			L10N.Verify();
#endif
		}

		public static string FormatNetworkErrorMessage(SAMNetworkConnection.ErrorType type, object data)
		{
			switch (type)
			{
				case SAMNetworkConnection.ErrorType.None:
					return string.Empty;

				case SAMNetworkConnection.ErrorType.ProxyServerTimeout:
					return L10N.T(STR_MP_TIMEOUT);

				case SAMNetworkConnection.ErrorType.ServerUserTimeout:
					return L10N.T(STR_MP_TIMEOUT);

				case SAMNetworkConnection.ErrorType.UserTimeout:
					return L10N.TF(STR_MP_TIMEOUT_USER, data);

				case SAMNetworkConnection.ErrorType.NotInLobby:
					return L10N.T(STR_MP_NOTINLOBBY);

				case SAMNetworkConnection.ErrorType.SessionNotFound:
					return L10N.T(STR_MP_SESSIONNOTFOUND);

				case SAMNetworkConnection.ErrorType.AuthentificationFailed:
					return L10N.T(STR_MP_AUTHFAILED);

				case SAMNetworkConnection.ErrorType.LobbyFull:
					return L10N.T(STR_MP_LOBBYFULL);

				case SAMNetworkConnection.ErrorType.GameVersionMismatch:
					return L10N.TF(STR_MP_VERSIONMISMATCH, GDConstants.Version.ToString());

				case SAMNetworkConnection.ErrorType.LevelNotFound:
					return L10N.T(STR_MP_LEVELNOTFOUND);

				case SAMNetworkConnection.ErrorType.LevelVersionMismatch:
					return L10N.T(STR_MP_LEVELMISMATCH);

				case SAMNetworkConnection.ErrorType.UserDisconnect:
					return L10N.TF(STR_MP_USERDISCONNECT, data);

				case SAMNetworkConnection.ErrorType.ServerDisconnect:
					return L10N.T(STR_MP_SERVERDISCONNECT);

				case SAMNetworkConnection.ErrorType.BluetoothAdapterNotFound:
					return L10N.T(STR_MP_BTADAPTERNULL);

				case SAMNetworkConnection.ErrorType.BluetoothAdapterNoPermission:
					return L10N.T(STR_MP_BTADAPTERPERMDENIED);

				case SAMNetworkConnection.ErrorType.BluetoothInternalError:
					return L10N.T(STR_MP_INTERNAL);

				case SAMNetworkConnection.ErrorType.BluetoothNotEnabled:
					return L10N.T(STR_MP_BTDISABLED);

				case SAMNetworkConnection.ErrorType.P2PConnectionFailed:
					return L10N.T(STR_MP_DIRECTCONNFAIL);

				case SAMNetworkConnection.ErrorType.P2PConnectionLost:
					return L10N.T(STR_MP_DIRECTCONNLOST);

				default:
					SAMLog.Error("L10NI::EnumSwitch_FNEM", "type = "+ type);
					return string.Empty;
			}
		}
	}
}

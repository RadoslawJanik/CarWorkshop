# CarWorkshop
Aby aplikacja działała poprawnie należy zmienić connection string na własny w projekcie MVC w pliku appsettings.json,
następnie należy wywołać komendę "add-migration" w konsoli menadżera pakietów, następnie wywołać komendę "update-database", ważnym jest aby w konsoli ustawić jako projekt domyślny projekt "Infrastructure"
Aplikacja obsługuje dwie role :
Owner: login : owner@example.com
       hasło : test5%
Moderator : login :moderator@example.com
            hasło : test5%

Wykorzystane technologie,paczki,wzorce:
-Frontent stworzony jest na elementach bootstrapowych
-Paczka Toastr do notyfikacji
-odczyt oraz zapis danych odbywa się z wykorzystaniem CQRS przy wykorzystaniu paczki Mediatr
-autoryzacja i uwierzetalnie użytkowników prz pomocy asp.net.identity
-walidacja danych wprowadzanych przez użytkownika przy pomocy paczki FluentValidation
-Automapper

Aplikacja webowa pozwala:
- nie zalogowanemu oraz zalogowanemu zwykłemu użytkownikowi na przeglądanie warsztatów samochodowych, oraz wyświetlenie ich danych i wykonywanych usług
- -użytkownikowi typu Owner na tworzenie warsztatów samochodowych oraz ich edycje, ale tylko stworzonych przez siebie
- użytkownikowi typu Moderator na edycje danych wszyskich warsztatów, ale nie na edycję wykonywanych usług




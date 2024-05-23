**Tesztelő:** Póta László

**Tesztelés dátuma:** 2024.05.23

Tesztszám | Teszteset | Várt eredmény | Eredmény | Megjegyzés
----------|--------------|---------------|----------|-----------
Teszt #01 | Bejelentkezés adatok nélkül| 	A bejelentkezési adatok beírása nélkül a felhasználó figyelmeztetést kap ezeknek pótlására | Adatok nélkül a felhasználó figyelmeztetést kap és a rendszer nem lépteti be | Nem találtam problémát.
Teszt #02 | Bejelentkezés hamis adatokkal | Hamis adatokkal való bejelentkezéskor a felhasználó figyelmeztetést kap erről és nem kerül beléptetésre | A felhasználó nem kerül beléptetésre és felugrik egy figyelmeztető ablak | Nem találtam problémát.
Teszt #03 | Regisztráció megfelelő adatokkal | Megfelelő adatokkal a felhasználó regisztrálásra kerül és erről értesítést kap. | Felhasználó sikeresen regisztrálásra került | Nem találtam problémát. **Fejlesztési javaslat, hogy ezután bezárhatjuk a regisztrációs oldalt és visszaléphetünk a főoldalra.**
Teszt #04 | Regisztráció már meglévő felhasználóval | A felhasználó nem kerül regisztrálásra mert már létezik ilyen az adatbázisban | Felhasználó sikeresen regisztrálásra került mégegyszer | **Regisztráció előtt ellenőrizni kell, hogy az adatbázisban van-e már ilyen felhasználó!**
Teszt #05 | Regisztráció különböző jelszavakkal | A felhasználó nem kerül regisztrálásra hibás adatokkal és erről értesítést kap | Felhasználó nem kerül regisztrálásra de nem kap erről értesítést | **Fejlesztési javaslat, hogy érdemes lehet valamilyen visszajelzés erről!**
Teszt #06 | Bejelentkezés regisztrált felhasználóval | A felhasználó beléptetésre kerül a főoldalra | A felhasználó beléptetésre kerül a főoldalra | Nem találtam problémát.
Teszt #07 | Kilépés gomb | A felhasználó kiléptetésre kerül. | A felhasználó kiléptetésre kerül. | Nem találtam problémát.
Teszt #08 | Előzmények gomb | Megnyílik az előzmények oldal | Megnyílik az előzmények oldal | Nem találtam problémát.
Teszt #09 | Vissza gomb előzmények oldalon | Visszatérünk a főoldalra vagy bezáródik az előzmények és újranyitódik a főoldal | Az előzmények gomb hatására nem záródik a főoldal, így viszont ha onnan visszalépünk még egy ablakban megnyílik a főoldal | **Vagy a főoldal ablakot kell bezárni előzmények nyitásakor, vagy nem szabad új ablakot nyitni onnan visszalépéskor!**
Teszt #10 | Vizsgálat gomb | Megnyílik egy tallózó ablak ahol választhatunk vizsgálati célpontot | Megnyílik egy tallózó ablak ahol választhatunk vizsgálati célpontot | Nem találtam problémát.
Teszt #11 | Tallózás vizsgálat | Kiválasztott tallózás után lefut a víruskeresés aminek az eredménye kiíródik a főoldalon egy listában. | Kiválasztott tallózás után lefut a víruskeresés aminek az eredménye kiíródik a főoldalon egy listában. | Nem találtam problémát.
Teszt #12 | Megjelölés | Megnyílik egy tallózó ablak ahol választhatunk potenciális veszélyforrást | Megnyílik egy tallózó ablak ahol választhatunk potenciális veszélyforrást | Nem találtam problémát.
Teszt #13 | Tallózás megjelölés | Kiválasztott tallózás után lefut a megjelölés aminek az eredménye kiíródik a főoldalon. | Kiválasztott tallózás után lefut a megjelölés aminek az eredménye kiíródik a főoldalon.  | Nem találtam problémát.
Teszt #14 | Vírusjelölés után újravizsgálat | Megnyílik egy tallózó ablak ahol újravizsgáljuk az adott mappát és megtalálja a veszélyforrást | Megnyílik egy tallózó ablak ahol újravizsgáljuk az adott mappát és megtalálja a veszélyforrást | Nem találtam problémát.
Teszt #15 | Előzmények megnyitása vizsgálatok után | Megnyílik egy ablak ahol az előzmény futásokat tekinthetjük meg | Megnyílik egy ablak ahol nem jelennek meg a korábbi vizsgálatok. | **Nem mentődnek el adatbázisba a vizsgálatok eredményei és log fájljai.**
Teszt #16 | Üdvözlő üzenet módosítása | A főoldalon a bal felső sarobkban megjelenik egy üdvözlő üzenet bejelentkezés után. |  főoldalon a bal felső sarobkban megjelenik egy üdvözlő üzenet bejelentkezés után. | **Az üdvözlő üzenet szerkeszthető, törölhető. Célszerű ezt label-lel megvalósítani.**


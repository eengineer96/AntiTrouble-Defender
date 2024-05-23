**Tesztelő:** Csordás Szilveszter

**Tesztelés dátuma:** 2024. 05. 23.

**Talált hibák száma:** 2

Tesztszám | Teszteset | Várt eredmény | Eredmény | Megjegyzés
----------|--------------|---------------|----------|-----------
Teszt #01 | Bejelentkezés hiányos adatokkal | A felhasználót felugró ablak figyelmezteti, hogy adja meg az összes adatot. | Megjelenik a figyelmeztető ablak. | Nem találtam problémát.
Teszt #02 | Bejelentkezés hamis adatokkal | A felhasználót felugró ablak tájékoztatja, hogy a megadott adatokkal nincs felhasználó a nyilvántartásban. | Megjelenik a figyelmeztető ablak, és a felhasználó nem tud bejelentkezni. | Nem találtam problémát.
Teszt #03 | Regisztráció különböző jelszavakkal | Nem történik meg a regisztráció. | A program nem engedi regisztrálni a felhasználót. | Nem találtam problémát. *Megjegyzés: a regisztrációs ablakban egy felirat jelzi a felhasználó számára, hogy a beírt jelszavak nem egyeznek.*
Teszt #04 | Regisztráció már meglévő felhasználóval | Nem történik meg a regisztráció. | A program engedi regisztrálni a felhasználót már használt adatokkal. | *Megjegyzés: ez a művelet az adatbázisban látszólag nem okoz kivételt, viszont lehet esetlegesen más zavaró hatása.*
Teszt #05 | Regisztráció már meglévő felhasználóval, de más jelszóval | Nem történik meg a regisztráció. | A program engedi regisztrálni a felhasználót már használt felhasználónévvel és új jelszóval. Ezután a régi jelszóval már nem lehet bejelentkezni, csak az újjal. | **Fejlesztési javaslat: ez a hiba éles rendszerben komoly problémát okoz, mivel lehetővé teszi a felhasználói fiókok eltulajdonítását illetéktelen személy által. Mindenképpen javításra szorul!**
Teszt #06 | Regisztráció megfelelő adatokkal | A felhasználó regisztrálásra kerül a megadott adatokkal. | Az új felhasználó regisztrálásra került a rendszerben. | Nem találtam problémát.
Teszt #07 | Vissza gomb a regisztráció oldalon | A regisztrációs ablak bezáródik. Nem nyílik meg újabb ablak. | A regisztrációs ablak bezáródik. *Megjegyzés: a korábbi hiba javításával nem nyílik meg újabb bejelentkező ablak.* | Nem találtam problémát.
Teszt #08 | Bejelentkezés regisztrált felhasználóval | A felhasználó sikeresen bejelentkezik és átkerül a főoldalra. | A bejelentkezés sikeres, megjelenik a főoldal. | Nem találtam problémát.
Teszt #09 | Előzmények gomb | Megnyílik az előzmények ablak. | Megnyílik az előzmények ablak, ami még üres (még nem végeztem korábbi vizsgálatokat). | Nem találtam problémát.
Teszt #10 | Vissza gomb az előzmények oldalon | A felhasználó visszatér a főoldalra. | Az előzmények oldal megfelelően bezáródik. *Megjegyzés: a korábbi hiba javításával nem nyílik meg újabb főoldal ablak.* | Nem találtam problémát.
Teszt #11 | Vizsgálat gomb | Megnyílik egy tallózó ablak, ahol kiválaszthatjuk a vizsgálni kívánt mappát. | Megnyílik a tallózó ablak. | Nem találtam problémát.
Teszt #12 | Mégse gomb a tallózó ablakban | Visszalépés a tallózó ablakból, a program nem dob kivételt. | A program nem dob kivételt. | Nem találtam problémát. *Megjegyzés: a fejlesztés korai fázisában ez a művelet váratlan kivételt váltott ki, de a kód refaktorálásával azonnali javításra került.*
Teszt #13 | Tallózás vizsgálat | Kiválasztott tallózás után megtörténik a víruskeresés, aminek az eredménye kiíródik a főoldalon egy listában. | Megtörténik a víruskeresés, a vizsgált fájlok megtekinthetőek a listában. | Nem találtam problémát.
Teszt #14 | Megjelölés | Megnyílik egy tallózó ablak, ahol kiválaszthatjuk a karanténba helyezni kívánt fájlt. | Megnyílik a tallózó ablak. | Nem találtam problémát.
Teszt #15 | Tallózás megjelölés | Kiválasztott tallózás után megtörténik a megjelölés, aminek az eredményét felugró ablak jelzi. | Megtörténik a fájl megjelölése, erről felugró ablak tájékoztat. | Nem találtam problémát.
Teszt #16 | Vírusjelölés után újbóli vizsgálat | Újra megvizsgálva az adott mappát, a program megtalálja a veszélyforrást. | A program megtalálja a felhasználó által megjelölt veszélyforrást. | Nem találtam problémát.
Teszt #17 | Előzmények megnyitása vizsgálatok után | Megnyílik egy ablak, ahol az előző vizsgálatok eredményeit tekinthetjük meg | Megnyílik az előző vizsgálatok ablak, viszont nem jelennek meg a korábbi vizsgálatok eredményei. | **Fejlesztési javaslat: A vizsgálat során nem kerülnek mentésre az adatbázisba a vizsgálatok eredményei.**
Teszt #18 | Kilépés gomb | A felhasználót megkérdezi a program, biztosan ki szeretne-e lépni. Igenlő válasz esetén megtörténik a kijelentkeztetés. | Megjelenik az üzenet, a választól függően megtörténik a kijelentkeztetés. | Nem találtam problémát.

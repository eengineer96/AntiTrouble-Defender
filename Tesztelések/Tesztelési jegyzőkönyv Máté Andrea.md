**Tesztelő:** Máté Andrea

**Tesztelés dátuma:** 2024. 05. 23.

**Talált hibák száma:** 0

Tesztszám | Teszteset | Várt eredmény | Eredmény | Megjegyzés
----------|--------------|---------------|----------|-----------
Teszt #01 | Bejelentkezés hiányos adatokkal | A felhasználót felugró ablak figyelmezteti, hogy adja meg az összes adatot. | Megjelenik a figyelmeztető ablak. | Nem találtam problémát.
Teszt #02 | Bejelentkezés hamis adatokkal | A felhasználót felugró ablak tájékoztatja, hogy a megadott adatokkal nincs felhasználó a nyilvántartásban. | Megjelenik a figyelmeztető ablak, és a felhasználó nem tud bejelentkezni. | Nem találtam problémát.
Teszt #03 | Regisztráció különböző jelszavakkal | Nem történik meg a regisztráció. | A program nem engedi regisztrálni a felhasználót. | Nem találtam problémát.
Teszt #04 | Regisztráció megfelelő adatokkal | A felhasználó regisztrálásra kerül a megadott adatokkal. | Az új felhasználó regisztrálásra került a rendszerben. | Nem találtam problémát.
Teszt #05 | Vissza gomb a regisztráció oldalon | A regisztrációs ablak bezáródik. Nem nyílik meg újabb ablak. | A regisztrációs ablak bezáródik. *Megjegyzés: a korábbi hiba javításával nem nyílik meg újabb bejelentkező ablak.* | Nem találtam problémát.
Teszt #06 | Bejelentkezés regisztrált felhasználóval | A felhasználó sikeresen bejelentkezik és átkerül a főoldalra. | A bejelentkezés sikeres, megjelenik a főoldal. | Nem találtam problémát.
Teszt #07 | Előzmények gomb | Megnyílik az előzmények ablak. | Megnyílik az előzmények ablak, ami még üres (még nem végeztem korábbi vizsgálatokat). | Nem találtam problémát.
Teszt #08 | Vissza gomb az előzmények oldalon | A felhasználó visszatér a főoldalra. | Az előzmények oldal megfelelően bezáródik. *Megjegyzés: a korábbi hiba javításával nem nyílik meg újabb főoldal ablak.* | Nem találtam problémát.
Teszt #09 | Vizsgálat gomb | Megnyílik egy tallózó ablak, ahol kiválaszthatjuk a vizsgálni kívánt mappát. | Megnyílik a tallózó ablak. | Nem találtam problémát.
Teszt #10 | Mégse gomb a tallózó ablakban | Visszalépés a tallózó ablakból, a program nem dob kivételt. | A program nem dob kivételt. | Nem találtam problémát.
Teszt #11 | Tallózás vizsgálat | Kiválasztott tallózás után megtörténik a víruskeresés, aminek az eredménye kiíródik a főoldalon egy listában. | Megtörténik a víruskeresés, a vizsgált fájlok megtekinthetőek a listában. | Nem találtam problémát.
Teszt #12 | Megjelölés | Megnyílik egy tallózó ablak, ahol kiválaszthatjuk a karanténba helyezni kívánt fájlt. | Megnyílik a tallózó ablak. | Nem találtam problémát.
Teszt #13 | Tallózás megjelölés | Kiválasztott tallózás után megtörténik a megjelölés, aminek az eredményét felugró ablak jelzi. | Megtörténik a fájl megjelölése, erről felugró ablak tájékoztat. | Nem találtam problémát.
Teszt #14 | Vírusjelölés után újbóli vizsgálat | Újra megvizsgálva az adott mappát, a program megtalálja a veszélyforrást. | A program megtalálja a felhasználó által megjelölt veszélyforrást. | Nem találtam problémát.
Teszt #15 | Kilépés gomb | A felhasználót megkérdezi a program, biztosan ki szeretne-e lépni. Igenlő válasz esetén megtörténik a kijelentkeztetés. | Megjelenik az üzenet, a választól függően megtörténik a kijelentkeztetés. | Nem találtam problémát.

**Tesztelő:** Kállai Viktor

**Tesztelés dátuma:** 2024. 05. 24.

**Megjegyzések száma:** 2(Teszt #04, Teszt #05)

Tesztszám | Teszteset | Várt eredmény | Eredmény | Megjegyzés
----------|--------------|---------------|----------|-----------
Teszt #01 | Bejelentkezés hiányos adatokkal | Figyelmeztetést kap a felhasználó, felugró ablak formájában | Megjelenik a figyelmeztető ablak. | Nem találtam problémát.
Teszt #02 | Bejelentkezés hamis adatokkal | A felhasználót felugró ablak tájékoztatja, hogy a megadott adatokkal nincs felhasználó a nyilvántartásban. | Megjelenik a figyelmeztető ablak, nem tud bejelentkezni a felhasználó | Nem találtam problémát.
Teszt #03 | Regisztráció különböző jelszavakkal | Nem történik meg a regisztráció. | Még nem kap a program 2 azonos jelszót, nincs regisztráció | Nem találtam problémát.
Teszt #04 | Regisztráció már meglévő felhasználóval | Nem történik meg a regisztráció. | Lehetséges a regisztráció, már meglévő adatokkal  | Esedékes egy funkció, ami ellenőrzi, hogy van-e már ilyen adattal regisztrált user
Teszt #05 | Regisztráció már meglévő felhasználóval, de más jelszóval | Nem történik meg a regisztráció. | "elfelejtette a jelszavát" funkció lép életbe, új jelszót kap ugyanazon felhasználó | 4. tesztben említett funkció megoldhatná a gondot
Teszt #06 | Regisztráció megfelelő adatokkal | A felhasználó regisztrálásra kerül a megadott adatokkal. | Az új felhasználónév és jelszó regisztrálásra kerül az adatbázisban | Nem találtam problémát.
Teszt #07 | Vissza gomb a regisztráció oldalon | A regisztrációs ablak bezáródik.| A regisztrációs ablak bezáródik. | Nem találtam problémát.
Teszt #08 | Bejelentkezés regisztrált felhasználóval | A Bejelentkezés sikeres megjelenik a főoldal | A bejelentkezés sikeres | Nem találtam problémát.
Teszt #09 | Előzmények gomb | Megnyílik az előzmények ablak. | Az Előzmények ablak megnyílik | Nem találtam problémát.
Teszt #10 | Vissza gomb az előzmények oldalon | A felhasználó visszatér a főoldalra. | Bezáródik az előzmények ablak | Nem találtam problémát.
Teszt #11 | Vizsgálat gomb | A tallózó ablak megnyílik | Megnyílik a tallózó ablak. | Nem találtam problémát.
Teszt #12 | Mégse gomb a tallózó ablakban | Visszalépés a főoldalra | A program visszalép a főoldalra | Nem találtam problémát.
Teszt #13 | Tallózás vizsgálat | Tallózás után megtörténik a víruskeresés, aminek az eredménye kiíródik a főoldalon egy listában. | Megtörténik a víruskeresés, a vizsgált fájlok megtekinthetőek. | Nem találtam problémát.
Teszt #14 | Megjelölés | Megnyílik egy tallózó ablak, ahol kiválaszthatjuk a karanténba helyezni kívánt fájlt. | A tallózó ablak megnyílik, a fájl kiválasztható | Nem találtam problémát.
Teszt #15 | Tallózás megjelölés | Kiválasztott tallózás után megtörténik a megjelölés, aminek az eredményét felugró ablak jelzi. | Felugró ablak tájékoztat a megjelölésről | Nem találtam problémát.
Teszt #16 | Kilépés gomb | A felhasználót megkérdezi a program, biztosan ki szeretne-e lépni. Igenlő válasz esetén megtörténik a kijelentkeztetés. | Megjelenik az üzenet, a választól függően megtörténik a kijelentkeztetés, a program megfelelően záródik. | Nem találtam problémát.

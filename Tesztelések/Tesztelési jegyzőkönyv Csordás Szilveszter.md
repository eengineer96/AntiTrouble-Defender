**Tesztelő:** Csordás Szilveszter

**Tesztelés dátuma:** 2024. 05. 23.

Tesztszám | Teszteset | Várt eredmény | Eredmény | Megjegyzés
----------|--------------|---------------|----------|-----------
Teszt #01 | Bejelentkezés hiányos adatokkal | A felhasználót felugró ablak figyelmezteti, hogy adja meg az összes adatot. | Megjelenik a figyelmeztető ablak. | Nem találtam problémát.
Teszt #02 | Bejelentkezés hamis adatokkal | A felhasználót felugró ablak tájékoztatja, hogy a megadott adatokkal nincs felhasználó a nyilvántartásban. | Megjelenik a figyelmeztető ablak, és a felhasználó nem tud bejelentkezni. | Nem találtam problémát.
Teszt #03 | Regisztráció különböző jelszavakkal | Nem történik meg a regisztráció. | A program nem engedi regisztrálni a felhasználót. | Nem találtam problémát. *Megjegyzés: a regisztrációs ablakban egy felirat jelzi a felhasználó számára, hogy a beírt jelszavak nem egyeznek.*
Teszt #04 | Regisztráció már meglévő felhasználóval | Nem történik meg a regisztráció. | A program engedi regisztrálni a felhasználót már használt adatokkal. | *Megjegyzés: ez a művelet az adatbázisban látszólag nem okoz kivételt, viszont lehet esetlegesen más zavaró hatása.*
Teszt #05 | Regisztráció már meglévő felhasználóval, de más jelszóval | Nem történik meg a regisztráció. | A program engedi regisztrálni a felhasználót már használt felhasználónévvel és új jelszóval. Ezután a régi jelszóval már nem lehet bejelentkezni, csak az újjal. | **Fejlesztési javaslat: ez a hiba éles rendszerben komoly problémát okoz, mivel lehetővé teszi a felhasználói fiókok eltulajdonítását illetéktelen személy által. Mindenképpen javításra szorul!**
Teszt #06 | Regisztráció megfelelő adatokkal | A felhasználó regisztrálásra kerül a megadott adatokkal. | Az új felhasználó regisztrálásra került a rendszerben. | Nem találtam problémát.
Teszt #07 | Bejelentkezés regisztrált felhasználóval | A felhasználó sikeresen bejelentkezik és átkerül a főoldalra. | A bejelentkezés sikeres, megjelenik a főoldal. | Nem találtam problémát.


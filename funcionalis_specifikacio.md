# Funkcionális specifikáció

## Készítette

- Máté Andrea

## 1. Jelenlegi helyzet leírása

Jelenleg egy új generációs víruskeresőt fejlesztünk ügyfelünk számára, amely lehetővé teszi munkatársaik számára, hogy könnyedén felderítsenek rendszerükben minden lehetséges fenyegetést, beleértve vírusokat és kártékony programokat. Emellett célunk, hogy ez az alkalmazás a további fejlesztések során teljes körű és megbízható víruskereső szolgáltatássá váljon megerndelőnk számára. Egy másik előnye ennek az alkalmazásnak, hogy számos eszközön elérhető lesz, és a jövőben tervezzük, hogy mobil eszközökre is kiterjesszük a funkcionalitást. Az ügyfélnek lehetősége lesz az alkalmazás segítségével ellenőrizni bizonyos mappákat és folyamatokat a rendszerben.

## 2. Vágyálomrendszer leírása

Az ügyfél célja egy hatékony és megbízható vírusvédelmi rendszer kialakítása, amely védelmet nyújt számítógépeik számára a vírusok és kártevők ellen. Partnerünk kifejezte kívánságát, hogy a fejlesztés során a .NET keretrendszert és a C# programozási nyelvet alkalmazzuk, amelyek nagy támogatottsága és objektumorientált jellegük lehetővé teszi az alkalmazás későbbi bővítését. A tökéletes rendszernek tartalmaznia kell a következőket:

 - Automatikus vírusdefiníciók frissítése
 - Hatékony fájl-analízis és víruskeresés
 - Futó folyamatok ellenőrzése
 - Egyszerű kezelhetőség és felhasználóbarát felület
 - Megfelelő támogatás és karbantartás a hibák gyors javítása érdekében

Ennek a vágyálomrendszernek a bevezetése jelentős mértékben növelné ügyfelünk üzleti folyamatainak hatékonyságát és eredményességét.

## 3. Jelenlegi üzleti folyamatok modellje

Az aktuális üzleti folyamatok modellje alapján a felhasználóknak nem áll módjukban vírusvédelmi alkalmazást használni. Ez az hiányosság jelentős kockázatot hordoz a vállalat számára, hiszen a különböző vírusok, rosszindulatú szoftverek könnyen fertőzhetik meg a rendszereket és hálózatokat, így veszélyeztetve az üzleti folyamatok zavartalan működését és az üzleti adatok biztonságát. A vírusok és más fenyegetések elleni védelem hiánya súlyos pénzügyi veszteségeket okozhat a vállalatnak, és károsíthatja annak hírnevét is. Ezért kritikus fontosságú, hogy bevezessünk egy hatékony vírusvédelmi szoftvert a vállalat számára, amely megfelelő védelmet nyújt a számítógépek és az adatok számára a különféle fenyegetések ellen.

## 4. Igényelt üzleti folyamatok modellje

Az elvárt üzleti folyamatok modellje szerint az alkalmazás lehetőséget nyújt a felhasználóknak, hogy kézi módon vizsgálják át az állományokat a vírusok és más potenciális fenyegetések felismerése érdekében. Az alkalmazás felismeri a potenciálisan gyanús fájlokat és értesíti a felhasználókat, ha veszélyt fedez fel. A felhasználóknak lehetőségük van kiválasztani az átvizsgálandó mappákat vagy fájlokat, majd az alkalmazás elvégzi az ellenőrzést és jelzi, ha bármilyen potenciális fenyegetést talál. Az alkalmazás továbbá képes lesz frissíteni a vírusdefiníciókat, hogy mindig naprakész legyen a vírusok és más fenyegetések felismerésében. Ezáltal a folyamat egyszerűsödik, lehetővé téve a felhasználók számára hatékonyabb védekezést a különböző fenyegetésekkel szemben.

## 5. Követelménylista

| Id | Modul | Név | Leírás |
| :---: | --- | --- | --- |
| M1 | Felhasználókezelés | Bejelentkezés | A felhasználók képesek bejelentkezni az alkalmazásba |
| M2 | Felhasználókezelés | Jelszó módosítás | Regisztrált felhasználók megváltoztathatják jelszavukat |
| M3 | Interfész | Folyamatok megjelenítése | A felhasználók láthatják a jelenleg futó folyamatokat |
| M4 | Interfész | Folyamat leállítása | A felhasználók leállíthatják a kiválasztott folyamatot |
| M5 | Tallózás | Fájlok és mappák böngészése | A felhasználók böngészhetik a rendszer fájljait és mappáit |
| M6 | Vizsgálat | Fájlok és mappák ellenőrzése | A felhasználók átvizsgálhatják a kiválasztott fájlokat és mappákat |
| M7 | Frissítés | Vírusdefiníciók frissítése | Az alkalmazás automatikusan frissíti a vírusdefiníciókat az aktuális védelem érdekében |
| M8 | Értesítés | Felhasználói értesítések | A rendszer értesíti a felhasználókat, ha potenciális káros fájlokat észlel a rendszerben |

## 6. Használati esetek

Az alkalmazás minden funkcióját kizárólag regisztráció után lehet használni, anélkül nem áll rendelkezésre semmilyen funkció.

## 7. Képernyőtervek

![login](https://github.com/eengineer96/AntiTrouble-Defender/assets/43788835/298d26a7-60b5-4c2d-a808-6bab895d2023)

![registration](https://github.com/eengineer96/AntiTrouble-Defender/assets/43788835/7fff6fcd-d73b-4159-b3e5-3d343731a265)

![main](https://github.com/eengineer96/AntiTrouble-Defender/assets/43788835/e55ce5ed-26a2-4959-980e-9659b36dba49)

## 8. Forgatókönyvek

Regisztrált felhasználók számára elérhető több fájl vagy meghajtó átvizsgálása, valamint lehetőség van a folyamatok ellenőrzésére és leállítására is.

## 9. Fogalomszótár

**Interfész**: Az a felület, amellyel a felhasználó érintkezik és a szoftverben navigálat, elérheti a különböző funkciókat.

**Folyamat**: Az aktuálisan futó programrész, ami jelen van a számítógép memóriájában és működésben van, feladatát ellátva.

**Malware/Vírus:** A rosszindulatú számítógépes programok összefoglaló neve. Ide tartoznak: a vírus, féreg, kémprogram, zsarolóprogram, agresszív reklámprogram, és minden egyéb kártékony szoftver.

**Hash:** A hashelés azt a folyamatot jelenti, amelynek során egy változó méretű bemenetből egy fix méretű kimenetet állítunk elő. Ez a hash függvénynek nevezett matematikai függvények (hash-algoritmusok) használatával történik. A hash az ezen algoritmusok által előállított, fix hosszúságú karkatersorozat.

**Vírusdefiníciók**: Adatbázisok, melyekben tárolva vannak a vírusok és más kártékony programok azonosításához szükséges információk.

**Karantén:** A karantén fő funkciója a talált gyanús objektumok (például kártevő, fertőzött fájlok vagy kéretlen alkalmazások) biztonságos tárolása.

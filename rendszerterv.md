# Rendszerterv az AntiTrouble-Defender vírusirtó alkalmazáshoz
## 1. A rendszer célja
A vírusírtó szoftver célja, hogy hatékony védelmet nyújtson a felhasználók számítógépeinek és adatrendszerének a kártékony szoftverek ellen. A szoftver fő céljai közé tartozik:
- **Processzek lekérdezése és ellenőrzése:** A szoftver képes lesz folyamatokat lekérdezni és ellenőrizni a rendszeren, hogy azonosítsa és megelőzze a potenciálisan veszélyes tevékenységeket.
- **Kiválasztott mappa átfésülése:** A szoftver lehetővé teszi a felhasználók számára, hogy kiválasszák a mappákat, amelyeket átvizsgálhatnak a kártékony fájlok és tevékenységek azonosítása érdekében.
- **Frissítés egy központi adatbázisból:**  A szoftver automatikusan frissíti magát egy központi adatbázisból, hogy biztosítsa a legújabb vírusdefiníciókat és biztonsági frissítéseket a felhasználók számára.
- **Hash alapú azonosítás:** A vírusírtó szoftver hash alapú azonosítási mechanizmust használ a fájlok integritásának és változásainak ellenőrzésére, lehetővé téve a potenciálisan káros fájlok azonosítását és kezelését.

## 2. Projektterv
### 2.1 Szerepkörök
- Scrum Master:
  - Varga Balázs
- Product owner: Bagoly Gábor
- Üzleti szerep:
  - Megrendelő: Bagoly Gábor

### 2.2 Projekt fejlesztésében résztvevők és feladataik:
- Program megvalósítása:
  - Frontend: Póta László
  - Backend: Póta László
- Dokumentációk elkészítése:
  - Funkcionális specifikáció: Máté Andrea
  -  Követelmény Specifikáció: Csordás Szilveszter
  -  Rendszerterv: Kállai Viktor
- Tesztelés:
  - Máté Andrea
  - Csordás Szilveszter
  - Póta László
  - Kállai Viktor

### 2.3 Ütemterv:
|    **Funkció**    |          **Feladat**          |**Prioritás**|**Tervezett időigény(óra)**|**Tényleges ráfordított idő(óra)**| 
|:-----------------:|:-----------------------------:|:-----------:|:-------------------------:|:--------------------------------:|
| Követelmény Specifikáció | Megírás | 1 | 36 | 32(in prgress) |
| Funkcionális Specifikáció | Megírás | 1 | 36 | 30(in progress) |
| Rendszerterv | Megírás | 1 | 36 | 12(in progress) | 

### 2.4 Mérföldkövek
- 2024.04.06 konzultációra következők átadása:
  - Követelmény specifikáció
  - Funkcionális specifikáció
  - Rendszerterv
  - Alkalmazás alapjainak bemutatása

## 3. Üzleti folyamatok modellje

### 3.1 Üzleti szereplők

A szoftver korlátozások nélkül bármely gépre telepíthető és ezek után használatba vehető, olyan felhasználók számára akinek erre a megrendelő engedélyt ad. 

###3.2 Üzleti folyamatok

Az alkalmazás elindítása után a user személyre szabhatja, milyen beállításokkal kívánja használni a víruskereső programot, lehetősége nyílik egy egész háttértárnyi tartalom átvizsgálására, viszont csak megadott könyvtárak vizsgálatára is van lehetőség, a gyorsabb felderítés érdekében. A keresés pontosságát pedig, a háttérben frissülő vírusadatbázis fogja segíteni! A végeredményt az erre szolgáló vizsgálati eredmények névvel ellátott boxban találhatja meg! Továbbá lehetősége nyílik a felhasználónak a víruskeresés mellett, a rendszerben éppen futó processzek és folyamatok lekérdezésére is!

- Vizsgálni kívánt fájltartomány kiválasztása: a felhasználó itt döntheti el, hogy milyen terjedelemben szeretné elvégezni számítógépe átvizsgálását.
- Éppen futó processzek: A felhasználó ezen menüpontban láthatja, milyen folyamatok futnak a számítógépén és dönthet a további használatukról.
- Víruskeresés indítása: Ezen funkcióval a korábban megadott beállításokkal elindul a víruskereső folyamat majd a vizsgálati eredményt a felhasználó az arra kijelölt helyen(vizsgálati eredmények box) megtalálja.   

## 4. Követelmények

**Funkcionális követelmények**
| **Id** |   **Modul**  |           **Név**          |                                                                                                                      **Leírás**                                                                                                                     |
|:------:|:------------:|:--------------------------:|:---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------:|
|   K1   | Víruskeresés | Teljes rendszer vizsgálata | A program a teljes rendszert átvizsgálja, az adatbázisban szereplő malware-ek után kutatva. Ez egy alapos, átfogó vizsgálat, amely hosszabb időt vesz igénybe.                                                                                      |
|   K2   | Víruskeresés |  Kijelölt mappa vizsgálata | A program csak a felhasználó által kiválasztott mappát vizsgálja át, nem a teljes rendszert. Ezáltal csökken a vizsgálat futási ideje. Akkor célszerű ezt választani, ha kisebb változtatások után csak az érintett részeket szeretnék átvizsgálni. |
|   K3   |  Processzek  |   Processzek lekérdezése   | A program lekérdezi az aktuálisan futó processzeket, és megjeleníti a részleteiket.                                                                                                                                                                 |
|   K4   |  Processzek  |    Processzek leállítása   | A kilistázott processzeket lehetőség van megszakítani és leállítani, ha a processz nem válaszol, vagy túl sok erőforrást használ.                                                                                                                   |

**Nem funkcionális követelmények**
| **Id** |   **Modul**  |           **Név**          |                                                                                                                      **Leírás**                                                                                                                     |
|:------:|:------------:|:--------------------------:|:---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------:|
|   K5   |    Felület   |           Főablak          | Az alkalmazás főablaka, itt választhatja ki a felhasználó, hogy milyen műveletet szeretne végrehajtani. A felület legyen egyszerű, letisztult, könnyen átlátható.                                                                                   |
|   K6   |   Adatbázis  |  Saját központi adatbázis  | A vállalat által kiszűrni kívánt állományokat tartalmazza az adatbázis. Ezek némelyike más vírusirtók adatbázisaiban nem található meg. Az adatbázis legyen bővíthető.                                                                              |

**Támogatott eszközök**
Az alkalmazás C# programnyelven készült, ezért platformfüggő! Windows operációsrendszeren használható, telepített .NET Frameworkkel!
















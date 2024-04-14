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
  - Backend: Póta László, Csordás Szilveszter, Máté Andrea, Kállai Viktor
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

### 3.2 Üzleti folyamatok

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

## 5. Funkcionális terv

### 5.1 Rendszerszereplők

A rendszer a helyi felhasználó számítógépére települ és mellé az adatbázis is, nincs szükség internetre a program futásához! A program egy jogosultsági körrel működik!

5.2 Menühierarchiák

A felhasználót a program megnyitása után a főoldalra jut, ahol kiválaszthatja a víruskeresés mélységét mappaszinten, majd elindíthatja azt! A keresés végeredményét a az arra kijelölt helyen(vizsgálati eredmények box) találja!  Valamint az éppen futó processzek menüpont alatt, a folyamatokat láthatja, korlátozhatja és leállíthatja őket!

## 6. Fizikai környezet

**Vásárolt komponensek és külső rendszerek**

Nincsenek vásárolt komponensek az alkalmazáshoz!

**Hardvertopológia**

Az alkalmazás 64 bites Windows operációsrendszerrel ellátott számítógépre lett fejlesztve!

**Fizikai alrendszerek**

Felhasználói számítógépek: 64 bites architektúrával rendelkező számítógépek, Windows operációsrendszerrel és .NET keretrendszerrel!

## 7. Architekturális terv

**Webszerver**

Webszerver használatára nincs szükség, az alkalmazás nem kapcsolódik internethálózathoz!

**Adatbázisrendszer**

Az alkalmazás a saját előre elkészített adatbázisához csatlakozik a program indulásakor, amely a telepítéskor kerül fel!

**Alkalmazás elérése, kezelése**

Az alkalmazást Windows operációsrendszerrel ellátott számítógép használhatja, amelyre telepítve van a .NET framework keretrendszer is! A program indítása a futtatható állományra vagy a parancsikonra való duplakattintással történik!

## 8. Adatbázis terv

### 8.1. Vírusdefiníciók tárolása:

**Tábla neve:**
- Virus_Definitions

**Mezők:**
- VirusID: egyedi azonosító a vírusdefiníciókhoz(Primary key)
- VirusName: a vírus neve
- VírusType: a vírus típusa(trójai, kémprogram stb.)
- Signature: a vírus azonosítására szolgáló hash érték vagy aláírás
- Description: a vírus rövid leírása

### 8.2. Frissítési információk tárolása:

**Tábla neve:**
- UpdateLogs

**Mezők:**
- UpdateID: egyedi azonosító a frissítési naplóhoz(Primary key)
- UpdateDate: a frissítés időpontja
- UpdateType: a frissítés típusa(vírusdefiníció, programfrissítés stb.)
- UpdateDescription: a frissítés rövid leírása

### 8.3. Felhasználói beállítások tárolása:

**Tábla neve:**
- UserSettings

**Mezők:**
- UserID: egyedi azonosító felhasználókhoz(Primary key)
- ScanPath: a felhasználó által választott mappa az átvizsgáláshoz
- ScanFrequency: átvizsgálás gyakorisága
- UpdateFrequency: frissítés gyakorisága

### 8.4. LogFájlok tárolása:

**Tábla neve:**
- ScanLogs

**Mezők:**
- UserID: egyedi azonosító felhasználóhoz
- LogID: egyedi azonosító logfájlokhoz(Primary key)
- ScanDate: a vizsgálat időpontja
- InfectedFiles: azon fájlok száma, amelyek fertőzöttek
- CleanedFiles: azon fájlok száma, amelyeket megtisztítottak, vagy eltávolítottak
- ScanResult: a vizsgálat eredménye(Sikeres, Fertőzött fájlokat találtunk stb.)


## 9. Implementációs terv

- Windows WPF alkalmazás - a felhasználói felület
- Az alkalmazás az OOP szemlélet segítségével készült
- Az alkalmazás C# nyelven íródott, ami .NET keretrendszer segítségével fut

## 10. Tesztterv

A tesztelések célja a rendszer és a komponensei funkcionalitásának teljes vizsgálata, ellenőrzése, a rendszer által megvalósított üzleti szolgáltatások verifikálása. A tesztelést igény szerint elvégezzük különböző hardveres környezetben. A tesztelés során használt hardverek a napjainkban általánosan elterjedt hardverkonfigurációjú PC-k, laptopok. A különböző forgatókönyvek eredményét vizsgáljuk, amennyiben az elvártnak megfelelő eredményt kapjuk a teszteset sikeresnek tekinthető, ellenkező esetben a hibát rögzítjük a jegyzőkönyvben. A teszt során elkészült jegyzőkönyveket mellékeljük a megrendelő részére. Hibatalálat esetén a szoftver kódja javításra kerül.

## 11. Telepítési terv

Fizikai telepítési terv: 

- a víruskereső alkalmazásnak kezdetben nincs szüksége internetre való csatlakozáshoz, sem webszerverre, sem adatbázisszerverre standalone módban is tud működni!

Szoftveres telepítési terv: 

- az alkalmazás használatához szükség lesz egy 64 bites architektúrájú Windows operációsrendszert futtató számítógépre amelyen van .NET keretrendszer.

## 12. Karbantartási terv

### 12.1. Rendszeres frissítések:

- Naprakészen tartjuk a vírusdefiníciókat és a szoftver verzióját

### 12.2. : Teljesítmény - és stabilitás tesztek:

- Rendszeresen teszteljük az alkalmazás teljesítményét és stabilitását különböző környezetekben és terhelések mellett.

### 12.3. : Hibajavítás:

- Gyorsan reagálunk az előforduló hibákra és problémákra, és biztosítjuk a szükséges javító frissítéseket.

### 12.4. : Biztonsági pótlások:

- Figyeljük az új biztonsági fenyegetéseket és sebezhetőségeket, és gyorsan kiegészítjük vele az alkalmazást.

### 12.5. : Felhasználói visszajelzések:

- Figyelembe vesszük a felhasználók visszajelzéseit és igényeit, és ezek alapján fejlesztjük az alkalmazást.

### 12.6. : Dokumentáció karbantartása:

- Frissítjük és karbantartjuk az alkalmazás dokumentációját, hogy naprakész és pontos információkat nyújtsunk a felhasználóknak és a fejlesztőknek.





























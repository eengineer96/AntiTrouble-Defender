# Követelmény specifikáció az AntiTrouble-Defender vírusirtó alkalmazáshoz
## 1. Áttekintés, összefoglaló
Egy fejlődő informatikai vállalat azzal bízta neg cégünket, hogy tervezzünk meg és készítsünk el egy olyan vírusirtó alkalmazást, amely megfelel az igényeiknek.  
Az általuk eddig használt vírusirtó szoftver már csak korlátozott ideig elérhető, és egyébként sem tartalmazott minden olyan funkciót, amelyre a vállalatnak szüksége lenne.
Ezért a cégvezetők és a fejlesztők közös megbeszélés után azt a döntést hozták, hogy felkérik cégünket egy személyre szabott vírusirtó alkalmazás elkészítésére.

## 2. A jelenlegi helyzet leírása
A cég eddig egy harmadik féltől származó vírusirtó alkalmazást vett igénybe, mellyel több probléma is volt. Először is, a használathoz elő kellett fizetniük, mely havonta egy nem túl nagy, ám hosszútávon már jelentős összeggel terhelte a vállalatot.  
A rendszer átvizsgálása lassú, sok időt vesz igénybe, ugyanis nincs lehetőség az érintett mappák kiválasztására, minden esetben a teljes rendszert egészében kell átvizsgálni. A módosítások által érintetlen részek "felesleges" vizsgálata természetesen nemcsak időt, hanem erőforrásokat is igényel.  
Több alkalommal is előfordult, hogy a vírusirtó által használt adatbázisban nem szerepeltek azok a malware-ek, amelyeknek megkeresésére szerettek volna vizsgálatot indítani. Emiatt egy alkalommal benne maradt a rendszerben egy kétes eredetű fájl, amire csak napokkal később derült fény, az okozott hibák javítása pedig bevételkiesést okozott a cégnek.

## 3. Vágyálomrendszer leírása
A fenti okokból kifolyólag születet a döntés, hogy megbízzák csapatunkat egy személyre szabott alkalmazás megalkotásával, ami minden felmerülő igényüket kielégíti.  
Az elsődleges cél az, hogy a vírusirtó egy saját adatbázisból dolgozzon, amelybe a vállalat által kiszűrni kívánt malware-ek felvehetőek, és amely igény esetén kibővíthatő. Ezáltal nemcsak az integrációs problémáknak vetnek véget, hanem azt is biztosítják, hogy a szoftver minden potenciálisan kártékony fájlt megtaláljon.  
Elvárás még, hogy a rendszerükön végzett kisebb módosítások után ne kelljen mindig a teljes rendszert átvizsgálni, legyen lehetőség az érintett könyvtárakat kiválasztani, és csak azokat átfésülni, az ellenőrzés meggyorsítása érdekében.  
Célkitúzés továbbá, hogy a rendszerben futó processzeket, folyamatokat is le lehessen kérdezni, szükség esetén kontrollálni, leállítani.

## 4. Jelenlegi üzleti folyamatok modellje
A jelenlegi üzleti modell legnagyobb problémája az, hogy nem minden esetben működik megbízhatóan. Ugyan az általános vírusok kiszűrésére és hatástalanítására jól használható, de nem tudja kezelni a vállalat által specifikusan kiszűrni kívánt malware fájlokat, sok esetben meg sem találja azokat.  
A rendszer átvizsgálása indokolatlanul sok időt vesz igénybe kisebb módosítások, javítások után, mivel nincs lehetőség az érintett mappák kiválasztására, csak a teljes rendszer vizsgálatára.   
Nincs lehetőség arra sem, hogy a rendszerben futó processzeket áttekintsék a vírusirtó segítségével, tehát monitorozni, kezelni sem lehet őket. Ezt a feladatot a rendszergazdáknak külön kell elvégezniük.
Mindezeken túl a vírusirtó használatáért a cégnek havidíjat is kell fizetnie. A megszűnő vírusirtó helyett nem akarnak egy másik, esetlegesen drágább szoftverre előfizetni.  
Továbbá a cégvezetők amiatt is aggódnak, hogy a harmadik fél bepillantást nyerhet a vállalat rendszerébe, elolvashatja a fájlok tartalmát, esetleg el is adhatja a megszerzett információkat.

## 5. Igényelt üzleti folyamatok modellje
A megrendelő szeretne egy személyre szabott vírusirtó alkalmazást, amelyet korlátlanul használhatnak, nem kell érte minden hónapban havidíjat fizetni. Az átvizsgált fájlokhoz harmadik fél ne férhessen hozzá, ne használhassa fel azokat üzleti célokra.  
A legfontosabb elvárás, hogy a vírusirtó saját belső adatbázissal rendelkezzen, mely azokat a vállalat által specifikusan keresett malware fájltípusokat tartalmazza, amelyeket a korábban használt vírusirtó nem. Mindez legyen hash alapú, a nagyobb hatékonyság érdekében. Legyen lehetőség az átfésülni kívánt mappa kiválasztására, ne kelljen mindig a teljes rendszert ellenőrizni. Képes legyen lekérdezni a háttérben futó processzeket, azokat szükség esetén abortálni, leállítani.

## 6. Követelménylista
| **Id** |   **Modul**  |           **Név**          |                                                                                                                      **Leírás**                                                                                                                     |
|:------:|:------------:|:--------------------------:|:---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------:|
|   K1   |    Felület   |           Főablak          | Az alkalmazás főablaka, itt választhatja ki a felhasználó, hogy milyen műveletet szeretne végrehajtani. A felület legyen egyszerű, letisztult, könnyen átlátható.                                                                                   |
|   K2   | Víruskeresés | Teljes rendszer vizsgálata | A program a teljes rendszert átvizsgálja, az adatbázisban szereplő malware-ek után kutatva. Ez egy alapos, átfogó vizsgálat, amely hosszabb időt vesz igénybe.                                                                                      |
|   K3   | Víruskeresés |  Kijelölt mappa vizsgálata | A program csak a felhasználó által kiválasztott mappát vizsgálja át, nem a teljes rendszert. Ezáltal csökken a vizsgálat futási ideje. Akkor célszerű ezt választani, ha kisebb változtatások után csak az érintett részeket szeretnék átvizsgálni. |
|   K4   | Víruskezelés |     Karanténba helyezés    | A vizsgálat során talált vírusok, malware-ek, kétes fájlok karanténba helyezése. A rendszergazdák megtekinthetik a karanténba helyezett gyanús fájlokat.                                                                                            |
|   K5   |   Adatbázis  |  Saját központi adatbázis  | A vállalat által kiszűrni kívánt állományokat tartalmazza az adatbázis. Ezek némelyike más vírusirtók adatbázisaiban nem található meg. Az adatbázis legyen bővíthető.                                                                              |
|   K6   |    Funkció   |          Hashelés          | Az alkalmazás hash alapú kódokat használ a fájlok azonosítására. Ezeknek a kódoknak biztonsági és hatékonysági szempontból is előnyös a használatuk.                                                                                                |
|   K7   |  Processzek  |   Processzek lekérdezése   | A program lekérdezi az aktuálisan futó processzeket, és megjeleníti a részleteiket.                                                                                                                                                                 |
|   K8   |  Processzek  |    Processzek leállítása   | A kilistázott processzeket lehetőség van megszakítani és leállítani, ha a processz nem válaszol, vagy túl sok erőforrást használ.                                                                                                                   |

## 7. Fogalomszótár
- **Malware:** A rosszindulatú számítógépes programok összefoglaló neve. Ide tartoznak: a vírus, féreg, kémprogram, zsarolóprogram, agresszív reklámprogram, és minden egyéb kártékony szoftver.
- **Processz:** Folyamat, egy programnak a számítógép operatív memóriájába töltött, futtatás alatt álló példánya. Ezek nemcsak a felhasználó által éppen használt alkalmazások lehetnek, hanem különböző rendszerfolyamatok, amik a háttérben futnak, illetve a számítógépet megfertőző malware-ek is indíthatnak káros processzeket.  
- **Hash:** A hashelés azt a folyamatot jelenti, amelynek során egy változó méretű bemenetből egy fix méretű kimenetet állítunk elő. Ez a hash függvénynek nevezett matematikai függvények (hash-algoritmusok) használatával történik. A hash az ezen algoritmusok által előállított, fix hosszúságú karkatersorozat.
- **Karantén:** A karantén fő funkciója a talált gyanús objektumok (például kártevő, fertőzött fájlok vagy kéretlen alkalmazások) biztonságos tárolása.

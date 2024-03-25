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
A fenti okokból kifolyólag születet a döntés, hogy megbízzák csapatunkat egy személyre szabott alkalmazás megalkotásával.
Az elsődleges cél az, hogy a vírusirtó egy saját adatbázisból dolgozzon, amelybe a vállalat által kiszűrni kívánt malware-ek felvehetőek, és amely igény esetén kibővíthatő. Ezáltal nemcsak az integrációs problémáknak vetnek véget, hanem azt is biztosítják, hogy a szoftber minden potenciálisan kártékony fájlt megtaláljon.  
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

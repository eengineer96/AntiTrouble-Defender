# Követelmény specifikáció az AntiTrouble-Defender vírusirtó alkalmazáshoz
## 1. Áttekintés, összefoglaló
Egy fejlődő informatikai vállalat azzal bízta neg cégünket, hogy tervezzünk meg és készítsünk el egy olyan vírusirtó alkalmazást, amely megfelel az igényeiknek.
Az általuk eddig használt vírusirtó szoftver már csak korlátozott ideig elérhető, és egyébként sem tartalmazott minden olyan funkciót, amelyre a vállalatnak szüksége lenne.
Ezért a cégvezetők és a fejlesztők közös megbeszélés után azt a döntést hozták, hogy felkérik cégünket egy személyre szabott vírusirtó alkalmazás elkészítésére.

## 2. A jelenlegi helyzet leírása
A cég eddig egy harmadik féltől származó vírusirtó alkalmazást vett igénybe, mellyel több probléma is volt. Először is, a használathoz elő kellett fizetniük, mely havonta egy nem túl nagy, ám hosszútávon már jelentős összeggel terhelte a vállalatot.
Több alkalommal is előfordult, hogy a vírusirtó által használt adatbázisban nem szerepeltek azok a malware-ek, amelyeknek megkeresésére szerettek volna vizsgálatot indítani. Emiatt egy alkalommal benne maradt a rendszerben egy kétes eredetű fájl, az okozott hibák javítása pedig bevételkiesést okozott a cégnek.

## 3. Vágyálomrendszer leírása
A fenti okokból kifolyólag születet a döntés, hogy megbízzák csapatunkat egy személyre szabott alkalmazás megalkotásával.
Az elsődleges cél az, hogy a vírusirtó egy saját adatbázisból dolgozzon, amelybe a vállalat által kiszűrni kívánt malware-ek felvehetőek, és amely igény esetén kibővíthatő. Ezáltal nemcsak az integrációs problémáknak vetnek véget, hanem azt is biztosítják, hogy a szoftber minden potenciálisan kártékony fájlt megtaláljon.
Elvárás még, hogy a rendszerükön végzett kisebb módosítások után ne kelljen mindig a teljes rendszert átvizsgálni, legyen lehetőség az érintett könyvtárakat kiválasztani, és csak azokat átfésülni, az ellenőrzés meggyorsítása érdekében.
Célkitúzés továbbá, hogy a rendszerben futó processzeket, folyamatokat is le lehessen kérdezni, szükség esetén kontrollálni, leállítani.


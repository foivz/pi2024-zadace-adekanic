# Specifikacija softverskih zahtjeva za gradski prijevoz putnika

## 1. Uvod
### 1.1 Svrha
Svrha ovog dokumenta je definiranje zahtjeva i specifikacija potrebnih za digitalizaciju javnog prijevoza u gradu Varaždin. 
Dokument služi kao osnovni vodič za razvoj digitalnog sustava koji će omogućiti unaprjeđenje kvalitete usluge prijevoza za putnike, optimizaciju poslovnih procesa tvrtke te povećanje efikasnosti i točnosti pružanja usluge.
Ovaj dokument je namjenjen sudionicima digitalizacije javnog prijevoza u gradu Varaždin. To uključuje menadžment tvrtke, koji će koristiti dokument kao smjernicu za definiranje strategije i ciljeva projekta, te osigurati resurse potrebne za njegovu provedbu.
Također, dokument je namijenjen razvojnom timu koji će ga koristiti kao temelj za razvoj digitalnog sustava, kao i za testiranje i implementaciju specificiranih funkcionalnosti. Dokumentacija je namjenjena zaposlenicima koji će svakodnevno koristiti novi sustav. 
### 1.2 Opseg
Nadalje programsko rješenje će se oslovljavati s **„BusVaraždin“**.  
BusVaraždin koristi se u kontekstu digitalizacije poslovanja Gradskih autobusa Varaždin kako bi se unaprjeđenje kvalitete usluge gradskog autobusnog prijevoza. Trenutno se poslovanje tvrtke vodi "na papiru", što rezultira sporim procesima, nedostatkom informacija i manjom efikasnošću. Ključni problemi uključuju nedostatak jasne informacije o voznom parku, stanicama, linijama i voznim redovima za putnike, praćenje lokacije autobusa. Osim toga, umirovljenici, kao česti korisnici usluga, često su suočeni s nedostatkom informacija o putovanjima do željenih odredišta. Ova digitalna platforma BusVaraždin će omogućiti efikasnije upravljanje vozilima, stanicama, linijama i voznim redovima, što rezultira poboljšanim iskustvom putnika. Također, BusVaraždin omogućuje putnicima lakši pristup informacijama o voznim linijama, voznim redovima i dolasku autobusa, kao i brži proces kupovine karata i ukrcavanja u autobus BusVaraždin pruža temelj za modernizaciju i optimizaciju poslovanja gradskog prijevoza, istovremeno poboljšavajući zadovoljstvo korisnika i efikasnost.
Sustav će omogućiti praćenje lokacije autobusa tako da vozač zabilježi da je otišao sa stanice, što će putnicima pružiti točne informacije o dolasku autobusa na stanice. Omogućit će se definiranje voznih linija i voznih redova, čime će se osigurati bolja organizacija i efikasnost prijevoznog sustava. Putnicima će biti omogućen pristup informacijama o voznim linijama, voznim redovima i lokaciji autobusa putem aplikacije, olakšavajući im planiranje putovanja. Također, sustav će automatizirati proces prodaje karata putem kioska, čime će se smanjiti vrijeme čekanja putnika i povećati efikasnost pri kupnji karata. Evidencija broja putnika u autobusu omogućit će bolje upravljanje kapacitetom i smanjenje pretrpanosti, pri čemu će vozač pokušati što preciznije odrediti broj putnika koristeći ponuđene opcije, dok će čitač karata brojati koliko je karata očitao.
Ovim funkcionalnostima, novi sustav će značajno unaprijediti iskustvo putnika, povećati efikasnost poslovanja tvrtke te pridonijeti boljoj organizaciji i upravljanju gradskim prijevozom. Softver neće moći kontrolirati prometne gužve ili utjecati na točnost dolaska autobusa u slučaju prometnih problema. Također, neće moći spriječiti fizičke probleme s autobusima, kao što su kvarovi ili neplanirani zastoji. Iako će pružiti brojne koristi i unapređenja u poslovanju, važno je imati realna očekivanja o tome što softver može i ne može postići.
### 1.3 Definicije, akronimi i skraćenice
**Softver** je skup podataka i računarskih instrukcija koje računaru govore kako treba da radi.  
Primarna svrha koju **TCP/IP** ima je vezana za omogućavanje nesmetane komunikacije i to među računarima koji su međusobno ili na server povezani.
### 1.4 Reference
https://bs.wikipedia.org/wiki/Softver  
https://www.oxfordwebstudio.com/da-li-znate/sta-je-tcp-ip.html

### 1.5 Struktura dokumenta
Ostatak sadrži „Općeniti opis“ koji će pojasniti perspektivu proizvoda, funkcije proizvoda, karakteristike proizvod, ograničenja, pretpostavke i ovisnosti. Sadrži „Funkcionalan zahtjev“ kojim se detaljno specificiraju zahtjevi kako bi ih programeri i dizajneri lakše realizirali. „Nefunkcionalni zahtjev“ sadrži opis izgleda sučelja aplikacije, te prilagođenost grupi korisnika.

## 2. Općeniti opis
### 2.1 Perspektiva proizvoda
BusVaraždin nije potpuno neovisno i samostalno, već je usko povezano s drugim sustavima. Novo softversko rješenje ima mogućnost integracije sa sustavima za očitavanje karata. Također omogućit će se prodaja karata na kiosku autobusnih stanica. Prilikom ulaska autobus, umjesto očitavanja karte od strane vozača, putnik sam očitava kartu na čitaču postavljenom na ulazu Ovaj pristup omogućuje učinkovitije upravljanje voznim parkom, optimizaciju voznih redova i poboljšanje korisničkog iskustva. Sučelja među različitim sustavima bit će pažljivo definirana kako bi se osigurala glatka razmjena podataka i koordinacija aktivnosti.
Osim toga, BusVaraždin će omogućiti praćenje lokacije autobusa u stvarnom vremenu Kroz ovu integraciju, softversko rješenje postaje bitan dio gradskog prijevoza, pružajući bolje iskustvo. BusVaraždin će uzimati u obzir prometne gužve ili zastoje kako bi se putnike obavjestilo o mogućem kašnjenju.
Uz to, sučelje naše softverske platforme bit će ključno za usklađivanje s različitim hardverskim i komunikacijskim tehnologijama kako bi se osigurala efikasna integracija s drugim sustavima. Različite komunikacijske tehnologije poput TCP/IP protokola ili IC čitača mogu se koristiti za sigurno očitavanje karata putnika.
### 2.2 Funkcije proizvoda
1.	**Praćenje lokacije vozila**: Omogućuje praćenje stvarnog položaja autobusa kako bi se putnicima pružile točne informacije o dolasku i odlasku vozila.
2.	**Upravljanje voznim parkom**: Omogućuje definiranje i upravljanje vozilima u voznom parku, uključujući dodavanje, uklanjanje i raspoređivanje vozila na određene linije.
3.	**Definiranje i upravljanje autobusnim stanicama**: Omogućuje definiranje i održavanje informacija o autobuskim stanicama, uključujući lokaciju, naziv i povezane linije.
4.	**Definiranje vozni redova**: Omogućuje prilagodbu voznog reda prema potrebama i promjenama u prometu.
5.	**Prikaz vozno-redovnih informacija**: Putnicima omogućuje pristup jasnim informacijama o voznom redu, pomažući im u planiranju putovanja.
6.	**Korisnička podrška i sustav povratnih informacija**: Omogućuje korisnicima da pruže povratne informacije, postave pitanja ili izraze zabrinutost putem 
 komunikacije aplikacije
7.	**Mogućnost planiranja putovanja**: Korisnicima omogućuje planiranje putovanja s preporukama za najbrži ili najučinkovitiji put do odredišta.
8.	**Generiranje izvještaja o performansama**: Omogućuje generiranje izvještaja o performansama sustava radi analize vožnje, broja putnika i drugih relevantnih podataka.
9.	**Brojanje putnika**: Na ulazu će biti postavljen čitač karata koji će utvrditi ispravnost karata i broj putnika koji su usli u autobus. Broj putnika koji su izašli će evidentirati vozač busa na ekranu. Vozač busa će odabrati opcije koliko je putnika izašli , te će putnicima pružiti informaciju o broju putnika u autobusu.

## 2.3 Karakteristike korisnika
**Administratori** posjeduju napredno računalno znanje i iskustvo u upravljanju softverskim sustavima. Odgovorni su za postavljanje i održavanje konfiguracije sustava, upravljaju korisničkim računima i pravima pristupa, generiraju izvještaje i analiziraju podatke, nadziru sigurnosne postavke i osiguravaju integritet podataka.  
**Vozači busa** imaju osnovno računalno znanje i iskustvo u korištenju softvera. Njihova glavna uloga je operativna, a ne administrativna. Koriste softver za praćenje vozila u stvarnom vremenu, te za komunikaciju putem sustava za informiranje o stanju vožnje i eventualnim promjenama u rutama ili rasporedu vožnje.  
**Putnici** koriste softver za kupovinu karata, praćenje vozila u stvarnom vremenu, pregled vozne rute i planiranje putovanja, te pružati povratne informacije i prijedloge za poboljšanje usluge. Njihova učestalost korištenja softvera varira ovisno o potrebama i navikama putnika. Putnici su vrlo raznolika skupina korisnika s različitim razinama računalne pismenosti.  
**Tehnička podrška** pružaju podršku korisnicima, rješavati tehničke probleme i otklanjati poteškoće u radu s softverom, te komunicirati s ostalim korisnicima i razvijateljima kako bi osigurala učinkovito funkcioniranje sustava. Njihova uloga je reaktivna i fokusirana na rješavanje tehničkih problema kad se pojave. Zaposlenici tehničke podrške posjeduju napredno računalno znanje i iskustvo u rješavanju tehničkih problema.  

## 2.4 Ograničenja
Postojeći zakonski i korporacijski propisi te regulative imaju značajan utjecaj na razvoj softverskog rješenja za gradski prijevoz. Unutarnji propisi i politike tvrtke, poput pravila o upravljanju podacima, pravila o zaštiti intelektualnog vlasništva ili pravila o sigurnosti informacija, mogu postaviti ograničenja na način razvoja, implementacije i korištenja softverskog rješenja. Uvođenje digitalizacije u poslovanje Gradskih autobusa Varaždin nailazi na nekoliko hardverskih ograničenja koja treba uzeti u obzir. Implementacija digitalnog sustava zahtijevat će instalaciju dodatne opreme poput čitača karata u svakom autobusu, što može biti izazovno zbog različitih veličina i karakteristika vozila. Osim toga, potrebno je osigurati stabilnu komunikacijsku infrastrukturu kako bi se omogućila brza razmjena podataka između autobusa i središnjeg sustava za upravljanje. S obzirom na ograničeni prostor u autobusima, važno je dizajnirati kompaktne i ergonomske uređaje koji neće ometati putnike ili vozača autobusa. Također, važno je osigurati da svi dodatni uređaji budu sigurni i otporni na vanjske utjecaje kako bi se spriječili kvarovi ili oštećenja tijekom svakodnevne uporabe. Uz sve ovo, potrebno je provesti obuku za osoblje kako bi se osigurala pravilna uporaba i održavanje novih hardverskih komponenti. Visoki standardi pouzdanosti zahtijevaju detaljno planiranje, testiranje i implementaciju kako bi se osiguralo da softver ispravno funkcionira u različitim scenarijima i uvjetima. Ovo može produžiti vrijeme razvoja, jer je potrebno provesti temeljito testiranje kako bi se identificirali i ispravili potencijalni problemi i greške. Također mogu ograničiti fleksibilnost softvera, jer se mogućnosti dodavanja novih značajki ili mijenjanja postojećih funkcionalnosti mogu ograničiti zbog potrebe održavanja visokih standarda pouzdanosti

## 2.5 Pretpostavke i ovisnost
Promjene u tehnološkom okruženju, poput novih verzija operativnih sustava ili promjena u infrastrukturi interneta, mogu zahtijevati prilagodbe u softverskom rješenju kako bi se osigurala kompatibilnost i funkcionalnost. Evolucija korisničkih potreba i preferencija može zahtijevati prilagodbe sučelja ili funkcionalnosti softvera kako bi se osiguralo zadovoljstvo korisnika. Izgradnja novih naselja ili promjene u urbanističkim planovima grada mogu utjecati na potrebu za prilagodbom ruta i rasporeda gradskog prijevoza. Otvoreno pitanje je moguće promjene u prometnim regulativama koje bi mogle zahtijevati prilagodbe softvera, poput promjena u zahtjevima za sigurnost ili evidenciju podataka.

## 2.6 Ostalo
Planiranje dugoročne podrške, uključujući redovite nadogradnje softvera i održavanje sustava, važno je za osiguranje kontinuirane funkcionalnosti i pouzdanosti rješenja tijekom vremena. Mogućnost prikupljanja i analize podataka o korištenju usluga gradskog prijevoza omogućava bolje razumijevanje potreba korisnika i identifikaciju područja za poboljšanje usluge, što rezultira optimizacijom operativnih procesa i povećanjem zadovoljstva korisnika.

## 3. Funkcionalan zahtjev

| Identifikator | Z-1  |
|----------|----------|
| Zahtjev | Sustav će omogućiti praćenje položaja autobusa  |
| Obrazloženje |  Praćenje lokacije vozila je ključno za poboljšanje iskustva putnika javnog prijevoza jer im puža točne informacije o dolasku i odlasku autobusa.  |
| Način provjere |  Ovaj testni scenarij uključivao bi evidentiranje da je vozač stigao na stanicu. Vozač će na ekranu potvrdit da je stigao na stanicu. Nakon toga se provjerava da li putnici vide promjene o mjestu autobusa. Nakon evidencije dolaska, vozač evidentira odlazak. Nakon toga se provjerava da li putnici vide promjene o mjestu autobusa. |
| Prioritet |  3  |
| Izvor | Specifikacija zahtjeva za softverom za gradski prijevoz   |


| Identifikator | Z-2  |
|----------|----------|
| Zahtjev | Sustav omogućuje upravljanje voznim parkom.  |
| Obrazloženje |  Definiranje i manipulacija vozilima omogućuje prilagodbu voznog parka trenutnim zahtjevima prijevoza, kao što su promjene u potražnji na određenim linijama ili popravci vozila  |
| Način provjere | Testirat će se dodavanje novih vozila, uklanjanje postojećih i raspoređivanje na linije.  |
| Prioritet |  3  |
| Izvor | Specifikacija zahtjeva za softverom za gradski prijevoz   |


| Identifikator | Z-3  |
|----------|----------|
| Zahtjev |  Sustav omogućuje definiranje autobusnim stanicama. |
| Obrazloženje |  Imajući informacije o lokaciji, nazivu i povezanim linijama autobusnih stanica, sustav omogućuje putnicima da lakše planiraju svoje putovanje.  |
| Način provjere |  Simuliramo dodavanje nove autobusne stanice i provjeravamo uspješno pohranjivanje s potrebnim informacijama. Provjeravam mogućnost uređivanja postojećih podataka. Konačno, izvršavamo testni scenarij brisanja stanice.|
| Prioritet |  2  |
| Izvor | Specifikacija zahtjeva za softverom za gradski prijevoz   |


| Identifikator | Z-4  |
|----------|----------|
| Zahtjev |  Sustav će omogućiti definiranje vozni redova. |
| Obrazloženje |  Definiranje voznih redova osigurava prilagodljivost i efikasnost javnog prijevoza. Promjene u prometu, poput radova na cestama ili događaja, zahtijevaju ažuriranje voznih redova kako bi putnicima osigurali točne informacije o dolasku vozila.  |
| Način provjere |  Korisnik će putem sučelja upravljati voznim redom: dodati, ukloniti linije, urediti vrijeme polazaka i dolazaka te spremiti izmjene. Zatim će se provjeriti vidljivost promjena korisnicima. |
| Prioritet |  1  |
| Izvor | Specifikacija zahtjeva za softverom za gradski prijevoz   |


| Identifikator | Z-5  |
|----------|----------|
| Zahtjev |  Sustav će omogućiti prikaz jasnih informacija o voznom redu putnicima. |
| Obrazloženje |  Zahtjev za prikazom vozno-redovnih informacija ključan je za pružanje putnicima pravovremenih i preciznih informacija o rasporedu autobusa, što optimizira njihovo vrijeme i povećava zadovoljstvo korisnika.  |
| Način provjere |  Scenarij uključuje provjeru točnosti prikaza vozno-redovnih informacija na autobusnoj stanici za određeni dan i vrijeme. Tester simulira korisnika pristupom informacijama putem mobilne aplikacije te provjerava jasnost i aktualnost prikaza informacija |
| Prioritet |  2  |
| Izvor | Specifikacija zahtjeva za softverom za gradski prijevoz   |



| Identifikator | Z-6   |
|----------|----------|
| Zahtjev | Sustav će omogućiti korisničku podršku. |
| Obrazloženje |  Ova funkcionalnost omogućuje da se prikupe važne povratne informacije o kvaliteti usluge, korisničkim potrebama i eventualnim problemima s kojima se korisnici susreću.  |
| Način provjere | Korisnik će putem aplikacije poslat upit ili žalbu. Nakon što je korisnik poslao upit ili žalbu treba se provjeriti da je tehnička podrška zadobila upit ili žalbu.  |
| Prioritet |  3  |
| Izvor | Specifikacija zahtjeva za softverom za gradski prijevoz   |


| Identifikator | Z-7  |
|----------|----------|
| Zahtjev | Sustav će omogućiti korisnicima funkcionalnost planiranja putovanja.  |
| Obrazloženje |  Omogućuje korisnicima dobivanje preporuka za najbrži ili najučinkovitiji put do odredišta.  |
| Način provjere | Provjerava se procjena vremena putovanja, broj prijevoza, presjedanja i ukupna duljina putovanja te korisnikov odabir preferirane rute.   |
| Prioritet |  4  |
| Izvor | Specifikacija zahtjeva za softverom za gradski prijevoz   |


| Identifikator | Z-8  |
|----------|----------|
| Zahtjev | Sustav će generirati izvještaje o performansama.  |
| Obrazloženje |  Kako bi se unaprijedilo iskustvo putnika i bolje rasporedili resursi potrebno je generitrati izvješaje.  |
| Način provjere | Simuliramo različite situacije u radu sustava, poput vožnje autobusa, promjena u broju putnika i vremenskih uvjeta. Prikupljamo potrebne podatke o vožnji i relevantnim informacijama. Zatim koristimo funkcionalnost sustava za generiranje izvještaja.  |
| Prioritet |  1  |
| Izvor | Specifikacija zahtjeva za softverom za gradski prijevoz   |



| Identifikator | Z-9   |
|----------|----------|
| Zahtjev |  Sustav omogućuje brojanje putnika. |
| Obrazloženje |  Omogućuje drugim putnicima na stanici koliko je putnika u autobusu. Putnicima se osigurava informacije pomoću koji mogu izbjeći gužve.  |
| Način provjere | Prilikom očitavanja karte na čitaću treba se provjeriti da li se broj putnika prikazan putnicima promjenio. U slučaju kada vozač odabire opciju koliko je ljudi izašli treba se provjeriti da li se broj putnika prikazan putnicima promjenio.  |
| Prioritet |  4  |
| Izvor | Specifikacija zahtjeva za softverom za gradski prijevoz   |

| Identifikator | Z-10   |
|----------|----------|
| Zahtjev |  Sustav će omogućiti pristup osjetljivim informacijama samo autentificiranim osobama. |
| Obrazloženje |  Omogućuje prikaz osjetljivih informacija samo ovlaštenim osobama (vozni park). Tako da samo ovlaštene osobe smiju unositi i čitati osljetljive podatke.  |
| Prioritet |  1  |
| Izvor | Specifikacija zahtjeva za softverom za gradski prijevoz   |

### 3.1 Dinamika realizacije zahtjeva
U prvoj verziji, fokus će biti na implementaciji ključnih zahtjeva.
Z-10 Sustav će omogućiti pristup samo autentificiranim korisnicima
Z-2 Sustav omogućuje upravljanje voznim parkom
Z-3 Sustav omogućuje definiranje autobusnim stanicama
Z-4 Sustav će omogućiti definiranje vozni redova
Z-5 Sustav će omogućiti prikaz jasnih informacija o voznom redu putnicima

U drugoj verziji će se realizirati ostali zahtjevi.
Z-1 Sustav će omogućiti praćenje položaja autobusa
Z-6 Sustav će omogućiti korisničku podršku
Z-7 Sustav će omogućiti korisnicima funkcionalnost planiranja putovanja
Z-8 Sustav će generirati izvještaje o performansama
Z-9 Sustav omogućuje brojanje putnika

## 4. Nefunkcionalni zahtjevi

### 4.1 Izgled softvera
NF-1 - Dizajna će formalan i korporativan izgled
NF-2 – Sustav će interakciju s korisnikom provoditi preko grafičkog sučelja

### 4.2 Upotrebljivost softvera
NF-3 - Sustav će biti jednostavan i imat će što manje mogućnosti za greške

### 4.3 Performanse softvera
NF-4 - Sustav će osigurat preciznost broj putnika između 1-10
NF-5 - Sustav će osigurat preciznost lokacija autobusa na razini stanice koju je napustio

### 4.4 Izvođenje softvera i okruženje 
NF-6 - Sustav će raditi na Windows 8  ili novijiem operacijskom sustavu

### 4.5 Sigurnost i privatnost
NF-7 - Sustav će samo ovlaštenim osobama dopustiti upravljanje voznim redom, upravljanje voznim parkom, definiranje lokacije autobusa i broja putnika.

### 4.6 Ostalo
Nema identificiranih dodatnih nefunkcionalnih zahtjeva.

## 5. Skice zaslona
### 5.1 Skica prijava u sustav
![b27f7e62-4776-496b-9f85-ecdc04ea3f9c](https://github.com/foivz/pi2024-zadace-adekanic/assets/162907951/bf055f6e-5ef1-47ae-a84b-20a478ec2878)
### 5.2 Definiranje stanica
![ceda2949-554b-4d6b-ad54-c7fe2466b4d8](https://github.com/foivz/pi2024-zadace-adekanic/assets/162907951/b38084ca-5ee7-46ae-a4bb-ad232392a1d8)
### 5.3 Definiranje voznog parka
![425b02a9-f37e-4511-bba5-45108e2a17ee](https://github.com/foivz/pi2024-zadace-adekanic/assets/162907951/7162a0de-e622-4226-a6cc-83d775aca0c4)
### 5.4 Skica žalbe
![aca4e73e-238b-49b2-8ee3-f11c7ad99e9f](https://github.com/foivz/pi2024-zadace-adekanic/assets/162907951/3c11499b-2a85-4d50-8ea3-21fca109551e)
### 5.5 Skica sučelja za putnike
![f26b066a-b5f2-4c05-ac00-87089594747d](https://github.com/foivz/pi2024-zadace-adekanic/assets/162907951/a78721a4-d7ee-477f-9a65-557ff163e7c4)



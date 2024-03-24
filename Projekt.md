# Specifikacija softverskih zahtjeva za gradski prijevoz putnika

## 1. Uvod
### 1.1 Svrha
Svrha ovog dokumenta je definiranje zahtjeva i specifikacija potrebnih za digitalizaciju javnog prijevoza u gradu Varaždin. 
Dokument služi kao osnovni vodič za razvoj digitalnog sustava koji će omogućiti unaprjeđenje kvalitete usluge prijevoza za putnike, optimizaciju poslovnih procesa tvrtke te povećanje efikasnosti i točnosti pružanja usluge.
Ovaj dokument je namjenjen sudionicima digitalizacije javnog prijevoza u gradu Varaždin. To uključuje menadžment tvrtke, koji će koristiti dokument kao smjernicu za definiranje strategije i ciljeva projekta, te osigurati resurse potrebne za njegovu provedbu.
Također, dokument je namijenjen razvojnom timu koji će ga koristiti kao temelj za razvoj digitalnog sustava, kao i za testiranje i implementaciju specificiranih funkcionalnosti. Dokumentacija je namjenjena zaposlenicima koji će svakodnevno koristiti novi sustav. 
### 1.2 Opseg
Programsko rješenje koristi se u kontekstu digitalizacije poslovanja Gradskih autobusa Varaždin kako bi se unaprjeđenje kvalitete usluge gradskog autobusnog prijevoza. Trenutno se poslovanje tvrtke vodi "na papiru", što rezultira sporim procesima, nedostatkom informacija i manjom efikasnošću. Ključni problemi uključuju nedostatak jasne informacije o voznom parku, stanicama, linijama i voznim redovima za putnike, praćenje lokacije autobusa. Osim toga, umirovljenici, kao česti korisnici usluga, često su suočeni s nedostatkom informacija o putovanjima do željenih odredišta. Ova digitalna platforma BusVaraždin će omogućiti efikasnije upravljanje vozilima, stanicama, linijama i voznim redovima, što rezultira poboljšanim iskustvom putnika. Također, BusVaraždin omogućuje putnicima lakši pristup informacijama o voznim linijama, voznim redovima i dolasku autobusa, kao i brži proces kupovine karata i ukrcavanja u autobus BusVaraždin pruža temelj za modernizaciju i optimizaciju poslovanja gradskog prijevoza, istovremeno poboljšavajući zadovoljstvo korisnika i efikasnost.
Sustav će omogućiti praćenje lokacije autobusa tako da vozač zabilježi da je otišao sa stanice, što će putnicima pružiti točne informacije o dolasku autobusa na stanice. Omogućit će se definiranje voznih linija i voznih redova, čime će se osigurati bolja organizacija i efikasnost prijevoznog sustava. Putnicima će biti omogućen pristup informacijama o voznim linijama, voznim redovima i lokaciji autobusa putem aplikacije, olakšavajući im planiranje putovanja. Također, sustav će automatizirati proces prodaje karata putem kioska, čime će se smanjiti vrijeme čekanja putnika i povećati efikasnost pri kupnji karata. Evidencija broja putnika u autobusu omogućit će bolje upravljanje kapacitetom i smanjenje pretrpanosti, pri čemu će vozač pokušati što preciznije odrediti broj putnika koristeći ponuđene opcije, dok će čitač karata brojati koliko je karata očitao.
Ovim funkcionalnostima, novi sustav će značajno unaprijediti iskustvo putnika, povećati efikasnost poslovanja tvrtke te pridonijeti boljoj organizaciji i upravljanju gradskim prijevozom. Softver neće moći kontrolirati prometne gužve ili utjecati na točnost dolaska autobusa u slučaju prometnih problema. Također, neće moći spriječiti fizičke probleme s autobusima, kao što su kvarovi ili neplanirani zastoji. Iako će pružiti brojne koristi i unapređenja u poslovanju, važno je imati realna očekivanja o tome što softver može i ne može postići.
### 1.3 Definicije, akronimi i skraćenice

### 1.4 Reference

### 1.5 Struktura dokumenta

## 2. Općeniti opis
### 2.1 Perspektiva proizvoda
BusVaraždin nije potpuno neovisno i samostalno, već je usko povezano s drugim sustavima. Novo softversko rješenje ima mogućnost integracije sa sustavima za očitavanje karata. Također omogućit će se prodaja karata na kiosku autobusnih stanica. Prilikom ulaska autobus, umjesto očitavanja karte od strane vozača, putnik sam očitava kartu na čitaču postavljenom na ulazu Ovaj pristup omogućuje učinkovitije upravljanje voznim parkom, optimizaciju voznih redova i poboljšanje korisničkog iskustva. Sučelja među različitim sustavima bit će pažljivo definirana kako bi se osigurala glatka razmjena podataka i koordinacija aktivnosti.
Osim toga, BusVaraždin će omogućiti praćenje lokacije autobusa u stvarnom vremenu Kroz ovu integraciju, softversko rješenje postaje bitan dio gradskog prijevoza, pružajući bolje iskustvo. BusVaraždin će uzimati u obzir prometne gužve ili zastoje kako bi se putnike obavjestilo o mogućem kašnjenju.
Uz to, sučelje naše softverske platforme bit će ključno za usklađivanje s različitim hardverskim i komunikacijskim tehnologijama kako bi se osigurala efikasna integracija s drugim sustavima.
### 2.2 Funkcije proizvoda
1.	**Praćenje lokacije vozila**: Omogućuje praćenje stvarnog položaja autobusa kako bi se putnicima pružile točne informacije o dolasku i odlasku vozila.
2.	**Upravljanje voznim parkom**: Omogućuje definiranje i upravljanje vozilima u voznom parku, uključujući dodavanje, uklanjanje i raspoređivanje vozila na određene linije.
3.	**Definiranje i upravljanje autobusnim stanicama**: Omogućuje definiranje i održavanje informacija o autobuskim stanicama, uključujući lokaciju, naziv i povezane linije.
4.	**Definiranje vozni redova**: Omogućuje prilagodbu voznog reda prema potrebama i promjenama u prometu.
5.	**Prikaz vozno-redovnih informacija**: Putnicima omogućuje pristup jasnim informacijama o voznom redu, pomažući im u planiranju putovanja.
6.	**Korisnička podrška i sustav povratnih informacija**: Omogućuje korisnicima da pruže povratne informacije, postave pitanja ili izraze zabrinutost putem različitih kanala komunikacije, poput internetskog obrasca, mobilne aplikacije
7.	**Mogućnost planiranja putovanja**: Korisnicima omogućuje planiranje putovanja s preporukama za najbrži ili najučinkovitiji put do odredišta.
8.	**Generiranje izvještaja o performansama**: Omogućuje generiranje izvještaja o performansama sustava radi analize vožnje, broja putnika i drugih relevantnih podataka.
9.	**Brojanje putnika**: Na ulazu će biti postavljen čitać karata koji će utvrditi ispravnost karata i broj putnika koji su usli u autobus. Broj putnika koji su izašli će evidentirati vozač busa na ekranu. Vozač busa će odabrati opcije koliko je putnika izašli , te će putnicima pružiti informaciju o broju putnika u autobusu


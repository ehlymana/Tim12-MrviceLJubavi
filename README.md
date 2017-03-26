##### Naziv Tima: Tim12-MrviceLJubavi

##### �lanovi Tima:

- Kupusovi� Elma
- Krupalija Ehlimana
- Mufti� Belma

#### Naziv teme: Glasanje na bosanskohercegova�kim izborima (u Sarajevu)

#### Opis teme

Potrebno je kreirati aplikaciju za (online) glasanje na izborima 
u Sarajevu.
Svrha sistema jeste omogu�iti lak�i na�in glasanja gra�anima BiH (Sarajlijama),
 ta�nije omogu�iti elektronsko glasanje ili pronalazak bira�kog mjesta 
(ukoliko se glasa� odlu�i za glasanje na listi�u).
Sam dolazak na bira�ko mjesto za neke glasa�e je nemogu� ili skoro
 pa nemogu� te bi u tom slu�aju online glasanje bilo najjednostavniji
 na�in.
Ukoliko se glasa� odlu�i za glasanje putem Interneta (ili odlu�i da 
ne�e nikako glasati), tada se ne�e 
kreirati njegov glasa�ki listi� te �e se time smanjiti ukupna potro�nja bud�etskog
novca i proizvodnja papira (�to je pozitivno za na�u okolinu).
Ukoliko glasa� �eli glasati na bira�kom mjestu, aplikacija �e mu
pomo�i da na�e lokaciju svog bira�kog mjesta te tako u�tedjeti njegovo vrijeme i novac.

#### Procesi

##### Registracija glasa�a
Glasa� se poku�a prijaviti u sistem koriste�i svoj JMBG, ime i prezime.
Ukoliko podaci nisu validni sistem mu prijavljuje gre�ku, a ukoliko su
validni tada se glasa� prijavljuje i time mu se omogu�uje glasanje
(ukoliko je glasa� prijavljen u vremenu glasanja), mogu�nost izbora na�ina
glasanja (elektronskim ili pismenim putem), pronalazak bira�kog mjesta,
pristup informacionom dijelu koji se sastoji od:
informacija o stranakama, pregleda kandidata, vrstama izbora, 
na�inima glasanja (online i na bira�kom mjestu) i obja�njenju kako glasati
u oba slu�aja, historije politike u BiH, novostima o izborima te pregled 
najnovijih tweetova sa Twitter accounta stranice.

##### Pregled kandidata
Glasa� ima mogu�nost da pogleda osnovne informacije o svakom kandidatu uz 
pomo�no filtriranje i sortiranje

##### Registracija administratora
Administrator ima poseban account kojim (kada se prijavi) mo�e odr�avati 
sistema u realnom vremenu i odr�avati bazu kandidata (zabranjeno je mijenjanje 
baze sa glasovima). Administrator mo�e promijeniti informacije o kandidatu,
dodati novog kandidata i obrisati kandidata iz baze, no samo do odre�enog roka
(ako trenutno izbori nisu u toku ili ako nije par dana pred izbor).

#### Funkcionalnosti
- mogu�nost odabira na�ina glasanja
- mogu�nost informisanja o na�inu glasanja i vrstama izbora
- mogu�nost prijave u sistem sa razli�itim privilegijama
- mogu�nost pronalaska bira�kog mjesta
- mogu�nost pregleda historije politike u BiH
- mogu�nost online glasanja
- mogu�nost odr�avanja baze kandidata (dodavanje, mijenjanje i brisanje)
- mogu�nost igranja igre
- mogu�nost informisanja o strankama i kandidatima
- mogu�nost pregleda novosti o teku�im izborima
- mogu�nost pregleda najnovijih �tweetova� sa Twitter accounta stranice
- mogu�nost pregeda svih trenutnih kandidata uz odre�ena filtriranja (po godinama,
stru�noj spremi, stranci, poziciji, dru�tvenim priznanjima, popularnosti) 

#### Akteri
1. Glasa� - Glasa� je osoba koja ima mogu�nost glasanja, odabira na�ina glasanja,
 pronalaska bira�kog mjesta (elektronskim ili pismenim putem), igranja igrice,
 pregleda informacionog dijela
2. Administrator - Administrator je osoba koja je zadu�ena za odr�avanje sistema
 i baze kandidata (dodavanje, brisanje i mijenjanje kandidata ali samo do odre�enog
roka). Mo�e upravljati oficijelnim [Twitter accountom](https://twitter.com/glasaj_ba) 
za izbore te dodavati, mijenjati i brisati dijelove informacionog dijela.
3. Sistem - Sistem �uva informacije o kandidatima, glasa�ima, glasovima, na�inima 
glasanja pojedinaca, bira�kim mjestima, 
ulicama koje pripadaju odre�enim bira�kim mjestima, mo�e upravljati statistikama u 
informacionom dijelu.
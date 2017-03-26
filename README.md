##### Naziv Tima: Tim12-MrviceLJubavi:chicken:

****
##### �lanovi Tima:

1. Kupusovi� Elma
2. Krupalija Ehlimana :dog:
3. Mufti� Belma :octocat:

### Naziv teme: Glasanje na bosanskohercegova�kim izborima (u Sarajevu) - Glasaj.ba

### Opis teme

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

### Procesi

##### Glasanje
Gra�anin unosi svoje podatke (ime, prezima, JMBG, broj li�ne karte, ulicu 
stanovanja, dr�avu iz koje glasa) te bira stranku i kandidate. Ukoliko
su podaci validni, podaci se unose u sistem i kadidat se obavje�ava o 
uspje�nom glasanju, u suprotnom sistem obavje�tava kadidata o gre�ki i
zahtijeva ponovni unos podataka i odabir kandidata i stranke. Ukoliko 
glasa� �eli glasati na bira�kom mjestu (i bira opciju za glasanje na bira�kom mjestu),
 tada se samo provjeravaju njegovi 
podaci (sistem obavje�tava glasa�a o ispravnosti podataka) i ukoliko su validni,
u sistem se unosi odluka glasa�a, ukoliko nisu, zahtijeva se ponovni unos podataka.

##### Pregled kandidata
Gra�anin ima mogu�nost da pogleda osnovne informacije o svakom kandidatu uz 
pomo�no filtriranje. Filtrirati kandidate mo�e po godinama,
stru�noj spremi, stranci, poziciji, dru�tvenim priznanjima, popularnosti.

##### Opcija za slijepe i slabovidne osobe
Pri pokretanju aplikacije korisnik mo�e klikom na dugme odabrati nastavak 
komunikacije sa sistemom uz pomo� zvu�nih signala.

##### Pronazak bira�kog mjesta
Gra�anin unosi ulicu u kojoj �ivi i sistem mu na osnovu nje javlja detaljnije
informacije o tome gdje se nalazi njegovo bira�ko mjesto (adresu i prikaz 
lokacije na google maps-u). Ukoliko ulica ne postoji, sistem javlja gre�ku i 
zahtijeva ponovni upis naziva ulice.
 
##### Registracija administratora
Administrator ima poseban account kojim (kada se prijavi) mo�e odr�avati 
sistema u realnom vremenu i odr�avati bazu kandidata (zabranjeno je mijenjanje 
baze sa glasovima). Administrator mo�e promijeniti informacije o kandidatu,
dodati novog kandidata i obrisati kandidata iz baze, no samo do odre�enog roka
(ako trenutno izbori nisu u toku ili ako nije par dana pred izbor). Prijavljuje
 se tako �to na glavnoj stranici aplikacije ima rubriku u koju unosi svoj 
username i password. Ukoliko podaci nisu ta�ni, sistem korisnika obavje�tava o
 gre�ki i zahtijeva ponovni unos podataka (ukoliko se koristnik �eli prijaviti).

### Funkcionalnosti
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
- mogu�nost komunikacije slijepih i slabovidnih osoba sa sistemom

### Akteri
1. Glasa� - Glasa� je osoba koja ima mogu�nost glasanja, odabira na�ina glasanja,
 pronalaska bira�kog mjesta (elektronskim ili pismenim putem), igranja igrice,
 pregleda informacionog dijela
2. Administrator - Administrator je osoba koja je zadu�ena za odr�avanje sistema
 i baze kandidata (dodavanje, brisanje i mijenjanje kandidata ali samo do odre�enog
roka). Mo�e upravljati oficijelnim [Twitter accountom](https://twitter.com/glasaj_ba) 
za izbore te dodavati, mijenjati i brisati dijelove informacionog dijela.
3. Sistem - Sistem �uva informacije o kandidatima, glasa�ima, glasovima, na�inima 
glasanja pojedinaca, bira�kim mjestima, 
ulicama koje pripadaju odre�enim bira�kim mjestima, tweetovima sa oficijelnog Twitter 
accounta, mo�e upravljati statistikama u informacionom dijelu, ukoliko do�e do gre�ke,
prijavljuje je, pru�a usluge i slijepim i slabovidnim osobama.